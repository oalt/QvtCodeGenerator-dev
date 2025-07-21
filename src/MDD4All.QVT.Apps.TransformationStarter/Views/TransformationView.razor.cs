using MDD4All.QVT.Apps.TransformationStarter.ViewModels;
using Microsoft.AspNetCore.Components;

namespace MDD4All.QVT.Apps.TransformationStarter.Views
{
    public partial class TransformationView
    {
        [Parameter]
        public MainViewModel DataContext { get; set; }
    }
}