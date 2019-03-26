using System.Collections.Generic;
using XamarinTraining.Models;

namespace XamarinTraining.Services
{
    public interface ISearchService
    {
        IEnumerable<Search> GetSearches(string searchText = null);

        void DeleteSearch(int id);
    }
}
