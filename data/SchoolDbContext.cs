﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using school_management_wpf_project.Models;
using System.IO;

namespace school_management_wpf_project.Data {
	public class SchoolDbContext : DbContext {
		public DbSet<Attendance> Attendances {
			get; set;
		}
		public DbSet<Classroom> Classrooms {
			get; set;
		}
		public DbSet<Grade> Grades {
			get; set;
		}
		public DbSet<Specialization> Specializations {
			get; set;
		}
		public DbSet<Student> Students {
			get; set;
		}
		public DbSet<Subject> Subjects {
			get; set;
		}
		public DbSet<ClassroomTeacher> ClassroomTeachers {
			get; set;
		}
		public DbSet<HomeroomTeacher> HomeroomTeachers {
			get; set;
		}
		public DbSet<User> Users {
			get; set;
		}
		public DbSet<StudyYear> StudyYears {
			get; set;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlServer(GetConnectionString());
		}

		private static string GetConnectionString() {
			var builder = new ConfigurationBuilder()
				.SetBasePath(Directory.GetCurrentDirectory())
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

			IConfigurationRoot configuration = builder.Build();
			return configuration.GetConnectionString("SchoolDbContext")!;
		}
	}

}
