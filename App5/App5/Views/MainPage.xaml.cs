using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App5
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int n1, n2, n3, n4;
        int ct = 0;
        int[] btnnb =new  int[26];
        public MainPage()
        {
            InitializeComponent();
            tous_visible();
            Remplire_Button();



            //EVENT 
            btn_showev();
            btn_Resev();


        }

        private void btn_showev()
        {
            
            btn1.Clicked += (sender, e) =>
            {
                btn1.IsVisible = false;
            };
            btn2.Clicked += (sender, e) =>
            {
                btn2.IsVisible = false;
            };
            btn3.Clicked += (sender, e) =>
            {
                btn3.IsVisible = false;
            };
            btn4.Clicked += (sender, e) =>
            {
                btn4.IsVisible = false;
            };
            btn5.Clicked += (sender, e) =>
            {
                btn5.IsVisible = false;
            };
            btn6.Clicked += (sender, e) =>
            {
                btn6.IsVisible = false;
            };
            btn7.Clicked += (sender, e) =>
            {
                btn7.IsVisible = false;
            };
            btn8.Clicked += (sender, e) =>
            {
                btn8.IsVisible = false;
            };
            btn9.Clicked += (sender, e) =>
            {
                btn9.IsVisible = false;
            };
            btn10.Clicked += (sender, e) =>
            {
                btn10.IsVisible = false;
            };
        }


        private void btn_Resev()
        {
            btn11.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn12.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn13.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn14.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn15.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn16.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn17.Clicked += (sender, e) => {
                calculecmpt();
            };

            btn18.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn19.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn20.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn21.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn22.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn23.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn24.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn25.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn26.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn27.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn28.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn29.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn30.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn31.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn32.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn33.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn34.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn35.Clicked += (sender, e) => {
                calculecmpt();
            };
            btn36.Clicked += (sender, e) => {
                calculecmpt();
            };
        }

        public void calculecmpt()
        {
            ct++;
            if (ct == 1)
            {
                btn1.IsVisible = true;
            }
            if (ct == 2)
            {
                btn2.IsVisible = true;
            }
            if (ct == 3)
            {
                btn3.IsVisible = true;
            }
            if (ct == 4)
            {
                btn4.IsVisible = true;
            }
            if (ct == 5)
            {
                btn5.IsVisible = true;
            }
            if (ct == 6)
            {
                btn6.IsVisible = true;
            }
            if (ct == 7)
            {
                btn7.IsVisible = true;
            }
            if (ct == 8)
            {
                btn8.IsVisible = true;
            }
            if (ct == 9)
            {
                btn9.IsVisible = true;
            }
            if (ct == 10)
            {
                btn10.IsVisible = true;
            }
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

        public void btnn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn11.IsVisible == false)
            {
                btn11.IsVisible = true;
                btn11.Text = "R";
                btn.IsVisible = false;
            }
        }
        public void tous_visible()
        {
            btn1.IsVisible = false;
            btn2.IsVisible = false;
            btn3.IsVisible = false;
            btn4.IsVisible = false;
            btn5.IsVisible = false;
            btn6.IsVisible = false;
            btn7.IsVisible = false;
            btn8.IsVisible = false;
            btn9.IsVisible = false;
            btn10.IsVisible = false;
        }

    }
}
