using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace NavBarTest
{
    public class App : Application
    {
        public App()
        {
            var mainPage = new Page1();

            MainPage = new NavigationPage(mainPage)
            {
                Style = new Style(typeof(NavigationPage))
                {
                    Setters = {
                        new Setter { Property = NavigationPage.BarBackgroundColorProperty, Value = Color.Pink },
                        new Setter { Property = NavigationPage.BarTextColorProperty, Value = Color.Lime }
                    }
                }
            };
            NavigationPage.SetHasBackButton(mainPage, false);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
