﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnalisisT
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Nokia : ContentPage
    {
        public Nokia()
        {
            InitializeComponent();
        }
        private void Volver(Object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new MainTabbed());
        }
    }
}