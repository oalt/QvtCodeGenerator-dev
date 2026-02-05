using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MDD4All.FileAccess.Contracts;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Documents;
using System.Windows.Input;

namespace MDD4All.QVT.Apps.TransformationStarter.ViewModels
{
    public abstract class DomainObjectViewModel : ViewModelBase
    {
        protected ParameterInfo _parameter;
        
        protected IFileLoader _fileLoader;
        protected IFileSaver _fileSaver;

        public DomainObjectViewModel(ParameterInfo parameter, 
                                     DomainParameterType domainParameterType,
                                     IFileLoader fileLoader,
                                     IFileSaver fileSaver) 
        {
            _parameter = parameter;
            DomainParameterType = domainParameterType;
            _fileLoader = fileLoader;
            _fileSaver = fileSaver;
            
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            SelectFileToLoadCommand = new RelayCommand<string>(ExecuteSelectFileToLoad);
            SelectFileToSaveCommand = new RelayCommand<string>(ExecuteSelectFileToSave);
        }

        public DomainParameterType DomainParameterType { get; set; }

        public Type ParameterType
        {
            get
            {
                return _parameter.ParameterType;
            }
        }

        public string Title
        {
            get
            {
                string result = string.Empty;
                switch(DomainParameterType)
                {
                    case DomainParameterType.CheckOnly:
                        result += "Check only domain";
                        break;
                    case DomainParameterType.Enforce:
                        result += "Enforce domain";
                        break;
                    case DomainParameterType.Primitive:
                        result += "Primitve domain";
                        break;
                }

                result += " for ";

                result += _parameter.Name + " :" + _parameter.ParameterType.Name;

                return result;
            }
        }

        public string Name
        {
            get
            {
                return _parameter.Name;
            }
        }

        public string Namespace
        {
            get
            {
                return _parameter.ParameterType.Namespace;
            }
        }

        private bool _readyToRunTransformation = false;

        public virtual bool ReadyToRunTransformation 
        { 
            get
            {
                return _readyToRunTransformation;
            }
            protected set
            {
                _readyToRunTransformation = value;
                RaisePropertyChanged("ReadyToRunTransformation");
            }
        } 

        public string SelectedFilename { get; set; } = string.Empty;

        public bool FileSelectionResult { get; set; } = false;

        public object ParameterObject { get; set; } = null;

        public ICommand SelectFileToLoadCommand { get; private set; }

        public ICommand SelectFileToSaveCommand { get; private set;}

        private void ExecuteSelectFileToLoad(string title)
        {
            string selectedFile = string.Empty;
            bool openResult = _fileLoader.ShowOpenFileDialog(out selectedFile, title: title);

            if (openResult)
            {
                SelectedFilename = selectedFile;
                FileSelectionResult = true;
            }
            else
            {
                SelectedFilename = string.Empty;
                FileSelectionResult = false;
            }
            RaisePropertyChanged("FileSelectionResult");
        }

        private void ExecuteSelectFileToSave(string title)
        {
            string selectedFile = string.Empty;
            bool openResult = _fileSaver.ShowFileSaveDialog(out selectedFile, title: title);

            if (openResult)
            {
                SelectedFilename = selectedFile;
                FileSelectionResult = true;
            }
            else
            {
                SelectedFilename = string.Empty;
                FileSelectionResult = false;
            }
            RaisePropertyChanged("FileSelectionResult");
            RaisePropertyChanged("ReadyToRunTransformation");
        }
    }
}
