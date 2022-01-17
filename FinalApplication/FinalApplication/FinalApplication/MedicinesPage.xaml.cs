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
    public partial class MedicinesPage : ContentPage
    {
        public IList<Medicine> medicines = new ObservableCollection<Medicine>();

        public MedicinesPage()
        {
            InitializeComponent();
            fillMedicines();
            medicineList.BindingContext = medicines;

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Medicine.Navigation.PushAsync(new AddMedicinePage());
        }

        public void fillMedicines()
        {
            medicines.Add(new Medicine("Parol", "Info", "googleLogo.png","15"));
            medicines.Add(new Medicine("Parol", "Info", "googleLogo.png", "15"));
            medicines.Add(new Medicine("Parol", "Info", "googleLogo.png", "15"));
            medicines.Add(new Medicine("Parol", "Info", "googleLogo.png", "15"));
            medicines.Add(new Medicine("Parol", "Info", "googleLogo.png", "15"));
            medicines.Add(new Medicine("Parol", "Info", "googleLogo.png", "15"));

        }

        private void SwipeLeftItem_Invoked(object sender, EventArgs e)
        {
            var item = (SwipeItem)sender;
            var parameter = (Medicine)item.CommandParameter;
            //medicines.Remove(parameter);
        }

        private async void SwipeRightItem_Invoked(object sender, EventArgs e)
        {
            var item = (SwipeItem)sender;
            var parameter = (Medicine)item.CommandParameter;
            //medicines.Remove(parameter);
            await Medicine.Navigation.PushAsync(new UpdateMedicinePage());

        }

        private async void medicineList_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await DisplayAlert("Information", "Showing pharmacies that have selected medicine and opening pharmacies right now.", "OK");
            await Medicine.Navigation.PushAsync(new PharmacyMapPage());
        }
    }
}