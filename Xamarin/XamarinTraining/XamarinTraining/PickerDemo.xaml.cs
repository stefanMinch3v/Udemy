using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace XamarinTraining
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PickerDemo : ContentPage
	{
		public PickerDemo ()
		{
			InitializeComponent ();

            this.GetContacts().ForEach(c => this.contactPicker.Items.Add(c.Name));
		}

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var name = this.contactPicker.Items[this.contactPicker.SelectedIndex];
            var id = this.GetContacts().FirstOrDefault(c => c.Name == name)?.Id;

            DisplayAlert("Contact method", $"{id}-{name}", "Ok");
        }

        private IList<ContactMethod> GetContacts()
        {
            return new List<ContactMethod>
            {
                new ContactMethod { Id = 1, Name = "SMS" },
                new ContactMethod { Id = 2, Name = "Email" },
            };
        }
    }

    public class ContactMethod
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}