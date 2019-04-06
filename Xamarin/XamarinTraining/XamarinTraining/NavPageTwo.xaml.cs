using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTraining
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NavPageTwo : ContentPage
	{
		public NavPageTwo ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            // await Navigation.PopModalAsync(); pop modal async method
        }

        // optional disable the back button
        //protected override bool OnBackButtonPressed()
        //{
        //    return true;
        //}
    }
}