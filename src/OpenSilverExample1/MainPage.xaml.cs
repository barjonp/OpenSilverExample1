using Microsoft.JSInterop;
using System.Windows;
using System.Windows.Controls;

namespace OpenSilverExample1
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            IJSObjectReference objectReference = JSInterop.Runtime.Invoke<IJSObjectReference>("getJavaScriptObject");
            string message = await objectReference.InvokeAsync<string>("sendMessage", tb.Text);
            MessageBox.Show(message);
        }
    }
}
