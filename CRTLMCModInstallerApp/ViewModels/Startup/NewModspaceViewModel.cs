using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Collections;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveUI;

namespace CRTLMCModInstallerApp.ViewModels.Startup;

public partial class NewModspaceViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _name = "", _description = "", _author = "", _minecraftVersion = "", _modloader = "fabric";

    public AvaloniaList<string> ModloaderVersions { get; } = ["fabric", "forge", "neoforge", "quilt"];

    public NewModspaceViewModel()
    {
        
    }
}