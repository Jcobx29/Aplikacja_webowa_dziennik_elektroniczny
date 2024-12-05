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
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grades> Grades { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<ContactStudentInfo> ContactStudentInfo { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeacherAddress> TeacherAddresses { get; set; }
        public DbSet<TeacherContactInfo> TeacherContactInfos { get; set; }     

        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);                        
            builder.Entity<Student>().HasOne(a => a.ContactStudentInfo).WithOne(b => b.Student).HasForeignKey<ContactStudentInfo>(e => e.StudentRef);

            builder.Entity<Grades>().HasKey(it => new {it.SubjectId, it.StudentId});
            builder.Entity<Grades>().HasOne<Subject>(it => it.Subject).WithMany(it => it.Grades).HasForeignKey(it => it.SubjectId);
            builder.Entity<Grades>().HasOne<Student>(it => it.Student).WithMany(it => it.Grades).HasForeignKey(it => it.StudentId);

            builder.Entity<Teacher>().HasOne(a => a.TeacherAddress).WithOne(b => b.Teacher).HasForeignKey<TeacherAddress>(e => e.TeacherRef);
            builder.Entity<Teacher>().HasOne(a => a.TeacherContactInfo).WithOne(b => b.Teacher).HasForeignKey<TeacherContactInfo>(e => e.TeacherRef);
        }
    }
}
