using school_management_wpf_project.DataAccessLayer;
using school_management_wpf_project.Models;
using System.Collections.Generic;

namespace school_management_wpf_project.BusinessLogicLayer {
	public static class StudentBLL {
		public static void AddStudent(Student student) {
			StudentDAL.AddStudent(student);
		}

		public static void UpdateStudent(Student student) {
			StudentDAL.UpdateStudent(student);
		}

		public static void RemoveStudent(Student student) {
			StudentDAL.RemoveStudent(student);
		}

		public static List<Student> GetStudents() {
			return StudentDAL.GetStudents();
		}

		public static Student GetStudentById(int id) {
			return StudentDAL.GetStudentById(id);
		}
	}
}
