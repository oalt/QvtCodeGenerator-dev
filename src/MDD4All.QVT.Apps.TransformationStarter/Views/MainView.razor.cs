

using MDD4All.QVT.Apps.TransformationStarter.ViewModels;

namespace MDD4All.QVT.Apps.TransformationStarter.Views
{
    public partial class MainView
    {
        private MainViewModel DataContext { get; set; }

        protected override void OnInitialized()
        {
            DataContext = new MainViewModel();
        }
    }
}