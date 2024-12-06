using System;
using System.IO;
using System.Threading;
using EA;
using LL.MDE.Components.Common.Util;
using File = System.IO.File;
using Package = MDD4All.EAFacade.DataModels.Contracts.Package;
using MDD4All.EAFacade.DataAccess.Cached;
using System.Runtime.InteropServices.ComTypes;

namespace LL.MDE.Components.Common.EnArLoader
{
    /// <summary>
    /// To manage the retrieval of all the test data from a chosen EA file.
    /// </summary>
    public class EnArLoader
    {
        private const string GeneratorOutputPath = @"out\";

        public string AbsolutePathToOutput { get; set; }
        public EnArExplorer Explorer { get; set; }

        private EA.Repository Repository { get; set; }

        public CachedRepository CurrentLlRepository { get; set; }
        
        private string projectFolder;

        public bool DataModelReadyToUse { get; set; }

        /// <summary>
        /// To initialize EA with a given project file.
        /// The "Close" method should be called when it is over.
        /// </summary>
        /// <param name="fileName"></param>
        public EnArLoader()
        {
            
        }

        public void Load(EA.Repository repository)
        {
            Repository = repository;

            CurrentLlRepository = new CachedRepository(repository);
            CurrentLlRepository.CacheAll();

            CurrentLlRepository.CachingFinished += HybridRepositoryCachingFinished;

            
        }

        public void Load(string fileName, bool isAbsolute = false, bool makeCopy = true)
        {
            if (AbsolutePathToOutput == null)
            {
                // Find the model test file in the VS project
                projectFolder = VariousUtil.GetProjectFolder();
                // Create output folder
                AbsolutePathToOutput = Path.Combine(projectFolder, GeneratorOutputPath);
            }
            if (CurrentLlRepository == null)
            {
                // Creates EA instance
                Repository currentEaRepository = new Repository();

                Repository = currentEaRepository;

                string absolutePathToModel = "";
                // Opens the model file in the EA instance
                if (isAbsolute)
                {
                    absolutePathToModel = fileName;
                }
                else
                {
                    absolutePathToModel = Path.Combine(projectFolder, fileName);
                }
                

                if (makeCopy)
                {
                    string absolutePathToModelCopy = absolutePathToModel;
                    absolutePathToModelCopy = Path.ChangeExtension(absolutePathToModelCopy, ".tmp.eap");
                    if (File.Exists(absolutePathToModelCopy))
                    {
                        File.Delete(absolutePathToModelCopy);
                    }
                    File.Copy(absolutePathToModel, absolutePathToModelCopy);
                    absolutePathToModel = absolutePathToModelCopy;
                }

                bool openResult = currentEaRepository.OpenFile(absolutePathToModel);
                //Assert.True(openResult, "The file " + absolutePathToModel + "could not be opened");

                // Opens the model    
                CurrentLlRepository = new CachedRepository(currentEaRepository);
                CurrentLlRepository.CacheAll();

                CurrentLlRepository.CachingFinished += HybridRepositoryCachingFinished;
                for (int i = 0; i < 50; i++)
                {
                    if (DataModelReadyToUse == false)
                    {
                        Thread.Sleep(500);
                    }
                }

                if (DataModelReadyToUse == false)
                {
                    throw new Exception("Timeout when trying to open EnAr file " + fileName);
                }
                Explorer = new EnArExplorer(CurrentLlRepository, currentEaRepository);
            }
        }

        ~EnArLoader()
        {
            Close();
        }

        private void HybridRepositoryCachingFinished(object sender, EventArgs e)
        {
            DataModelReadyToUse = true;

            Explorer = new EnArExplorer(CurrentLlRepository, Repository);
        }

        /// <summary>
        /// Closes the current EA instance.
        /// </summary>
        public void Close()
        {
            try
            {
                CurrentLlRepository?.CloseFile();
                CurrentLlRepository?.Exit();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        /// <summary>
        /// Looks for a Package with a specific GUID in the current EnAr instance.
        /// (can only be called after Init)
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public Package GetEnAarPackage(string guid)
        {
            return CurrentLlRepository.GetPackageByGuid(guid);
        }

    }
}