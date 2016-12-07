using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace NavBarTest
{
    public class Page2 : ContentPage
    {
        public Page2()
        {
            var button = new Button { Text = "Close Page" };

            Title = "Page 2";
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Page 2" },
                    button
                }
            };

            button.Clicked += async (sender, e) =>
            {
                if (Navigation.ModalStack.Count > 0)
                {
                    await Navigation.PopModalAsync();
                }
                else
                {
                    await Navigation.PopAsync();
                }
            };
        }
    }
}
