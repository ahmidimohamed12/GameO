using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App5.Views;

namespace App5
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        string txtresult;
        char[] p = new char[10];
        int check1, check2, check3;
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

            btnvide.Clicked += (sender, e) =>
            {
                tous_visible();
            };
        }
  
        private void btn_showev()
        {
            
            btn1.Clicked += (sender, e) =>
            {
                btn1.IsVisible = false;
                ct = 0;
            };
            btn2.Clicked += (sender, e) =>
            {
                btn2.IsVisible = false;
                ct = 1;
            };
            btn3.Clicked += (sender, e) =>
            {
                btn3.IsVisible = false;
                ct = 2;
            };
            btn4.Clicked += (sender, e) =>
            {
                btn4.IsVisible = false;
                ct = 3;
            };
            btn5.Clicked += (sender, e) =>
            {
                btn5.IsVisible = false;
                ct = 4;
            };
            btn6.Clicked += (sender, e) =>
            {
                btn6.IsVisible = false;
                ct = 5;
            };
            btn7.Clicked += (sender, e) =>
            {
                btn7.IsVisible = false;
                ct = 6;
            };
            btn8.Clicked += (sender, e) =>
            {
                btn8.IsVisible = false;
                ct = 7;
            };
            btn9.Clicked += (sender, e) =>
            {
                btn9.IsVisible = false;
                ct = 8;
            };
            btn10.Clicked += (sender, e) =>
            {
                btn10.IsVisible = false;
                ct = 9;
            };
        }


        private void btn_Resev()
        {
            btn11.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);

            };
            btn12.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn13.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn14.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn15.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn16.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn17.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };

            btn18.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn19.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn20.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn21.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn22.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn23.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn24.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn25.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn26.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn27.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn28.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn29.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn30.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn31.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn32.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn33.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn34.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn35.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
            btn36.Clicked += (sender, e) => {
                Button btn = (Button)sender;
                calculecmpt(btn.Text);
            };
        }

        public void calculecmpt(string txt)
        {
            string op;
            ct++;
            if (ct == 1)
            {
                btn1.IsVisible = true;
                btn1.Text = txt;
            }
            if (ct == 2)
            {
                btn2.IsVisible = true;
                btn2.Text = txt;

            }
            if (ct == 3)
            {
                btn3.IsVisible = true;
                btn3.Text = txt;
            }
            if (ct == 4)
            {
                btn4.IsVisible = true;
                btn4.Text = txt;
            }
            if (ct == 5)
            {
                btn5.IsVisible = true;
                btn5.Text = txt;
            }
            if (ct == 6)
            {
                btn6.IsVisible = true;
                btn6.Text = txt;
            }
            if (ct == 7)
            {
                btn7.IsVisible = true;
                btn7.Text = txt;
            }
            if (ct == 8)
            {
                btn8.IsVisible = true;
                btn8.Text = txt;

            }
            if (ct == 9)
            {
                btn9.IsVisible = true;
                btn9.Text = txt;
                
            }
            if (ct == 10)
            {
                btn10.IsVisible = true;
                btn10.Text = txt;
                op = " ";
                op = btn1.Text + btn2.Text + btn3.Text + btn4.Text + btn5.Text + btn6.Text + btn7.Text + btn8.Text + btn9.Text + btn10.Text;
                if (op == "REALMADRID")
                {
                    Navigation.PushModalAsync(new Page1());
                }
            }
        }
      
        public   void Remplire_Button()
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

       
        public void tous_visible()
        {
            ct = 0;
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