using System;
using System.Collections.Generic;
using RatingMarker.Crawler.Data.Infrastructure;
using RatingMarker.Crawler.Models;

namespace RatingMarker.Crawler.Data.Repositories
{
    public interface IPageRepository: IRepository<Page>
    {
        IEnumerable<Page> GetMany(Func<Page, bool> where);
        int Insert(IEnumerable<Page> entities);
        IEnumerable<Page> GetManyIncludeSite(Func<Page, bool> where);
    }
}