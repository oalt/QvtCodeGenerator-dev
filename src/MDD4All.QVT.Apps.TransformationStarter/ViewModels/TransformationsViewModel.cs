using LL.MDE.Components.Qvt.Common.Attributes;
using MDD4All.FileAccess.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace MDD4All.QVT.Apps.TransformationStarter.ViewModels
{
    public class TransformationsViewModel
    {

        private string _dllFileName;
        private IFileLoader _fileLoader;
        private IFileSaver _fileSaver;

        public TransformationsViewModel(IFileLoader fileLoader, IFileSaver fileSaver) 
        {
            _fileLoader = fileLoader;
            _fileSaver = fileSaver;
        }

        public void LoadTransformation(string dllFileName)
        {
            Transformations = new List<TransformationViewModel>();
            SelectedTransformation = null;

            _dllFileName = dllFileName;
            InitializeData();
        }

        private void InitializeData()
        {
            if (File.Exists(_dllFileName))
            {
                Assembly transformationAssembly = Assembly.LoadFrom(_dllFileName);

                List<Type> transformationClasses = transformationAssembly.GetTypes().Where(type => type.GetCustomAttribute(typeof(QvtTransformation)) != null).ToList();
                
                foreach (Type transformationClass in transformationClasses)
                {
                    TransformationViewModel transformationViewModel = new TransformationViewModel(transformationClass, _fileLoader, _fileSaver);
                    Transformations.Add(transformationViewModel);
                }

                if (Transformations.Count > 0)
                {
                    SelectedTransformation = Transformations[0];
                }
            }
        }

        public List<TransformationViewModel> Transformations { get; set; } = new List<TransformationViewModel>();

        public TransformationViewModel SelectedTransformation { get; set; } = null;
    }
}
