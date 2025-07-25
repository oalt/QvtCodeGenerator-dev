using MDD4All.FileAccess.Contracts;
using MDD4All.FileAccess.WPF;
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

            services.AddLocalization(options =>
            {

                options.ResourcesPath = "Resources";
            });

            services.AddSingleton<DragDropDataProvider>();
            services.AddSingleton<IFileLoader, WpfFileLoader>();
            services.AddSingleton<IFileSaver, WpfFileSaver>();

            Resources.Add("services", services.BuildServiceProvider());

            
        }
    }
}