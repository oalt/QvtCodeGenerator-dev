using MDD4All.QVT.Apps.TransformationStarter.ViewModels;
using Microsoft.AspNetCore.Components;

namespace MDD4All.QVT.Apps.TransformationStarter.Views
{
    public partial class TransformationStartView
    {
        [Parameter]
        public MainViewModel DataContext { get; set; }

        public TransformationViewModel TransformationViewModel { get; set; }

        protected override void OnInitialized()
        {
            TransformationViewModel = DataContext.TransformationsViewModel.SelectedTransformation;

            TransformationViewModel.PropertyChanged += OnPropertyChanged;
        }

        private void OnPropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "ReadyToRunTransformation")
            {
                StateHasChanged();
            }
        }
    }
}