﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTraining
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ToolbarItemsDemo : ContentPage
	{
		public ToolbarItemsDemo ()
		{
			InitializeComponent ();
		}

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            DisplayAlert("Activated", "ToolbarItem activated", "Ok");
        }
    }
}