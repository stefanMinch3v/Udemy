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
    public partial class ImageExercise : ContentPage
    {
        private int imageId = 1;
        private UriImageSource uriImgSource;

        public ImageExercise()
        {
            InitializeComponent();
            this.InitializeImgSource();

            this.LoadImage();
        }

        public void LoadImage()
        {
            this.uriImgSource.Uri = new Uri($"http://lorempixel.com/1920/1080/city/{this.imageId}");
            this.img.Source = this.uriImgSource;
        }

        private void InitializeImgSource()
        {
            this.uriImgSource = new UriImageSource
            {
                CachingEnabled = false
            };
        }

        private void Button_Clicked_Next(object sender, EventArgs e)
        {
            this.imageId++;

            if (this.imageId > 10)
            {
                this.imageId = 1;
            }

            this.LoadImage();
        }

        private void Button_Clicked_Prev(object sender, EventArgs e)
        {
            this.imageId--;

            if (this.imageId <= 0)
            {
                this.imageId = 10;
            }

            this.LoadImage();
        }
    }
}