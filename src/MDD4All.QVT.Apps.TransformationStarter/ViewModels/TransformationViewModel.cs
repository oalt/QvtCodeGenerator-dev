using GalaSoft.MvvmLight;
using LL.MDE.Components.Qvt.Common.Attributes;
using MDD4All.FileAccess.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace MDD4All.QVT.Apps.TransformationStarter.ViewModels
{
    public class TransformationViewModel : ViewModelBase
    {
        private Type _transformationClass;
        private IFileLoader _fileLoader;
        private IFileSaver _fileSaver;

        public TransformationViewModel(Type transformationClass,
                                       IFileLoader fileLoader,
                                       IFileSaver fileSaver) 
        {
            _transformationClass = transformationClass;
            _fileLoader = fileLoader;
            _fileSaver = fileSaver;
        }

        public string Name
        {
            get
            {
                string result = string.Empty;

                if (_transformationClass != null)
                {
                    result = _transformationClass.Name;
                }

                return result;
            }
        }

        public bool ReadyToRunTransformation
        {
            get
            {
                bool result = true;
                foreach(DomainObjectViewModel enforceDomainViewModel in EnforceViewModels)
                {
                    if (result == false)
                    {
                        break;
                    }
                    result &= enforceDomainViewModel.ReadyToRunTransformation;
                    
                }

                foreach (DomainObjectViewModel checkDomainViewModel in CheckOnlyViewModels)
                {
                    if (result == false)
                    {
                        break;
                    }
                    result &= checkDomainViewModel.ReadyToRunTransformation;
                }

                foreach (PrimitiveDomainObjectViewModel primitiveDomainViewModel in PrimitiveDomainViewModels)
                {
                    if (result == false)
                    {
                        break;
                    }
                    result &= primitiveDomainViewModel.ReadyToRunTransformation;
                }
                return result;
            }
        }

        private MethodInfo _topRelationCall;

        public MethodInfo TopRelationCall
        {
            get
            {
                if (_topRelationCall == null)
                {
                    _topRelationCall = _transformationClass.GetMethods().Where(m => m.GetCustomAttribute(typeof(QvtTopRelationCall)) != null).First();
                }

                return _topRelationCall;
            }
        }

        public string TopRelationName
        {
            get
            {
                string result = string.Empty;
                if(TopRelationCall != null)
                {
                    result = TopRelationCall.Name;
                }
                return result;
            }
        }

        private List<ParameterInfo> _checkOnlyParameters = null;

        public List<ParameterInfo> CheckOnlyParameters
        {
            get
            {
                if (_checkOnlyParameters == null)
                {
                    _checkOnlyParameters = new List<ParameterInfo>();
                    if (TopRelationCall != null)
                    {
                        List<ParameterInfo> checkOnlyParameters = TopRelationCall.GetParameters().Where(parameter => parameter.GetCustomAttribute(typeof(QvtCheckOnlyParameter)) != null).ToList();
                        _checkOnlyParameters.AddRange(checkOnlyParameters);
                    }
                }
                return _checkOnlyParameters;
            }
        }

        List<DomainObjectViewModel> _checkOnlyViewModels = null;

        public List<DomainObjectViewModel> CheckOnlyViewModels
        {
            get
            {
                if(_checkOnlyViewModels == null)
                {
                    _checkOnlyViewModels = new List<DomainObjectViewModel>();

                    foreach (ParameterInfo parameterInfo in CheckOnlyParameters)
                    {
                        

                        if(parameterInfo.ParameterType.Namespace == "EA")
                        {
                            EaObjectSelectionViewModel eaObjectSelectionViewModel = new EaObjectSelectionViewModel(parameterInfo,
                                                                                                                   DomainParameterType.CheckOnly,
                                                                                                                   _fileLoader,
                                                                                                                   _fileSaver);

                            eaObjectSelectionViewModel.PropertyChanged += OnDomainViewModelPropertyChanged;

                            _checkOnlyViewModels.Add(eaObjectSelectionViewModel);
                        }
                        else
                        {
                            /// TODO
                        }
                        
                    }
                }
                return _checkOnlyViewModels;
            }
        }

        private List<ParameterInfo> _enforceParameters = null;

        public List<ParameterInfo> EnforceParameters
        {
            get
            {
                if (_enforceParameters == null)
                {
                    _enforceParameters = new List<ParameterInfo>();
                    if (TopRelationCall != null)
                    {
                        List<ParameterInfo> enforceParameters = TopRelationCall.GetParameters().Where(parameter => parameter.GetCustomAttribute(typeof(QvtEnforceParameter)) != null).ToList();
                        _enforceParameters.AddRange(enforceParameters);
                    }
                }
                return _enforceParameters;
            }
        }

        private List<ParameterInfo> _primitiveParameters = null;

        public List<ParameterInfo> PrimitiveParameters
        {
            get
            {
                if (_primitiveParameters == null)
                {
                    _primitiveParameters = new List<ParameterInfo>();
                    if (TopRelationCall != null)
                    {
                        List<ParameterInfo> primitiveParameters = TopRelationCall.GetParameters().Where(parameter => parameter.GetCustomAttribute(typeof(QvtPrimitiveParameter)) != null).ToList();
                        _primitiveParameters.AddRange(primitiveParameters);
                    }
                }
                return _primitiveParameters;
            }
        }

        private List<DomainObjectViewModel> _enforceViewModels = null;

        public List<DomainObjectViewModel> EnforceViewModels
        {
            get
            {
                if (_enforceViewModels == null)
                {
                    _enforceViewModels = new List<DomainObjectViewModel>();

                    foreach (ParameterInfo parameterInfo in EnforceParameters)
                    {
                        if (parameterInfo.ParameterType.Namespace == "EA")
                        {
                            EaObjectSelectionViewModel eaObjectSelectionViewModel = new EaObjectSelectionViewModel(parameterInfo,
                                                                                                                   DomainParameterType.Enforce,
                                                                                                                   _fileLoader,
                                                                                                                   _fileSaver);

                            eaObjectSelectionViewModel.PropertyChanged += OnDomainViewModelPropertyChanged;
                            _enforceViewModels.Add(eaObjectSelectionViewModel);
                        }
                        else
                        {
                            ObjectSerializationViewModel domainObjectViewModel = new ObjectSerializationViewModel(parameterInfo, 
                                                                                                                  DomainParameterType.Enforce,
                                                                                                                  _fileLoader,
                                                                                                                  _fileSaver);
                            domainObjectViewModel.PropertyChanged += OnDomainViewModelPropertyChanged;
                            _enforceViewModels.Add(domainObjectViewModel);
                        }
                        
                    }
                }
                return _enforceViewModels;
            }
        }

        

        private List<PrimitiveDomainObjectViewModel> _primitiveDomainViewModels = null;

        public List<PrimitiveDomainObjectViewModel> PrimitiveDomainViewModels
        {
            get
            {
                if(_primitiveDomainViewModels == null)
                {
                    _primitiveDomainViewModels= new List<PrimitiveDomainObjectViewModel>();

                    foreach(ParameterInfo parameterInfo in PrimitiveParameters)
                    {
                        PrimitiveDomainObjectViewModel domainObjectViewModel = new PrimitiveDomainObjectViewModel(parameterInfo,
                                                                                          DomainParameterType.Primitive,
                                                                                          _fileLoader,
                                                                                          _fileSaver);
                        
                        domainObjectViewModel.PropertyChanged += OnDomainViewModelPropertyChanged;
                        
                        _primitiveDomainViewModels.Add(domainObjectViewModel);
                        
                        
                    }
                }
                return _primitiveDomainViewModels;
            }
        }

        private void OnDomainViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "ReadyToRunTransformation")
            {
                RaisePropertyChanged("ReadyToRunTransformation");
            }
        }
    }
}
