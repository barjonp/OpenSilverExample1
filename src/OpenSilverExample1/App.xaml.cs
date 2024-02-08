using System.Windows;

namespace OpenSilverExample1
{
    public sealed partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var mainPage = new MainPage();
            Window.Current.Content = mainPage;
        }
    }
}
