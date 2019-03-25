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
	public partial class ListSearchDemo : ContentPage
	{
		public ListSearchDemo ()
		{
			InitializeComponent ();

            this.listView.ItemsSource = this.GetContacts();
        }

        private List<Contact> GetContacts(string searchText = null)
        {
            var contacts = new List<Contact>
            {
                new Contact { Name = "Pesho", Status = "Hi", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                new Contact { Name = "Gosho", Status = "Hayo", ImageUrl = "http://lorempixel.com/100/100/people/2" }
            };

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                contacts = contacts
                    .Where(c => c.Name.ToLower().StartsWith(searchText.ToLower()))
                    .ToList();
            }

            return contacts;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.listView.ItemsSource = this.GetContacts(e.NewTextValue);
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            this.listView.ItemsSource = this.GetContacts(e.ToString());
        }
    }
}