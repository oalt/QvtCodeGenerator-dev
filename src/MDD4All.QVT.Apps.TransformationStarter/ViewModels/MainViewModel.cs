using MDD4All.EAFacade.DataAccess.Cached;
using MDD4All.EAFacade.ModelTree.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDD4All.QVT.Apps.TransformationStarter.ViewModels
{
    public class MainViewModel
    {

        private EA.Repository _originalRepository;

        public MainViewModel() 
        {
            string progId = "EA.Repository";
            Type type = Type.GetTypeFromProgID(progId);
            EA.Repository repository = Activator.CreateInstance(type) as EA.Repository;

            bool openResult = repository.OpenFile(@"C:\work\QvtCodeGenerator-dev\models\QvtTest.eapx");

            if (openResult)
            {
                _originalRepository = repository;
                repository.ShowWindow(1);

                CachedRepository cachedRepository = new CachedRepository(_originalRepository);
                cachedRepository.CacheAll();

                RepositoryTreeViewModel = new RepositoryTreeViewModel(cachedRepository);

            }
        }

        public RepositoryTreeViewModel RepositoryTreeViewModel { get; set; }
    }
}
