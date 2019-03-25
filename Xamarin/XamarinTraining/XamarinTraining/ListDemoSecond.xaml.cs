using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTraining.Models;

namespace XamarinTraining
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListDemoSecond : ContentPage
	{
		public ListDemoSecond ()
		{
			InitializeComponent ();

            this.listView.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup("P", "P")
                {
                    new Contact { Name = "Pesho", Status = "Hi", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                    new Contact { Name = "Petra", Status = "Hi guys", ImageUrl = "http://lorempixel.com/100/100/people/3" }
                },
                new ContactGroup("G", "G")
                {
                    new Contact { Name = "Gosho", Status = "Hayo", ImageUrl = "http://lorempixel.com/100/100/people/2" },
                    new Contact { Name = "Gergana", Status = "Where are u", ImageUrl = "http://lorempixel.com/100/100/people/4" }
                }
            };
        }

        // tapped is every time on click
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "Ok");
        }

        // selected is once per click
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected", contact.Name, "Ok");
        }
    }
}