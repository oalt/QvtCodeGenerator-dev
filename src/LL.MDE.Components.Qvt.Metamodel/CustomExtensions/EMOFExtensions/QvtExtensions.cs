using LL.MDE.Components.Qvt.Metamodel.QVTBase;
using System.Collections.Generic;
using System.Linq;

namespace LL.MDE.Components.Qvt.Metamodel.CustomExtensions.EMOFExtensions
{
    public static class QvtExtensions
    {
        public static IEnumerable<EMOF.IPackage> GetMetaModelPackagesForTransformation(this ITransformation transformation)
        {
            List<EMOF.IPackage> result = new List<EMOF.IPackage>();

            foreach (ITypedModel typedModel in transformation.ModelParameter)
            {
                EMOF.IPackage usedPackage = typedModel.UsedPackage.First();
                if (usedPackage != null)
                {
                    result.Add(usedPackage);
                }
            }

            return result;
        }
    }
}
