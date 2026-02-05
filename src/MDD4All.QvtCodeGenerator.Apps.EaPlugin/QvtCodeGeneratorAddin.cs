using MDD4All.QvtCodeGenerator.Apps.EaPlugin.ViewModels;
using System;

namespace MDD4All.QvtCodeGenerator.Apps.EaPlugin
{
    public class QvtCodeGeneratorAddin
    {
        private const string MAIN_MENUNAME = "QVT Code Generator";
        private const string MENU_GENERATE_CODE = "Generate Code";
        private const string MENU_CONVERT_PROPERTY_METHODS = "Convert Property Methods to Attributes";
        private const string MENU_GENERATE_METAMODEL_FROM_JSON_SCHEMA = "Generate Metamodel from EMOF";

        private MainViewModel MainViewModel { get; set; }

        public void EA_FileOpen(EA.Repository repository)
        {
            MainViewModel = new MainViewModel
            {
                Repository = repository
            };
        }

        public object EA_GetMenuItems(EA.Repository repository, string location, string menuName)
        {
            switch (menuName)
            {
                case "":
                    return "-&" + MAIN_MENUNAME;

                case "-&" + MAIN_MENUNAME:
                    string[] menuItems = { MENU_GENERATE_CODE, 
                                           MENU_CONVERT_PROPERTY_METHODS,
                                           MENU_GENERATE_METAMODEL_FROM_JSON_SCHEMA
                                          };
                    return menuItems;
            }
            return "";
        }

        bool IsProjectOpen(EA.Repository repository)
        {
            try
            {
                EA.Collection models = repository.Models;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void EA_GetMenuState(EA.Repository repository, string location,
                                    string menuName, string itemName,
                                    ref bool isEnabled, ref bool isChecked)
        {
            if (IsProjectOpen(repository))
            {
                isEnabled = true;
            }
            else
            {

                isEnabled = false;
            }

        }


        public void EA_MenuClick(EA.Repository repository, string location, string menuName, string itemName)
        {
            try
            {
                switch (itemName)
                {
                    case MENU_GENERATE_CODE:
                        MainViewModel.GenerateCodeCommand.Execute(null);
                        break;

                    case MENU_CONVERT_PROPERTY_METHODS:
                        MainViewModel.ConvertPropertyMethodsToAttributes.Execute(null);
                        break;

                    case MENU_GENERATE_METAMODEL_FROM_JSON_SCHEMA:
                        MainViewModel.GenerateMetamodelFromEmofCommand.Execute(null);
                        break;
                }
            }
            catch (Exception exception)
            {
                //log.Debug(ex.ToString());
            }
        }
    }
}
