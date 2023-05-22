using school_management_wpf_project.Data;
using school_management_wpf_project.Models;
using System.Collections.Generic;
using System.Linq;

namespace school_management_wpf_project.DataAccessLayer {
	public static class StudentDAL {
		private static SchoolDbContext _db = new SchoolDbContext();

		public static void AddStudent(Student student) {
			student.Id = 0;
			_db.Students.Add(student);
			_db.SaveChanges();
		}

		public static void UpdateStudent(Student student) {
			_db.Students.Update(student);
			_db.SaveChanges();
		}

		public static void RemoveStudent(Student student) {
			_db.Students.Remove(student);
			_db.SaveChanges();
		}

		public static List<Student> GetStudents() {
			return _db.Students.ToList();
		}

		public static Student GetStudentById(int id) {
			return _db.Students.FirstOrDefault(s => s.Id == id);
		}
	}
}
