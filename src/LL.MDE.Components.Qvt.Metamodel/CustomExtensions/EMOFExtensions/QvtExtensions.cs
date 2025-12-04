using LL.MDE.Components.Qvt.Metamodel.QVTBase;
using LL.MDE.Components.Qvt.Metamodel.QVTRelation;
using System.Collections.Generic;
using System.Linq;

namespace LL.MDE.Components.Qvt.Metamodel.CustomExtensions.EMOFExtensions
{
    public static class QvtExtensions
    {
        public static IEnumerable<EMOF.IPackage> GetMetaModelPackagesForTransformation(this ITransformation transformation)
        {
            List<EMOF.IPackage> result = new List<EMOF.IPackage>();

            foreach (IRelation relation in transformation.Rule.OfType<IRelation>())
            {
                if(relation.IsTopLevel == true)
                {
                    foreach (IRelationDomain domain in relation.Domain.OfType<IRelationDomain>())
                    {
                        try
                        {
                            EMOF.IPackage domainObejctTypePackage = domain.RootVariable.Type.Package;

                            EMOF.IPackage rootPackage = domainObejctTypePackage;

                            while (rootPackage.NestingPackage != null)
                            {
                                rootPackage = rootPackage.NestingPackage;
                            }

                            if (rootPackage != null)
                            {
                                result.Add(rootPackage);
                            }
                        }
                        catch
                        {

                        }
                    }
                }
            }

            return result;
        }
    }
}
