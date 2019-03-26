using System.Collections.Generic;

namespace XamarinTraining.Models
{
    public class SearchGroup : List<Search>
    {
        public SearchGroup(string title)
        {
            this.Title = title;
        }

        public string Title { get; set; }
    }
}
