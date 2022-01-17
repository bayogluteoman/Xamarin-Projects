using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalApplication
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        IList<Pharmacist> pharmacists = new ObservableCollection<Pharmacist>();

        public LoginPage(IList<Pharmacist> pharmacist)
        {
            this.pharmacists = pharmacist;
            InitializeComponent();
        }

        public LoginPage()
        {
            InitializeComponent();
        }


        private async void Register_Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new RegisterPage());
        }

        private async void Login_Button_Clicked(object sender, System.EventArgs e)
        {
            var model = new Pharmacist
            {
                Password = this.password.Text,
                Email = this.eMail.Text,
            };
            bool login = false;
            foreach (Pharmacist pharmacist in pharmacists)
            {
                if (pharmacist.Email == model.Email && pharmacist.Password == model.Password)
                {
                    login = true;
                    await DisplayAlert("Alert", "Succesfully Login", "OK");
                    await Navigation.PushModalAsync(new TabbedPages());
                }
            }
            if (login == false)
            {
                await DisplayAlert("Alert", "Wrong Password or Email", "OK");
            }

        }
    }
}