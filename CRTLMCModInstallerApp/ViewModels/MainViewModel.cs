using System;
using CommunityToolkit.Mvvm.Input;
using CRTLMCModInstallerApp.Core.Utility;
using CRTLMCModInstallerApp.ViewModels.Startup;

namespace CRTLMCModInstallerApp.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [RelayCommand]
    public void ToNewModspace()
    {
        NavigationService.SetView(new NewModspaceViewModel());
        Console.WriteLine("Pressed");
    }
}