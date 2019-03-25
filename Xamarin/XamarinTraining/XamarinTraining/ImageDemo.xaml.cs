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
	public partial class ImageDemo : ContentPage
	{
        public ImageDemo()
        {
            InitializeComponent();

            var imgSource = new UriImageSource { Uri = new Uri("https://i.ytimg.com/vi/9h_QtLol75I/maxresdefault.jpg") };
            imgSource.CachingEnabled = false;
            //imgSource.CacheValidity = TimeSpan.FromHours(1); if we enable caching

            //image.Source = imgSource;

            // embedded image
            // and in xaml erase absolute layout instead add just Image
            // image.Source = ImageSource.FromResource("HelloWorld.Images.pgr.jpg");

            // images for iOS are in folder resources image.png, image@2x.png, image@3x.png and so on
            // images for android are in folder resources/drawable as follow image.png, drawable-hdpi goes bigger image and so on
            // for win phones create folder images and fill it out with them
        }
    }
}