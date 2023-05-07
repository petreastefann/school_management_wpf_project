﻿using System.Collections.ObjectModel;

namespace school_management_wpf_project.Models {
	public class Classroom {
		public int Id {
			get; set;
		}
		public string Name {
			get; set;
		}
		public ObservableCollection<Student> Students {
			get; set;
		}
		public ObservableCollection<Teacher> Teachers {
			get; set;
		}

		public Classroom(int id, string name, ObservableCollection<Student> students, ObservableCollection<Teacher> teachers) {
			Id = id;
			Name = name;
			Students = students;
			Teachers = teachers;
		}
	}
}