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
    public partial class play_page : ContentPage
    {
        public play_page()
        {
            InitializeComponent();
            var n = new TapGestureRecognizer();
            n.Tapped += (sender, e) =>
            {
                Navigation.PushModalAsync(new MainPage());
            };
            anim1.GestureRecognizers.Add(n);
        }


    }
}