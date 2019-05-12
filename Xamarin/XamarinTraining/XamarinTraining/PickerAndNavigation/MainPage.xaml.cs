using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTraining.PickerAndNavigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        private async void ViewCell_Tapped(object sender, EventArgs e)
        {
            var page = new ContactMethodsPage();
            page.ContactMethods.ItemSelected += async (source, args) =>
            {
                this.contactMethod.Text = args.SelectedItem.ToString();
                await Navigation.PopAsync();
            };

            await Navigation.PushAsync(page);
        }
    }
}