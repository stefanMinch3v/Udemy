using System.Collections.Generic;

namespace XamarinTraining.Models
{
    public class ContactGroup : List<Contact>
    {
        public ContactGroup(string title, string shortTitle)
        {
            this.Title = title;
            this.ShortTitle = shortTitle;
        }

        public string Title { get; set; }

        public string ShortTitle { get; set; }
    }
}
