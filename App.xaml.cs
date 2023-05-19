using school_management_wpf_project.Data;
using school_management_wpf_project.ViewModels;
using System.Windows;

namespace school_management_wpf_project {
	public partial class App : Application {
		public SchoolDbContext SchoolDbContext => (SchoolDbContext)Resources["SchoolDbContext"];
		public MainViewModel MainViewModel => new MainViewModel(SchoolDbContext);
	}
}
