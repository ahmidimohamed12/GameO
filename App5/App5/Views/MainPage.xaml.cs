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
        public MainPage()
        {
            InitializeComponent();
            tous_visible();
            Remplire_Button();

            //EVENT 
            btn11.Clicked += btn11_click;
            btn12.Clicked += btn12_click;
            btn13.Clicked += btn13_click;
            btn14.Clicked += btn14_click;
            btn15.Clicked += btn15_click;
        }

        public void Remplire_Button()
        {
            btn11.Text = "R";
            btn12.Text = "C";
            btn13.Text = "E";
            btn14.Text = "L";
            btn15.Text = "A";
            btn16.Text = "R";
            btn19.Text = "W";
            btn20.Text = "I";
            btn21.Text = "D";
            btn22.Text = "M";
            btn23.Text = "C";
            btn24.Text = "V";
            btn25.Text = "A";
            btn26.Text = "D";
            btn27.Text = "I";
            btn28.Text = "O";
            btn29.Text = "R";
            btn30.Text = "D";
        }

        public void btn11_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn1.IsVisible == false && btn2.IsVisible == false && btn3.IsVisible == false && btn4.IsVisible == false && btn5.IsVisible == false)
            {
                btn.IsVisible = false;
                btn1.Text = btn.Text;
                btn1.IsVisible = true;
                n1 = 1;
            }
           
            if (btn1.IsVisible && btn2.IsVisible && btn3.IsVisible && btn4.IsVisible && btn5.IsVisible && btn6.IsVisible && btn7.IsVisible && btn8.IsVisible && btn9.IsVisible && btn10.IsVisible)
            {
                btn10.Text = btn.Text;
            }
        }
        public void btn12_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn1.IsVisible == false && btn2.IsVisible == false && btn3.IsVisible == false && btn4.IsVisible == false && btn5.IsVisible == false)
            {
                btn.IsVisible = false;
                btn1.Text = btn.Text;
                btn1.IsVisible = true;
                n2 = 1;
            }
        }

        public void btn13_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn1.IsVisible == false && btn2.IsVisible == false && btn3.IsVisible == false && btn4.IsVisible == false && btn5.IsVisible == false)
            {
                btn.IsVisible = false;
                btn1.Text = btn.Text;
                btn1.IsVisible = true;
                n2 = 1;
            }
        }
        public void btn14_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn1.IsVisible == false && btn2.IsVisible == false && btn3.IsVisible == false && btn4.IsVisible == false && btn5.IsVisible == false)
            {
                btn.IsVisible = false;
                btn1.Text = btn.Text;
                btn1.IsVisible = true;
                n2 = 1;
            }
        }

        public void btn15_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn1.IsVisible == false && btn2.IsVisible == false && btn3.IsVisible == false && btn4.IsVisible == false && btn5.IsVisible == false)
            {
                btn.IsVisible = false;
                btn1.Text = btn.Text;
                btn1.IsVisible = true;
                n2 = 1;
            }
        }
        //public void btn12_click(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    if (btn1.IsVisible == false)
        //    {
        //        btn.IsVisible = false;
        //        btn1.Text = btn.Text;
        //        btn1.IsVisible = true;
        //    }

        //}

        //public void btn13_click(object sender, EventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    if (btn1.IsVisible == false)
        //    {
        //        btn.IsVisible = false;
        //        btn1.Text = btn.Text;
        //        btn1.IsVisible = true;

        //    }
        //}


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
