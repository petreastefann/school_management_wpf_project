namespace school_management_wpf_project.Data {
	public class SchoolDbContext : DbContext {
		public DbSet<User> Users {
			get; set;
		}
		// Add more DbSet properties for each model class you want to use in the database

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			optionsBuilder.UseSqlServer("Your connection string here"); // Replace "Your connection string here" with your actual connection string
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			// Configure the model classes and their relationships here
		}
	}
}
