using System.Collections.Generic;

namespace RatingMarker.Crawler.Workflow.Parsers
{
    public interface IParser
    {
        IEnumerable<string> GetUrls(string content);
    }
}