using Microsoft.EntityFrameworkCore;
using school_management_wpf_project.Data;
using school_management_wpf_project.Models;
using System.Collections.Generic;
using System.Linq;

namespace school_management_wpf_project.DataAccessLayer {
	class CourseDAL {
		private static SchoolDbContext _db = new SchoolDbContext();

		public static void Add(Course course) {
			var homeroomTeacher = _db.Users.FirstOrDefault(u => u.Id == course.HomeroomTeacher.Id);
			if(homeroomTeacher != null) {
				course.HomeroomTeacher = homeroomTeacher;
			}

			_db.Add(course);
			_db.SaveChanges();
		}

		public static List<Course> GetAll() {
			if(_db.Courses.Count() <= 0)
				return new List<Course>();
			return _db.Courses.Include(c => c.HomeroomTeacher).ToList();
		}
	}
}
