
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTraining.Services;

namespace XamarinTraining.InstagramApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserProfile : ContentPage
	{
        private IUsersService usersService;

		public UserProfile (int userId)
		{
			InitializeComponent ();

            this.usersService = new UsersService();

            var user = this.usersService.Single(userId);

            this.BindingContext = user;
		}
    }
}