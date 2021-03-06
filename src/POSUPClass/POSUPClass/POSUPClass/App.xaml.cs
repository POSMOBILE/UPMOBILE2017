﻿using POSUPClass;
using POSUPClass.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace POSUPClass
{
    public partial class App : Application
    {
        public App()
        {
             MainPage = new NavigationPage(new POSUPClass.MainPage())
            //MainPage = new NavigationPage(new POSUPClass.Settings())
            {
                BarBackgroundColor = Color.Salmon
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            SubcategoriaFactory.Initialize();
            CursoSubcategoriaFactory.Initialize();
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
