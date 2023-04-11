using SNewsLoader;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace NewsFeedWPF1.ViewModels
{
	class MainWindowViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] string prop = "")
		=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

		private News[] newsArray;
		public News[] News
		{
			get
			{
				return newsArray;
			}
			set
			{
				newsArray = value;
				OnPropertyChanged();
			}
		}


		public ICommand Reload
		{
			get => new DelegateCommand((obj) =>
			{
				News = NewsGetter.GetAllNews();
			});
		}
	}
}
