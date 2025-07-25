using MDD4All.QVT.Apps.TransformationStarter.ViewModels;
using Microsoft.AspNetCore.Components;
using System.Threading;

namespace MDD4All.QVT.Apps.TransformationStarter.Views
{
    public partial class TransformationSelectionView
    {
        [Parameter]
        public MainViewModel DataContext { get; set; }

        private void OnRadioButtonChange(ChangeEventArgs args, int index)
        {
            if(args.Value.ToString() == "on")
            {
                DataContext.TransformationsViewModel.SelectedTransformation = DataContext.TransformationsViewModel.Transformations[index];
            }
            StateHasChanged();
        }

        
    }
}