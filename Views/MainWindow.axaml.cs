using System.Reactive;
using avalonia_alienDB.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace avalonia_alienDB.Views;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
        
        this.WhenActivated(d =>
        {
            if (ViewModel is not null)
            {
                ViewModel.ShowDetailsWindow.RegisterHandler(async interaction =>
                {
                    var detailsWindow = new DetailsWindow()
                    {
                        DataContext = new DetailsWindowViewModel(interaction.Input)
                    };
                    await detailsWindow.ShowDialog(this);
                    interaction.SetOutput(Unit.Default);
                });
            }
        });
    }
}