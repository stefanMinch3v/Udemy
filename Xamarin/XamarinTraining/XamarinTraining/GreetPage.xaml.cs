using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTraining
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GreetPage : ContentPage
	{
		public GreetPage()
        {
            // initialize component must be always first
            InitializeComponent();

            slider.Value = 0.5;

            //switch (Device.RuntimePlatform)
            //{
            //    case "iOS":
            //        this.Padding = new Thickness(0, 20, 0, 0);
            //        break;
            //    case "Android":
            //        this.Padding = new Thickness(10, 20, 0, 0);
            //        break;
            //    case "WinPhone":
            //        this.Padding = new Thickness(30, 20, 0, 0);
            //        break;
            //    default:
            //        break;
            //};
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    this.DisplayAlert("Title", "Hello World", "OK");
        //}

        //private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    this.labelText.Text = string.Format("Value is {0:F2}", e.NewValue);
        //}
	}
}