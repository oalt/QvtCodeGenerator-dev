using EA;
using GalaSoft.MvvmLight.Command;
using LL.MDE.Components.Qvt.EnArIntegration;
using System.Collections.Generic;
using System.Windows.Input;
using MDD4All.EnterpriseArchitect.Manipulations;
using System.Windows.Forms;

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
            ConvertPropertyMethodsToAttributes = new RelayCommand(ExecuteConvertPropertyMethodsToAttributes);
            GenerateMetamodelFromEmofCommand = new RelayCommand(ExecuteGenerateMetamodelFromEMOF);
        }

        public EA.Repository Repository { get; set; }

        public ICommand GenerateCodeCommand { get; private set; }

        public ICommand ConvertPropertyMethodsToAttributes { get; private set; }

        public ICommand GenerateMetamodelFromEmofCommand { get; private set; }


        private void ExecuteGenerateCode()
        {
            if (Repository != null)
            {
                EA.Element selectedElement = Repository.GetTreeSelectedObject() as EA.Element;

                if (selectedElement != null)
                {
                    if (selectedElement.Stereotype == "qvtTransformation")
                    {
                        //Repository.CreateOutputTab("QVT Generator");
                        //Repository.EnsureOutputVisible("QVT Generator");
                        //Repository.WriteOutput("QVT Generator", selectedElement.Name, 0);

                        string path = selectedElement.GetTaggedValueString("codePath");

                        if (string.IsNullOrEmpty(path))
                        {
                            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                            DialogResult dialogResult = folderBrowserDialog.ShowDialog();

                            if (dialogResult == DialogResult.OK)
                            {
                                path = folderBrowserDialog.SelectedPath;
                                selectedElement.SetTaggedValueString("codePath", path);
                            }
                        }

                        if (!string.IsNullOrEmpty(path))
                        {
                            EnArIntegrationHelper.GenerateTransformationCode(Repository, selectedElement.ElementGUID, path);
                        }
                    }
                }
            }
        }

        private void ExecuteConvertPropertyMethodsToAttributes()
        {
            if (Repository != null)
            {
                EA.Package package = Repository.GetTreeSelectedPackage() as EA.Package;

                if (package != null)
                {
                    for (short count = 0; count < package.Elements.Count; count++)
                    {
                        EA.Element element = package.Elements.GetAt(count) as EA.Element;

                        if (element != null && element.Type == "Class")
                        {
                            ConvertPropertyMethods(element);
                        }
                    }
                }
            }
        }

        private void ConvertPropertyMethods(EA.Element currentClass)
        {
            HashSet<string> existingAttributes = new HashSet<string>();

            for (short count = 0; count < currentClass.Attributes.Count; count++)
            {
                EA.Attribute attribute = currentClass.Attributes.GetAt(count) as EA.Attribute;

                if (!existingAttributes.Contains(attribute.Name))
                {
                    existingAttributes.Add(attribute.Name);
                }
            }

            for (short count = 0; count < currentClass.Methods.Count; count++)
            {
                EA.Method method = currentClass.Methods.GetAt(count) as EA.Method;

                string methodName = method.Name;

                if (method.Stereotype == "property" && !existingAttributes.Contains(methodName))
                {
                    EA.Attribute attribute = currentClass.AddAttribute(methodName, method.ReturnType);
                    attribute.Stereotype = "property";
                    attribute.Update();

                    existingAttributes.Add(methodName);
                }
            }
        }

        private void ExecuteGenerateMetamodelFromEMOF()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {

                //MetamodelFromJsonSchemaGenerator generator = new MetamodelFromJsonSchemaGenerator(Repository, openFileDialog.FileName, Repository.GetTreeSelectedPackage());

                //MetamodelFromEmofGenerator generator = new MetamodelFromEmofGenerator(Repository,
                //                                                                      openFileDialog.FileName,
                //                                                                      Repository.GetTreeSelectedPackage());

                //generator.ConvertEmofToMetamodel();
            }
        }
    } 
}
