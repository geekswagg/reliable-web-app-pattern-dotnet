using ForgeFusion.Web.Models.Search;

namespace ForgeFusion.Web.Models.Services
{
    public interface IConcertSearchService
    {
        Task<SearchResponse<ConcertSearchResult>> SearchAsync(SearchRequest request);
        Task<ICollection<string>> SuggestAsync(string query);
    }
}
