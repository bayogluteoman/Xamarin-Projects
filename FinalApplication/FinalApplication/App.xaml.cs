using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalApplication
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new string[] { "CollectionView_Experimental", "SwipeView_Experimental" });

            MainPage = new TabbedPages();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
