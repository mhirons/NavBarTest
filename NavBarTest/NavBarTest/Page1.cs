using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace NavBarTest
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            var button1 = new Button { Text = "Open Non-Modal" };
            var button2 = new Button { Text = "Open Modal" };

            Title = "Page 1";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Page 1" },
                    button1,
                    button2
                }
            };

            button1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Page2());
            };

            button2.Clicked += async (sender, e) =>
            {
                await Navigation.PushModalAsync(new Page2());
            };
        }
    }
}
