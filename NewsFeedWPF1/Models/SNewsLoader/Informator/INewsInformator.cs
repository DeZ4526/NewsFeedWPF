namespace SNewsLoader.Informator
{
	internal interface INewsInformator
	{
		News[] GetLastNews(int num);
		News[] GetAllNews();
	}
}
