﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App5.Views;

namespace App5
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Star_page();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
