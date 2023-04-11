using System;

namespace SNewsLoader
{
	class News
	{
		public News(string title, string description, string longDescription, string imageURL, DateTime date)
		{
			Title = title;
			Description = description;
			LongDescription = longDescription;
			ImageURL = imageURL;
			Date = date;
		}

		public string Title { get; set; }
		public string Description { get; set; }
		public string LongDescription { get; set; }
		public string ImageURL { get; set; }
		public DateTime Date { get; set; }


	}
}
