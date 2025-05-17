using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace PocketProfile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Set the main page as a NavigationPage wrapping ProfilePage
            MainPage = new NavigationPage(new ProfilePage());
        }
    }
}
