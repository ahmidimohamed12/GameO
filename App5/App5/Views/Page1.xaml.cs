using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ButtonCircle.FormsPlugin;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            Remplire_Button();
        }
        public void Remplire_Button()
        {
            btn11.Text = "A";
            btn12.Text = "B";
            btn13.Text = "C";
            btn14.Text = "D";
            btn15.Text = "E";
            btn16.Text = "F";
            btn17.Text = "G";
            btn18.Text = "H";
            btn19.Text = "I";
            btn20.Text = "J";
            btn21.Text = "K";
            btn22.Text = "L";
            btn23.Text = "M";
            btn24.Text = "N";
            btn25.Text = "O";
            btn26.Text = "P";
            btn27.Text = "Q";
            btn28.Text = "R";
            btn29.Text = "S";
            btn30.Text = "T";
            btn31.Text = "U";
            btn32.Text = "V";
            btn33.Text = "W";
            btn34.Text = "X";
            btn35.Text = "Y";
            btn36.Text = "Z";

        }
    }
}