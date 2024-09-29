using dziennik_elektroniczny.Domain.Model._1A;
using dziennik_elektroniczny.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dziennik_elektroniczny.Domain.Model.TeacherInfo;

namespace dziennik_elektroniczny.Infrastructure
{
    public class DataContext : IdentityDbContext
    {
        public DbSet<Biology> _1ABiology { get; set; }
        public DbSet<Chemistry> _1AChemistry { get; set; }
        public DbSet<English> _1AEnglish { get; set; }
        public DbSet<Geography> _1AGeography { get; set; }
        public DbSet<German> _1AGerman { get; set; }
        public DbSet<History> _1AHistory { get; set; }
        public DbSet<Domain.Model.Math> _1AMath { get; set; }
        public DbSet<Student> _1AStudents { get; set; }
        public DbSet<ContactStudentInfo> ContactStudentInfo1A { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<TeacherAddress> TeacherAddress { get; set; }
        public DbSet<TeacherContactInfo> TeacherContactInfo { get; set; }

        public DbSet<Biology> _1BBiology { get; set; }
        public DbSet<Chemistry> _1BChemistry { get; set; }
        public DbSet<English> _1BEnglish { get; set; }
        public DbSet<Geography> _1BGeography { get; set; }
        public DbSet<German> _1BGerman { get; set; }
        public DbSet<History> _1BHistory { get; set; }
        public DbSet<Domain.Model.Math> _1BMath { get; set; }
        public DbSet<Student> _1BStudents { get; set; }
        public DbSet<ContactStudentInfo> ContactStudentInfo1B { get; set; }

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
            builder.Entity<Student>().HasOne(a => a.Math).WithOne(b => b.Student).HasForeignKey<Domain.Model.Math>(e => e.StudentRef);
            builder.Entity<Student>().HasOne(a => a.ContactStudentInfo).WithOne(b => b.Student).HasForeignKey<ContactStudentInfo>(e => e.StudentRef);

            builder.Entity<Teacher>().HasOne(a => a.TeacherAddress).WithOne(b => b.Teacher).HasForeignKey<TeacherAddress>(e => e.TeacherRef);
            builder.Entity<Teacher>().HasOne(a => a.TeacherContactInfo).WithOne(b => b.Teacher).HasForeignKey<TeacherContactInfo>(e => e.TeacherRef);
        }
    }
}
