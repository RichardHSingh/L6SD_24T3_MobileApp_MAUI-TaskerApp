using TaskNoter.MVVM.ViewModels;

namespace TaskNoter.MVVM.Views;

public partial class MainView : ContentPage
{
	private MainViewModel mainViewModel = new MainViewModel();

	public MainView()
	{
		InitializeComponent();

		BindingContext = mainViewModel;
	}

    private void checkbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		mainViewModel.UpdateData();
    }
}