using System.Windows.Input;

using CAN_software.Contracts.Services;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CAN_software.ViewModels;

public class ShellViewModel : ObservableObject
{
    private readonly IRightPaneService _rightPaneService;
    private ICommand _loadedCommand;
    private ICommand _unloadedCommand;

    public ICommand LoadedCommand => _loadedCommand ?? (_loadedCommand = new RelayCommand(OnLoaded));

    public ICommand UnloadedCommand => _unloadedCommand ?? (_unloadedCommand = new RelayCommand(OnUnloaded));

    public ShellViewModel(IRightPaneService rightPaneService)
    {
        _rightPaneService = rightPaneService;
    }

    private void OnLoaded()
    {
    }

    private void OnUnloaded()
    {
        _rightPaneService.CleanUp();
    }
}


