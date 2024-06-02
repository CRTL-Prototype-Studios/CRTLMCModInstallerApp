using CRTLMCModInstallerApp.ViewModels;

namespace CRTLMCModInstallerApp.Core.Utility;

public static class NavigationService
{
    public static MainWindowViewModel MainWindowViewModel { get; set; }

    public static void SetView(ViewModelBase viewModel)
    {
        MainWindowViewModel?.SetView(viewModel);
    }

    public static void RevokeView()
    {
        MainWindowViewModel?.RevokeView();
    }
}