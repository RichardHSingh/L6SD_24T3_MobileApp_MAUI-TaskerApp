using TaskNoter.MVVM.Views;

namespace TaskNoter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LandingPage();
        }
    }
}
