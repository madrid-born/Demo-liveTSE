using Demo_liveTSE.Pages;

namespace Demo_liveTSE
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Home());
        }
    }
}