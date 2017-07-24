using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HelloWord
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //SETAR A MAIN PAGE COMO NAVIGATION PAGE
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            //DisplayAlert("Apresentação", "Bem vindo, " + txtNome.Text, "Show!!");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
