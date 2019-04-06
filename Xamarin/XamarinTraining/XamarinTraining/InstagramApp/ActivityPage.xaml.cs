
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTraining.Models;
using XamarinTraining.Services;

namespace XamarinTraining.InstagramApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ActivityPage : ContentPage
	{
        private IActivityService activityService;

        public ActivityPage ()
		{
			InitializeComponent ();
            
            this.activityService = new ActivityService();

            this.myListView.ItemsSource = this.activityService.GetActivities();
        }

        private async void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            var activity = e.SelectedItem as Activity;

            this.myListView.SelectedItem = null;

            await Navigation.PushAsync(new UserProfile(activity.UserId));
        }
    }
}