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
            btn11.Clicked += (sender,e) => {
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
            };
            btn12.Clicked += (sender,e) => {
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
            };
            btn13.Clicked += (sender,e) => {
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
            };
            btn14.Clicked += (sender,e) => {
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
            };
            btn15.Clicked += (sender,e) => {
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
            };
            btn16.Clicked += (sender,e) => {
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
            };
            btn17.Clicked += (sender,e) => {
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
            };


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

        public void btn11_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn1.IsVisible == true)
            if (btn1.IsVisible && btn2.IsVisible && btn3.IsVisible)
            {
                btnnb[0] = 1;
                btnnb[1] = 1;

            }
        }
        public void btn12_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if ( btn1.IsVisible == false && btn2.IsVisible == false && btn3.IsVisible == false && btn4.IsVisible == false && btn5.IsVisible == false)
            {
                if (n2 == 1)
                {
                    btn1.Text = btn.Text;
                    btn1.IsVisible = true;
                    n2 = 1;
                }
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


        public void check1(Button b)
        {
            if (n1 == 1)
            {
                btn1.Text = b.Text;
                btn1.IsVisible = true;
                n1 = 1;
                n2 = 0;
                n3 = 0;
                n4 = 0;
            }
        }

        public void check2(Button b)
        {
            if (n2 == 0)
            {
                btn2.Text = b.Text;
                btn2.IsVisible = true;
                n2 = 1;
            }
        }

        public void check3(Button b)
        {
            if (n3 == 0)
            {
                btn3.Text = b.Text;
                btn3.IsVisible = true;
                n3 = 1;
            }
        }

        public void check4(Button b)
        {
            if (n4 == 0)
            {
                btn4.Text = b.Text;
                btn4.IsVisible = true;
                n4 = 1;
            }
        }
    }
}
