using school_management_wpf_project.Data;
using school_management_wpf_project.Models;

namespace school_management_wpf_project.DataAccessLayer {
	class CourseDAL {
		private static SchoolDbContext _db = new SchoolDbContext();

		public static void Add(Course course) {
			_db.Add(course);
			_db.SaveChanges();
		}
		/*public static List<Course> GetAll() {
			if(_db.Courses.Count() <= 0)
				return new List<Course>();
			return _db.Courses.Include(c => c.User).ToList();
		}*/
	}
}
