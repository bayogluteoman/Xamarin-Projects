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
                new CarouselModel("googleLogo.png","text1"),
                new CarouselModel("phamacyLogo2.png","text2"),

            };
            TheCarousel.ItemsSource = list;
        }
    }
}
