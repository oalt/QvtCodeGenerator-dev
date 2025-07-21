using MDD4All.UI.BlazorComponents.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace MDD4All.QVT.Apps.TransformationStarter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ServiceCollection services = new ServiceCollection();
            services.AddWpfBlazorWebView();
            services.AddBlazorWebViewDeveloperTools();

            services.AddSingleton<DragDropDataProvider>();


            Resources.Add("services", services.BuildServiceProvider());

            
        }
    }
}