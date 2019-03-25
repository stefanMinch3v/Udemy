using System.Collections.ObjectModel;

namespace XamarinTraining.Models
{
    public class ContactGroupObservable : ObservableCollection<Contact>
    {
        public ContactGroupObservable(string title, string shortTitle)
        {
            this.Title = title;
            this.ShortTitle = shortTitle;
        }

        public string Title { get; set; }

        public string ShortTitle { get; set; }
    }
}
