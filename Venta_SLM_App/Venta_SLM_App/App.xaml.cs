using System;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Xaml;
using Venta_SLM_App.Pages;

namespace Venta_SLM_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            MainPage = new NavigationPage(new DispositivosPage());
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
