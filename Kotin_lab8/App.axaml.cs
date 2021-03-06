using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Kotin_lab8.ViewModels;
using Kotin_lab8.Views;

namespace Kotin_lab8
{
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
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
                (desktop.MainWindow.DataContext as MainWindowViewModel).view = desktop.MainWindow;
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
