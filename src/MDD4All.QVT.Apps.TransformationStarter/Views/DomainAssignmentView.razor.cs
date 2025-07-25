using MDD4All.QVT.Apps.TransformationStarter.ViewModels;
using Microsoft.AspNetCore.Components;

namespace MDD4All.QVT.Apps.TransformationStarter.Views
{
    public partial class DomainAssignmentView
    {
        [Parameter]
        public DomainObjectViewModel DataContext { get; set; }

        [Parameter]
        public RenderFragment ChildContent { get; set; } = default!;

        private bool ShowUI { get; set; } = true;

        private string HeaderPanelClass
        {
            get
            {
                string result = "";
                if (DataContext.DomainParameterType == DomainParameterType.Enforce)
                {
                    result = "enforceHeaderPanel";
                }
                else if (DataContext.DomainParameterType == DomainParameterType.CheckOnly)
                {
                    result = "checkHeaderPanel";
                }
                else if (DataContext.DomainParameterType == DomainParameterType.Primitive)
                {
                    result = "primitiveHeaderPanel";
                }
                return result;
            }
        }

        private void OnButtonClick()
        {
            ShowUI = !ShowUI;
        }
    }
}