using System.Collections.Generic;

namespace RatingMarker.Crawler.Models
{
	public class Person
	{
		public int PersonId { get; set; }
		public string Name { get; set; }
	    public virtual ICollection<PersonPageRank> PersonPageRanks { get; set; }
	    public virtual ICollection<Keyword> Keywords { get; set; }
	}
}