using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTraining.MarkupExtensions
{
    [ContentProperty(nameof(ResourceId))]
    public class EmbeddedImage : IMarkupExtension
    {
        public string ResourceId { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(this.ResourceId))
            {
                return null;
            }

            return ImageSource.FromResource(this.ResourceId);
        }
    }
}