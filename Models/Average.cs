﻿namespace school_management_wpf_project.Models {
	public class Average {
		public int Id {
			get; set;
		}
		public User Student {
			get; set;
		}
		public Course Course {
			get; set;
		}
		public int Grade {
			get; set;
		}
	}
}
