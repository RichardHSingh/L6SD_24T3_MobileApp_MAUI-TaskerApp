using TaskNoter.MVVM.ViewModels;

namespace TaskNoter.MVVM.Views;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();

		BindingContext = new MainViewModel();
	}
}