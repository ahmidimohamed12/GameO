using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageWin : ContentPage
    {
        public PageWin()
        {
            InitializeComponent();

            Device.StartTimer(TimeSpan.FromSeconds(5), () =>
            {
                if (MainPage.ctt == 1)
                    Navigation.PushModalAsync(new Page1());
                if (MainPage.ctt == 2)
                    Navigation.PushModalAsync(new Page2());
                if (MainPage.ctt == 3)
                   Navigation.PushModalAsync(new Page3());
                //if (MainPage.cyt == 3)
                //    Navigation.PushModalAsync(new Wi);
                //if (MainPage.cyt == 4)
                //    Navigation.PushModalAsync();
                //if (MainPage.cyt == 5)
                //    Navigation.PushModalAsync();
                //if (MainPage.cyt == 6)
                //    Navigation.PushModalAsync();
                return false;
            });
        }
    }
}