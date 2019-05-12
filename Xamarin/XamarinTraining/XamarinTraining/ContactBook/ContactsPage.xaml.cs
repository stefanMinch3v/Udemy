using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinTraining.Models;

namespace XamarinTraining.ContactBook
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        private ObservableCollection<ContactBookModel> _contacts;

        public ContactsPage()
        {
            InitializeComponent();

            _contacts = new ObservableCollection<ContactBookModel>
            {
                new ContactBookModel { Id = 1, FirstName = "John", LastName = "Smith", Email = "john@smith.com", Phone = "1111" },
                new ContactBookModel { Id = 2, FirstName = "Mary", LastName = "Johnson", Email = "mary@johnson.com", Phone = "2222" }
            };

            contacts.ItemsSource = _contacts;
        }

        async void OnAddContact(object sender, System.EventArgs e)
        {
            var page = new ContactDetailPage(new ContactBookModel());

            page.ContactAdded += (source, contact) =>
            {
                // ContactAdded event is raised when the user taps the Done button.
                // Here, we get notified and add this contact to our 
                // ObservableCollection.
                _contacts.Add(contact);
            };

            await Navigation.PushAsync(page);
        }

        async void OnContactSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // We need to check if SelectedItem is null because further below 
            // we de-select the selected item. This will raise another ItemSelected
            // event, so this method will be called straight away. If we don't
            // check for null here, we'll get a NullReferenceException.
            if (contacts.SelectedItem == null)
            {
                return;
            }

            var selectedContact = e.SelectedItem as ContactBookModel;

            // We de-select the selected item, so when we come back to the Contacts
            // page we can tap it again and navigate to ContactDetail. 
            contacts.SelectedItem = null;

            var page = new ContactDetailPage(selectedContact);
            page.ContactUpdated += (source, contact) =>
            {
                // When the target page raises ContactUpdated event, we get 
                // notified and update properties of the selected contact. 
                // Here we are dealing with a small class with only a few 
                // properties.

                selectedContact.Id = contact.Id;
                selectedContact.FirstName = contact.FirstName;
                selectedContact.LastName = contact.LastName;
                selectedContact.Phone = contact.Phone;
                selectedContact.Email = contact.Email;
                selectedContact.IsBlocked = contact.IsBlocked;
            };

            await Navigation.PushAsync(page);
        }

        async void OnDeleteContact(object sender, System.EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as ContactBookModel;

            if (await DisplayAlert("Warning", $"Are you sure you want to delete {contact.FullName}?", "Yes", "No"))
            {
                _contacts.Remove(contact);
            }
        }
    }
}