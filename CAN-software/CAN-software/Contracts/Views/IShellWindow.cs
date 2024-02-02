using System.Windows.Controls;

using CAN_software.Behaviors;

using MahApps.Metro.Controls;

namespace CAN_software.Contracts.Views;

public interface IShellWindow
{
    Frame GetNavigationFrame();

    void ShowWindow();

    void CloseWindow();

    Frame GetRightPaneFrame();

    SplitView GetSplitView();

    RibbonTabsBehavior GetRibbonTabsBehavior();
}
