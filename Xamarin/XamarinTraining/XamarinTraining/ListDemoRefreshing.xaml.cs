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
	public partial class ListDemoRefreshing : ContentPage
	{
		public ListDemoRefreshing ()
		{
			InitializeComponent ();

            this.listView.ItemsSource = this.GetContacts();
        }

        private void ListView_Refreshing(object sender, EventArgs e)
        {
            // usually we call remote service to refresh the list 
            this.listView.ItemsSource = this.GetContacts();

            // 2 ways to stop the lifelong refreshing
            //this.listView.IsRefreshing = false;
            this.listView.EndRefresh();
        }

        private List<Contact> GetContacts()
        {
            return new List<Contact>
            {
                new Contact { Name = "Pesho", Status = "Hi", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                new Contact { Name = "Gosho", Status = "Hayo", ImageUrl = "http://lorempixel.com/100/100/people/2" }
            };
        }
    }
}