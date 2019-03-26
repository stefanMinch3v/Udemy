using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTraining.Models;
using XamarinTraining.Services;

namespace XamarinTraining
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchExercise : ContentPage
    {
        private ISearchService searchService;

        public SearchExercise()
        {
            InitializeComponent();

            this.searchService = new SearchService();

            this.myListView.ItemsSource = this.GetSearchGroup();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var search = e.NewTextValue;
            this.myListView.ItemsSource = this.GetSearchGroup(search);
        }

        private void MenuItem_Delete(object sender, EventArgs e)
        {
            var search = (sender as MenuItem).CommandParameter as Search;
            this.searchService.DeleteSearch(search.Id);
        }

        private ObservableCollection<SearchGroup> GetSearchGroup(string searchText = null)
        {
            var searchGroup = new SearchGroup("Recent Searches");
            searchGroup.AddRange(this.searchService.GetSearches(searchText));

            return new ObservableCollection<SearchGroup> { searchGroup };
        }

        private void MyListView_Refreshing(object sender, EventArgs e)
        {
            this.myListView.ItemsSource = this.GetSearchGroup();

            this.myListView.EndRefresh();
        }

        private void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var search = e.SelectedItem as Search;
            DisplayAlert("Location", search.Location, "Ok");
        }
    }
}