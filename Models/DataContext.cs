namespace Hoyna.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Doctortbl> Doctortbls { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<empEducation> empEducations { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<patient> patients { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<Usertbl> Usertbls { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Admin>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.FName)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.LName)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.SerialNo)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.set_time)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Appointment>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.DName)
                .IsUnicode(false);

            modelBuilder.Entity<Department>()
                .Property(e => e.Discription)
                .IsUnicode(false);

            modelBuilder.Entity<Doctortbl>()
                .Property(e => e.FName)
                .IsUnicode(false);

            modelBuilder.Entity<Doctortbl>()
                .Property(e => e.LName)
                .IsUnicode(false);

            modelBuilder.Entity<Doctortbl>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Doctortbl>()
                .Property(e => e.Passward)
                .IsUnicode(false);

            modelBuilder.Entity<Doctortbl>()
                .Property(e => e.DOB)
                .IsUnicode(false);

            modelBuilder.Entity<Doctortbl>()
                .Property(e => e.Gander)
                .IsUnicode(false);

            modelBuilder.Entity<Doctortbl>()
                .Property(e => e.DocAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Doctortbl>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Doctortbl>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Doctortbl>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Doctortbl>()
                .Property(e => e.Post)
                .IsUnicode(false);

            modelBuilder.Entity<Education>()
                .Property(e => e.DegreeName)
                .IsUnicode(false);

            modelBuilder.Entity<Education>()
                .Property(e => e.StartDate)
                .IsUnicode(false);

            modelBuilder.Entity<Education>()
                .Property(e => e.EndDate)
                .IsUnicode(false);

            modelBuilder.Entity<Education>()
                .Property(e => e.University)
                .IsUnicode(false);

            modelBuilder.Entity<Education>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Education>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<empEducation>()
                .Property(e => e.degreeName)
                .IsUnicode(false);

            modelBuilder.Entity<empEducation>()
                .Property(e => e.startDate)
                .IsUnicode(false);

            modelBuilder.Entity<empEducation>()
                .Property(e => e.EndDate)
                .IsUnicode(false);

            modelBuilder.Entity<empEducation>()
                .Property(e => e.University)
                .IsUnicode(false);

            modelBuilder.Entity<empEducation>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<empEducation>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmpFName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmpLName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Passward)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.DOB)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Gander)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Post)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeType>()
                .Property(e => e.eTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<patient>()
                .Property(e => e.Diseases)
                .IsUnicode(false);

            modelBuilder.Entity<patient>()
                .Property(e => e.MaritalStatus)
                .IsUnicode(false);

            modelBuilder.Entity<patient>()
                .Property(e => e.BloodGroup)
                .IsUnicode(false);

            modelBuilder.Entity<patient>()
                .Property(e => e.BloodPresure)
                .IsUnicode(false);

            modelBuilder.Entity<patient>()
                .Property(e => e.Sugger)
                .IsUnicode(false);

            modelBuilder.Entity<patient>()
                .Property(e => e.Injury)
                .IsUnicode(false);

            modelBuilder.Entity<patient>()
                .Property(e => e.RoomNo)
                .IsUnicode(false);

            modelBuilder.Entity<Specialization>()
                .Property(e => e.SpecName)
                .IsUnicode(false);

            modelBuilder.Entity<Usertbl>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Usertbl>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Usertbl>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
