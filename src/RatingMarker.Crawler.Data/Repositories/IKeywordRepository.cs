using System;
using System.Collections.Generic;
using RatingMarker.Crawler.Data.Infrastructure;
using RatingMarker.Crawler.Models;

namespace RatingMarker.Crawler.Data.Repositories
{
    public interface IKeywordRepository: IRepository<Keyword>
    {
        IEnumerable<Keyword> GetMany(Func<Keyword,bool> where);
    }
}