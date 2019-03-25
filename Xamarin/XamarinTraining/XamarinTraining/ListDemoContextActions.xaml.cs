using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTraining.Models;

namespace XamarinTraining
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListDemoContextActions : ContentPage
	{
        private ObservableCollection<ContactGroupObservable> contactGroups;

        public ListDemoContextActions()
        {
            InitializeComponent();

            this.InitializeCollections();

            this.listView.ItemsSource = this.contactGroups;
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "Ok");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;

            foreach (var group in this.contactGroups)
            {
                var removeContact = group.FirstOrDefault(g => g.Name == contact.Name);
                group.Remove(removeContact);
            }
        }

        private void InitializeCollections()
        {
            this.contactGroups = new ObservableCollection<ContactGroupObservable>
            {
                new ContactGroupObservable("P", "P")
                {
                    new Contact { Name = "Pesho", Status = "Hi", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                    new Contact { Name = "Petra", Status = "Hi guys", ImageUrl = "http://lorempixel.com/100/100/people/3" }
                },
                new ContactGroupObservable("G", "G")
                {
                    new Contact { Name = "Gosho", Status = "Hayo", ImageUrl = "http://lorempixel.com/100/100/people/2" },
                    new Contact { Name = "Gergana", Status = "Where are u", ImageUrl = "http://lorempixel.com/100/100/people/4" }
                }
            };
        }
    }
}