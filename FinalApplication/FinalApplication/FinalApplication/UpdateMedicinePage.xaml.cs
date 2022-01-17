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
    public partial class UpdateMedicinePage : ContentPage
    {
        public UpdateMedicinePage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "Medicine is updated !", "OK");
            await UpdateMedicine.Navigation.PopAsync();
        }
    }
}