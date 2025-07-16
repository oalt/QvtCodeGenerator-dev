namespace EA.Extensions
{
    public static class EaMetamodelExtensions
    {
        public static EA.Repository Repository { get; set; }

        public static EA.Package ElementPackage(this EA.Element element)
        {
            EA.Package result = null;
            if(Repository != null)
            {
                result = Repository.GetPackageByID(element.PackageID);
            }
            return result;
        }
    }
}
