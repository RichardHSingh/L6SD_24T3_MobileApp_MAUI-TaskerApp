using TaskNoter.MVVM.Views;

namespace TaskNoter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainView();
            //MainPage = new LandingPage();
            //MainPage = new NewTaskView();
            MainPage = new NavigationPage(new MainView());
        }
    }
}
