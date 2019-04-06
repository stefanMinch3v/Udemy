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
	public partial class PopupsDemo : ContentPage
	{
		public PopupsDemo ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var response = await DisplayAlert("Warning", "Are u sure?", "Yes", "No");

            if (response)
            {
                await DisplayAlert("Job done", "Your data will be saved!", "Ok");
            }
        }

        private async void Button_Clicked_ActionSheet(object sender, EventArgs e)
        {
            var buttons = new string[] { "Copy Link", "Message", "Email" };
            var response = await DisplayActionSheet("Title", "Cancel", "Delete", buttons);

            await DisplayAlert("Response", response, "Ok");
        }
    }
}