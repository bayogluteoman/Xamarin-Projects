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
    public partial class RegisterPage : ContentPage
    {
        IList<Pharmacist> pharmacists = new ObservableCollection<Pharmacist>();

        public RegisterPage()
        {
            InitializeComponent();
        }
        private async void Register_Button_Clicked(object sender, System.EventArgs e)
        {
            var model = new Pharmacist
            {
                Password = this.password.Text,
                Email = this.eMail.Text,
                PharmacyName = this.pharmacyName.Text
            };
            pharmacists.Add(model);
            await DisplayAlert("Alert", "Succesfully Registered", "OK");
            await Navigation.PushModalAsync(new LoginPage(pharmacists));
        }
    }
   }
