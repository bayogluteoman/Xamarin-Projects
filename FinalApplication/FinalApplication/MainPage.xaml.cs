using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FinalApplication
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var list = new List<CarouselModel>
            {
                new CarouselModel("image1.jpg","You can search medicine."),
                new CarouselModel("image3.jpg","Find which pharmacy open."),
                new CarouselModel("image2.jpg","Lots of medicine various."),

            };
            TheCarousel.ItemsSource = list;
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new PharmacyInformationPage());
        }
    }
}
