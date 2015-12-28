using System.Collections.Generic;
using RatingMarker.Crawler.Models;

namespace RatingMarker.Crawler.Data.Repositories
{
    public interface IPersonPageRankRepository
    {
        int Insert(IEnumerable<PersonPageRank> entities);
    }
}