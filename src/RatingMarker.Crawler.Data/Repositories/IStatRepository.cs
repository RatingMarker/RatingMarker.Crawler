using System;
using System.Collections.Generic;
using RatingMarker.Crawler.Models;

namespace RatingMarker.Crawler.Data.Repositories
{
    public interface IStatRepository
    {
        IEnumerable<PersonPageRank> GetPageRanksBySite(int siteId);
        IEnumerable<PersonPageRank> GetPageRanksByRangeDate(int siteId, DateTime beginDate, DateTime endDate);
    }
}