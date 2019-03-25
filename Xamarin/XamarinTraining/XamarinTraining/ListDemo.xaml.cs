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
    public partial class ListDemo : ContentPage
    {
        public ListDemo()
        {
            InitializeComponent();

            this.listView.ItemsSource = new List<Contact>
            {
                new Contact { Name = "Pesho", Status = "Hi", ImageUrl = "http://lorempixel.com/100/100/people/1" },
                new Contact { Name = "Gosho", Status = "Hayo", ImageUrl = "http://lorempixel.com/100/100/people/2" }
            };
        }
    }
}