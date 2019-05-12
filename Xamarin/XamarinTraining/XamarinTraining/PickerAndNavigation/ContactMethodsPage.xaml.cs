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
	public partial class ContactMethodsPage : ContentPage
	{
		public ContactMethodsPage ()
		{
			InitializeComponent ();

            this.listView.ItemsSource = new List<string>
            {
                "None",
                "Email",
                "SMS"
            };
        }

        public ListView ContactMethods => this.listView;
    }
}