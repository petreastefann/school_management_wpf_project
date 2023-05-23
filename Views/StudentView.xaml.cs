using school_management_wpf_project.Views.StudentMiniViews;
using System.Windows;

namespace school_management_wpf_project.Views {
	public partial class StudentView : Window {
		public StudentView() {
			InitializeComponent();
		}

		private void StudentSeeTeachingMaterial(object sender, RoutedEventArgs e) {
			StudentViewAllMaterial studentViewAllMaterial = new() {
				DataContext = this.DataContext
			};

			studentViewAllMaterial.Show();
		}

		private void StudentSeeGrades(object sender, RoutedEventArgs e) {
			StudentViewAllGrades studentViewAllGrades = new() {
				DataContext = this.DataContext
			};

			studentViewAllGrades.Show();
		}

		private void StudentSeeAbsences(object sender, RoutedEventArgs e) {
			StudentViewAllAbsences studentViewAllAbsences = new() {
				DataContext = this.DataContext
			};

			studentViewAllAbsences.Show();
		}

		private void StudentSeeAverages(object sender, RoutedEventArgs e) {
			StudentViewAllAverages studentViewAllAverages = new() {
				DataContext = this.DataContext
			};

			studentViewAllAverages.Show();
		}
	}
}
