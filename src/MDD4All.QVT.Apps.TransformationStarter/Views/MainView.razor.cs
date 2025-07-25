using MDD4All.FileAccess.Contracts;
using MDD4All.QVT.Apps.TransformationStarter.ViewModels;
using Microsoft.AspNetCore.Components;
using System.Threading;

namespace MDD4All.QVT.Apps.TransformationStarter.Views
{
    public partial class MainView
    {
        [Inject]
        public IFileLoader FileLoader { get; set; }

        [Inject]
        public IFileSaver FileSaver { get; set; }

        private MainViewModel DataContext { get; set; }

        protected override void OnInitialized()
        {
            DataContext = new MainViewModel(FileLoader, FileSaver);
            DataContext.PropertyChanged += OnDataContextPropertyChanged;
        }

        private void OnDataContextPropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "ActiveViewState")
            {
                StateHasChanged();
            }
        }

        private void OnOpenTransformationAssembly()
        {
            SynchronizationContext.Current?.Post((_) =>
            {
                DataContext.OpenTransformationAssemblyCommand.Execute(null);
                StateHasChanged();
            }, null);
        }
    }
}