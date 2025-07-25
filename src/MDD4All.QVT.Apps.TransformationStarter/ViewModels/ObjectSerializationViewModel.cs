using MDD4All.FileAccess.Contracts;
using System.Reflection;

namespace MDD4All.QVT.Apps.TransformationStarter.ViewModels
{
    public class ObjectSerializationViewModel : DomainObjectViewModel
    {
        public ObjectSerializationViewModel(ParameterInfo parameter, 
                                            DomainParameterType domainParameterType, 
                                            IFileLoader fileLoader,
                                            IFileSaver fileSaver) : base(parameter,
                                                                         domainParameterType,
                                                                         fileLoader,
                                                                         fileSaver)
        {
        }

        private string _filename;

        public string Filename
        {
            get
            {
                return _filename;
            }
            set
            {
                _filename = value;
                RaisePropertyChanged(nameof(ReadyToRunTransformation));
            }
        }

        public string Format { get; set; } = "JSON";

        public override bool ReadyToRunTransformation
        {
            get
            {
                return !string.IsNullOrEmpty(Filename);
            }
        }
    }
}
