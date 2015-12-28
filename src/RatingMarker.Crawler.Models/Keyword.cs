namespace RatingMarker.Crawler.Models
{
	public class Keyword
	{
		public int KeywordId { get; set; }
		public string Name { get; set; }
	    public int PersonId { get; set; }
		public virtual Person Person { get; set; }
	}
}