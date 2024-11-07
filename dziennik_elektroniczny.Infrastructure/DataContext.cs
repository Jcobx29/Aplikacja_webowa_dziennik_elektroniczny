using dziennik_elektroniczny.Domain.Model.StudentInfo;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dziennik_elektroniczny.Domain.Model.TeacherInfo;
using dziennik_elektroniczny.Domain.Model;

namespace dziennik_elektroniczny.Infrastructure
{
    public class DataContext : IdentityDbContext
    {
        public DbSet<Biology> Biology { get; set; }
        public DbSet<Chemistry> Chemistry { get; set; }
        public DbSet<English> English { get; set; }
        public DbSet<Geography> Geography { get; set; }
        public DbSet<German> German { get; set; }
        public DbSet<History> History { get; set; }
        public DbSet<Maths> Maths { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<ContactStudentInfo> ContactStudentInfo { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherAddress> TeacherAddresses { get; set; }
        public DbSet<TeacherContactInfo> TeacherContactInfos { get; set; }     

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);                        

            builder.Entity<Student>().HasOne(a => a.Biology).WithOne(b => b.Student).HasForeignKey<Biology>(e => e.StudentRef);
            builder.Entity<Student>().HasOne(a => a.Chemistry).WithOne(b => b.Student).HasForeignKey<Chemistry>(e => e.StudentRef);
            builder.Entity<Student>().HasOne(a => a.English).WithOne(b => b.Student).HasForeignKey<English>(e => e.StudentRef);
            builder.Entity<Student>().HasOne(a => a.Geography).WithOne(b => b.Student).HasForeignKey<Geography>(e => e.StudentRef);
            builder.Entity<Student>().HasOne(a => a.German).WithOne(b => b.Student).HasForeignKey<German>(e => e.StudentRef);
            builder.Entity<Student>().HasOne(a => a.History).WithOne(b => b.Student).HasForeignKey<History>(e => e.StudentRef);
            builder.Entity<Student>().HasOne(a => a.Maths).WithOne(b => b.Student).HasForeignKey<Maths>(e => e.StudentRef);
            builder.Entity<Student>().HasOne(a => a.ContactStudentInfo).WithOne(b => b.Student).HasForeignKey<ContactStudentInfo>(e => e.StudentRef);

            builder.Entity<Teacher>().HasOne(a => a.TeacherAddress).WithOne(b => b.Teacher).HasForeignKey<TeacherAddress>(e => e.TeacherRef);
            builder.Entity<Teacher>().HasOne(a => a.TeacherContactInfo).WithOne(b => b.Teacher).HasForeignKey<TeacherContactInfo>(e => e.TeacherRef);
        }
    }
}
