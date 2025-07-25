using GalaSoft.MvvmLight.Command;
using MDD4All.EAFacade.DataAccess.Cached;
using MDD4All.EAFacade.ModelTree.ViewModels;
using MDD4All.FileAccess.Contracts;
using System;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MDD4All.QVT.Apps.TransformationStarter.ViewModels
{
    public class EaObjectSelectionViewModel : DomainObjectViewModel
    {
        public EaObjectSelectionViewModel(ParameterInfo parameter,
                                          DomainParameterType domainParameterType,
                                          IFileLoader fileLoader,
                                          IFileSaver fileSaver) : base(parameter,
                                                                       domainParameterType,
                                                                       fileLoader,
                                                                       fileSaver)
        {
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            ShowSelectionDialogCommand = new RelayCommand(ExecuteShowSelectionDialogCommand, CanExecuteShowSelectionDialogCommand);
            CloseSelectionDialogCommand = new RelayCommand(ExecuteCloseSelectionDialog);
        }

        public string ConnectionString { get; set; } = string.Empty;

        public RepositoryObjectViewModel SelectedObject { get; set; } = null;

        public bool ShowEaElementSelectionDialog { get; set; } = false;

        public EA.Repository OriginalRepository { get; set; }

        public RepositoryTreeViewModel RepositoryTreeViewModel { get; set; }

        private EA.Repository EaRepository { get; set; }

        #region COMMAND_DEFINITIONS
        public ICommand ShowSelectionDialogCommand { get; private set; }

        public ICommand CloseSelectionDialogCommand { get; private set; }

        #endregion

        private void ExecuteShowSelectionDialogCommand()
        {
            RepositoryTreeViewModel = null;
            ShowEaElementSelectionDialog = true;
            Task.Run(OpenAndCacheEaModelAsync);
        }

        private async Task OpenAndCacheEaModelAsync()
        {
            Task result = null;

            await Task.Run(() =>
            {
                string progId = "EA.Repository";
                Type type = Type.GetTypeFromProgID(progId);
                EaRepository = Activator.CreateInstance(type) as EA.Repository;

                bool openResult = EaRepository.OpenFile(ConnectionString);

                if (openResult)
                {
                    OriginalRepository = EaRepository;
                    EaRepository.ShowWindow(1);
                    

                    CachedRepository cachedRepository = new CachedRepository(OriginalRepository);
                    cachedRepository.CacheAll();



                    if (_parameter.ParameterType.Name == "Package")
                    {
                        RepositoryTreeViewModel = new RepositoryTreeViewModel(cachedRepository, false, false, false);
                        
                    }
                    else if (_parameter.ParameterType.Name == "Element")
                    {
                        RepositoryTreeViewModel = new RepositoryTreeViewModel(cachedRepository, true, true, false);
                    }
                    else if (_parameter.ParameterType.Name == "Diagram")
                    {
                        RepositoryTreeViewModel = new RepositoryTreeViewModel(cachedRepository, false, false, true);
                    }
                    RaisePropertyChanged("RepositoryTreeViewModel");
                }
            }
                );


        }

        private bool CanExecuteShowSelectionDialogCommand()
        {
            return !string.IsNullOrEmpty(ConnectionString);
        }

        private void ExecuteCloseSelectionDialog()
        {
            RepositoryObjectViewModel selectedObject = RepositoryTreeViewModel.SelectedRepositoryObject;

            if (selectedObject != null)
            {
                SelectedObject = selectedObject;
                ReadyToRunTransformation = true;
            }

            if (EaRepository != null)
            {
                EaRepository.Exit();
            }

            ShowEaElementSelectionDialog = false;
        }
    }
}
