using school_management_wpf_project.ViewModels;
using System.Windows;

namespace school_management_wpf_project {
	public partial class MainWindow : Window {
		public MainWindow() {
			InitializeComponent();
			DataContext = new MainViewModel();
		}
	}
}
