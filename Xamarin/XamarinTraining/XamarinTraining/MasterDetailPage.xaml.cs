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
	public partial class MasterDetailPage : ContentPage
	{
		public MasterDetailPage (Contact contact)
		{
            this.BindingContext = contact ?? throw new ArgumentNullException(nameof(contact));

			InitializeComponent ();
		}
	}
}