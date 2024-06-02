using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using CRTLMCModInstallerApp.Core.Utility;
using CRTLMCModInstallerApp.ViewModels;
using CRTLMCModInstallerApp.Views;

namespace CRTLMCModInstallerApp;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var mainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel()
            };
            NavigationService.MainWindowViewModel = (MainWindowViewModel)mainWindow.DataContext;
            desktop.MainWindow = mainWindow;
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            // singleViewPlatform.MainView = new MainView
            // {
            //     DataContext = new MainViewModel()
            // };
            
            var mainWindow = new MainWindow
            {
                DataContext = new MainWindowViewModel()
            };
            NavigationService.MainWindowViewModel = (MainWindowViewModel)mainWindow.DataContext;
            singleViewPlatform.MainView = mainWindow;
        }

        base.OnFrameworkInitializationCompleted();
    }
}