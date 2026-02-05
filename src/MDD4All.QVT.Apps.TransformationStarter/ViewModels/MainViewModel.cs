using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using MDD4All.EAFacade.ModelTree.ViewModels;
using MDD4All.FileAccess.Contracts;
using System.IO;
using System.Windows.Input;

namespace MDD4All.QVT.Apps.TransformationStarter.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        private EA.Repository _originalRepository;

        private IFileLoader _fileLoader;
        private IFileSaver _fileSaver;

        public MainViewModel(IFileLoader fileLoader, IFileSaver fileSaver) 
        {
            //string progId = "EA.Repository";
            //Type type = Type.GetTypeFromProgID(progId);
            //EA.Repository repository = Activator.CreateInstance(type) as EA.Repository;

            //bool openResult = repository.OpenFile(@"C:\work\QvtCodeGenerator-dev\models\QvtTest.eapx");

            //if (openResult)
            //{
            //    _originalRepository = repository;
            //    repository.ShowWindow(1);

            //    CachedRepository cachedRepository = new CachedRepository(_originalRepository);
            //    cachedRepository.CacheAll();

            //    RepositoryTreeViewModel = new RepositoryTreeViewModel(cachedRepository);

            //}
            _fileLoader = fileLoader;
            _fileSaver = fileSaver;

            TransformationsViewModel = new TransformationsViewModel(_fileLoader, _fileSaver);

            InitializeCommands();
        }

        private void InitializeCommands()
        {
            OpenTransformationAssemblyCommand = new RelayCommand(ExecuteOpenTransformationAssembly);
            OpenTransformationStartViewCommand = new RelayCommand(ExecuteOpenTransformationStartView);
            RunTransformationCommand = new RelayCommand(ExecuteRunTransformation);
        }

        public RepositoryTreeViewModel RepositoryTreeViewModel { get; set; }

        private ViewState _activeViewState = ViewState.ApplicationStart;

        public ViewState ActiveViewState
        {
            get
            {
                return _activeViewState;
            }
            set
            {
                _activeViewState = value;
                RaisePropertyChanged("ActiveViewState");
            }
        }

        public string StatusMessage { get; set; } = "Ready";

        public TransformationsViewModel TransformationsViewModel { get; set; }

        public ICommand OpenTransformationAssemblyCommand { get; private set; }

        public ICommand OpenTransformationStartViewCommand { get; private set; }

        public ICommand RunTransformationCommand { get; private set; }

        private void ExecuteOpenTransformationAssembly()
        {
            string selectedFile = string.Empty;
            bool openResult = _fileLoader.ShowOpenFileDialog(out selectedFile, defaultFileExtension: "DLL", filter: "DLLs (*.DLL)|*.DLL");

            if (openResult)
            {
                FileInfo fileInfo = new FileInfo(selectedFile);
                StatusMessage = "Transformation Assembly: " + fileInfo.Name;

                TransformationsViewModel.LoadTransformation(selectedFile);

                ActiveViewState = ViewState.TransformationSelection;
            }
        }

        private void ExecuteOpenTransformationStartView()
        {
            ActiveViewState = ViewState.TransformationStart;
        }

        private void ExecuteRunTransformation()
        {
            ActiveViewState = ViewState.TransformationRunning;

            TransformationCaller.CallTransformation(TransformationsViewModel.SelectedTransformation);
        }
    }
}
