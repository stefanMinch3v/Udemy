using System;
using System.Collections.Generic;
using System.Linq;
using XamarinTraining.Models;

namespace XamarinTraining.Services
{
    public class SearchService : ISearchService
    {
        private readonly IList<Search> searches;

        public SearchService()
        {
            this.searches = new List<Search>
            {
                new Search { Id = 1, Location = "Denmark, Aalborg 44", CheckIn = DateTime.Now, CheckOut = DateTime.Now.AddDays(10) },
                new Search { Id = 2, Location = "Bulgaria, Burgas 54", CheckIn = DateTime.Now.AddDays(-3), CheckOut = DateTime.Now.AddDays(110) },
                new Search { Id = 3, Location = "Denmark, Aarhus 781", CheckIn = DateTime.Now.AddDays(-1), CheckOut = DateTime.Now.AddDays(5) },
                new Search { Id = 4, Location = "Denmark, Copenhagen 90", CheckIn = DateTime.Now.AddDays(-2), CheckOut = DateTime.Now.AddDays(7) }
            };
        }

        public void DeleteSearch(int id)
        {
            var search = this.searches.FirstOrDefault(s => s.Id == id);

            if (search != null)
            {
                this.searches.Remove(search);
            }
        }

        public IEnumerable<Search> GetSearches(string searchText = null)
        {
            if (searchText != null)
            {
                return this.searches
                    .Where(s => s.Location.ToLower().Contains(searchText.ToLower()));
            }

            return this.searches;
        }
    }
}
