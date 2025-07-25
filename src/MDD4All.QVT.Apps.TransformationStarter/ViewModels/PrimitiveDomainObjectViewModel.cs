using MDD4All.FileAccess.Contracts;
using System.Reflection;

namespace MDD4All.QVT.Apps.TransformationStarter.ViewModels
{
    public class PrimitiveDomainObjectViewModel : DomainObjectViewModel
    {
        public PrimitiveDomainObjectViewModel(ParameterInfo parameter, 
                                              DomainParameterType domainParameterType, 
                                              IFileLoader fileLoader, 
                                              IFileSaver fileSaver) : base(parameter, 
                                                                           domainParameterType, 
                                                                           fileLoader, 
                                                                           fileSaver)
        {
        }

        // TODO: Check validity of data
        public override bool ReadyToRunTransformation
        {
            get
            {
                return true;
            }
        }
    }
}
