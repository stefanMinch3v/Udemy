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
	public partial class MasterPage : ContentPage
	{
		public MasterPage ()
		{
			InitializeComponent ();

            this.listView.ItemsSource = this.GetContactsData();
		}

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            var contact = e.SelectedItem as Contact;

            await this.Navigation.PushAsync(new MasterDetailPage(contact));

            this.listView.SelectedItem = null;
        }

        private List<Contact> GetContactsData()
            => new List<Contact>
                {
                    new Contact { Name = "Gosho", ImageUrl = "http://lorempixel.com/100/100/people/1", Status = "Hi"},
                    new Contact { Name = "Pesho", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey"},
                };
    }
}