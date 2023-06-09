﻿using school_management_wpf_project.Views.AdminMiniViews;
using System.Windows;

namespace school_management_wpf_project.Views {
	public partial class AdminView : Window {
		public AdminView() {
			InitializeComponent();
		}

		private void OpenClass(object sender, RoutedEventArgs e) {
			AdminAddClass adminAddClass = new() {
				DataContext = this.DataContext
			};

			adminAddClass.Show();
		}

		private void OpenUser(object sender, RoutedEventArgs e) {
			AdminAddUsers adminAddUsers = new() {
				DataContext = this.DataContext
			};

			adminAddUsers.Show();
		}

		private void OpenStudyYear(object sender, RoutedEventArgs e) {
			AdminAddStudyYear adminAddStudyYear = new() {
				DataContext = this.DataContext
			};

			adminAddStudyYear.Show();
		}

		private void OpenCourse(object sender, RoutedEventArgs e) {
			AdminAddCourse adminAddCourse = new() {
				DataContext = this.DataContext
			};

			adminAddCourse.Show();
		}

		private void OpenSpecialization(object sender, RoutedEventArgs e) {
			AdminAddSpecialization adminAddSpecialization = new() {
				DataContext = this.DataContext
			};

			adminAddSpecialization.Show();
		}

		private void OpenStudyYearToSpecialization(object sender, RoutedEventArgs e) {
			AdminLinkStudyYearToSpecialization adminLinkStudyYearToSpecialization = new() {
				DataContext = this.DataContext
			};

			adminLinkStudyYearToSpecialization.Show();
		}

		private void OpenCourseToStudyYear(object sender, RoutedEventArgs e) {
			AdminLinkCourseToStudyYear adminLinkCourseToStudyYear = new() {
				DataContext = this.DataContext
			};

			adminLinkCourseToStudyYear.Show();
		}

		private void OpenLinkStudentToClass(object sender, RoutedEventArgs e) {
			AdminLinkStudentToClassroom adminLinkStudentToClassroom = new() {
				DataContext = this.DataContext
			};

			adminLinkStudentToClassroom.Show();
		}

	}
}
