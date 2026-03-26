using EA;

using LL.MDE.Components.Common.EnArLoader;
using LL.MDE.Components.Qvt.EnArImport;
using LL.MDE.Components.Qvt.Metamodel.QVTRelation;
using LL.MDE.Components.Qvt.QvtCodeGenerator.CodeGeneration;
using MDD4All.EAFacade.DataAccess.Cached;
using System.Diagnostics;
using System.Threading;

namespace LL.MDE.Components.Qvt.EnArIntegration
{
    public class EnArIntegrationHelper
    {
        private static bool CachingFinished { get; set; } = false;

        /// <summary>
        /// Generates the code for a transformation element of a given EnAr instance.
        /// This method can be called from EnAr UI directly.
        /// </summary>
        /// <param name="eaRepository">The EnAr instance.</param>
        /// <param name="transformationGuid">The identifier of the transformation for code generation.</param>
        /// <param name="absoluteOutputFolder">The output folder to put the code into.</param>
        /// <param name="useMetamodelInterface">If true, the generated code will rely on an IMetamodelInterface object. Otherwise, it will rely on standard C# getters/setters.</param>
        public static void GenerateTransformationCode(Repository eaRepository, string transformationGuid, string absoluteOutputFolder, 
                                                      bool useMetamodelInterface = true, 
                                                      bool generateMicroservice = false)
        {
            // Create hybrid repository of an EA instance
            CachedRepository hybridrepo = new CachedRepository(eaRepository);
            hybridrepo.CachingFinished += HybridrepoCachingFinished;
            hybridrepo.CacheAll();

            Debug.WriteLine("Caching model...");

            // Import the transformation as real qvt model
            EnArExplorer explorer = new EnArExplorer(hybridrepo, eaRepository);
            EnArImporterQVT importer = new EnArImporterQVT(explorer);
            IRelationalTransformation relationalTransformation = importer.ConstructRelationalTransformationFromGuid(transformationGuid);

            // Generate code from qvt model
            QVTCodeGeneratorHelper.GenerateAllCode(relationalTransformation, absoluteOutputFolder, useMetamodelInterface, generateMicroservice: generateMicroservice);
        }

        private static void HybridrepoCachingFinished(object sender, System.EventArgs e)
        {
            CachingFinished = true;

            Debug.WriteLine("Caching finished...");
        }
    }
}