using System;
using XamarinTraining.ContactBook;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTraining.InstagramApp;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinTraining
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ContactsPage());

            //MainPage = new NavigationPage(new PickerAndNavigation.MainPage());

            // MainPage = new NavigationPage(new InstagramAppExercise());

            //MainPage = new NavigationPage(new ToolbarItemsDemo());

            //MainPage = new NavigationPage(new MasterPage())
            //{
            //    BarBackgroundColor = Color.PaleVioletRed
            //};

            //MainPage = new NavigationPage(new NavPageOne())
            //{
            //    BarBackgroundColor = Color.PaleVioletRed
            //};
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
