﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TP02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheView : ContentPage
    {
    
        public DetalheView()
        {
            InitializeComponent();
            
        }

        private async void Home(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new Home());

        }


    }
}