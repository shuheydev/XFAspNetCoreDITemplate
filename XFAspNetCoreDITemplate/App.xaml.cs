using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace $safeprojectname$
{
    public partial class App : Application
    {
        public App(Page startupPage)
        {
            InitializeComponent();

            MainPage = startupPage;
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
