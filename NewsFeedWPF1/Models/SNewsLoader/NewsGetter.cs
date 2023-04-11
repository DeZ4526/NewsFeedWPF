using SNewsLoader.Informator;

namespace SNewsLoader
{
	static class NewsGetter
	{
		private static INewsInformator informator = new MySQLNewsInformator("127.0.0.1", "ProjectKw", "root", "");
		public static News[] GetLastNews(int num)
			=> informator.GetLastNews(num);
		public static News[] GetAllNews()
			=> informator.GetAllNews();
	}
}
