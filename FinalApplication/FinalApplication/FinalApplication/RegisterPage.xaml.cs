using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, System.EventArgs e)
        {
            await DisplayAlert("Alert", "Succesfully Registered", "OK");
            await Navigation.PushModalAsync(new LoginPage());
        }
    }
}