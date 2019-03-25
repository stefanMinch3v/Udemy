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
    public partial class QuotesPage : ContentPage
    {
        private readonly string[] readData = new string[]
        {
            "Ivan is here",
            "Gosho was here",
            "Mitko hasn't been here yet",
            "Petio just left"
        };
        private int currentIndex = -1;

        public QuotesPage()
        {
            InitializeComponent();

            this.slider.Value = 16;
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            this.currentIndex++;
            if (currentIndex >= readData.Length)
            {
                currentIndex = 0;
            }

            this.currentText.Text = this.readData[currentIndex];
        }
    }
}