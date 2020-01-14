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

            Device.StartTimer(TimeSpan.FromSeconds(3), () =>
            {
                Navigation.PushModalAsync(new Page1());
                return false;
            });
        }
    }
}