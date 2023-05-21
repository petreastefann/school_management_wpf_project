using school_management_wpf_project.Views.StudentMiniViews;
using System.Windows;
using System.Windows.Controls;

namespace school_management_wpf_project.Views {
	/// <summary>
	/// Interaction logic for StudentView.xaml
	/// </summary>
	public partial class StudentView : UserControl {
		public StudentView() {
			InitializeComponent();
		}

		private void StudentSeeAverages(object sender, RoutedEventArgs e) {
			StudentViewAllAverages studentViewAllAverages = new StudentViewAllAverages();
			studentViewAllAverages.DataContext = this.DataContext;
			studentViewAllAverages.Show();
		}

		private void StudentSeeAbsences(object sender, RoutedEventArgs e) {
			StudentViewAllAbsences studentViewAllAbsences = new StudentViewAllAbsences();
			studentViewAllAbsences.DataContext = this.DataContext;
			studentViewAllAbsences.Show();
		}

		private void StudentSeeGrades(object sender, RoutedEventArgs e) {
			StudentViewAllGrades studentViewAllGrades = new StudentViewAllGrades();
			studentViewAllGrades.DataContext = this.DataContext;
			studentViewAllGrades.Show();
		}

		private void StudentSeeTeachingMaterial(object sender, RoutedEventArgs e) {
			StudentViewAllMaterial studentViewAllMaterial = new StudentViewAllMaterial();
			studentViewAllMaterial.DataContext = this.DataContext;
			studentViewAllMaterial.Show();
		}
	}
}
