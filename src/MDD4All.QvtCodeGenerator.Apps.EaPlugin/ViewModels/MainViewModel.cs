using GalaSoft.MvvmLight.Command;
using LL.MDE.Components.Qvt.EnArIntegration;
using System.Windows.Input;

namespace MDD4All.QvtCodeGenerator.Apps.EaPlugin.ViewModels
{
    internal class MainViewModel
    {
        public MainViewModel() 
        {
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            GenerateCodeCommand = new RelayCommand(ExecuteGenerateCode);
        }

        public EA.Repository Repository { get; set; }

        public ICommand GenerateCodeCommand { get; private set; }

        private void ExecuteGenerateCode()
        {
            if (Repository != null)
            {
                EA.Element selectedElement = Repository.GetTreeSelectedObject() as EA.Element;

                if (selectedElement != null)
                {
                    if(selectedElement.Stereotype == "qvtTransformation")
                    {
                        //Repository.CreateOutputTab("QVT Generator");
                        //Repository.EnsureOutputVisible("QVT Generator");
                        //Repository.WriteOutput("QVT Generator", selectedElement.Name, 0);

                        EnArIntegrationHelper.GenerateTransformationCode(Repository, selectedElement.ElementGUID, @"c:\test\qvtcode");
                    }
                }
            }
        }
    }
}
