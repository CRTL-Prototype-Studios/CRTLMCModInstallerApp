using System;
using System.Collections.Generic;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;

namespace CRTLMCModInstallerApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private ViewModelBase _contentViewModel = new MainViewModel();

    public Stack<ViewModelBase> ContentViewStack = new();
    
    public MainWindowViewModel()
    {
        SetView(new MainViewModel());
    }

    public ViewModelBase SetView(ViewModelBase viewModelBase)
    {
        ContentViewStack.Push(viewModelBase);
        ContentViewModel = ContentViewStack.First();
        Console.WriteLine($"[MWVM] Action --> Pushed View Model, Current {ContentViewModel.ToString()}");
        return ContentViewModel;
    }

    public ViewModelBase RevokeView()
    {
        if (ContentViewStack.Count <= 1) return ContentViewModel;
        ContentViewStack.Pop();
        ContentViewModel = ContentViewStack.First();
        return ContentViewModel;
    }

    public void ResetView()
    {
        while (ContentViewStack.Count > 1)
        {
            ContentViewStack.Pop();
        }
    }
    
    public void ResetToView(int index)
    {
        if (index + 1 > ContentViewStack.Count) throw new IndexOutOfRangeException("Cannot Reset View to an Index outside of bounds");
        while (ContentViewStack.Count > index + 1)
        {
            ContentViewStack.Pop();
        }
    }
}