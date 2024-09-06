using dziennik_elektroniczny.Infrastructure.Model._1A;
using dziennik_elektroniczny.Infrastructure.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dziennik_elektroniczny.Infrastructure.Model.TeacherInfo;

namespace dziennik_elektroniczny.Infrastructure
{
    public class DataContext : IdentityDbContext
    {
        public DbSet<_1ABiology> _1ABiology { get; set; }
        public DbSet<_1AChemistry> _1AChemistry { get; set; }
        public DbSet<_1AEnglish> _1AEnglish { get; set; }
        public DbSet<_1AGeography> _1AGeography { get; set; }
        public DbSet<_1AGerman> _1AGerman { get; set; }
        public DbSet<_1AHistory> _1AHistory { get; set; }
        public DbSet<_1AMath> _1AMath { get; set; }
        public DbSet<_1AStudent> _1AStudents { get; set; }
        public DbSet<ContactStudentInfo1A> ContactStudentInfo1A { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<TeacherAddress> TeacherAddress { get; set; }
        public DbSet<TeacherContactInfo> TeacherContactInfo { get; set; }
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<_1AStudent>().HasOne(a => a._1ABiology).WithOne(b => b._1AStudent).HasForeignKey<_1ABiology>(e => e.StudentRef);
            builder.Entity<_1AStudent>().HasOne(a => a._1AChemistry).WithOne(b => b._1AStudent).HasForeignKey<_1AChemistry>(e => e.StudentRef);
            builder.Entity<_1AStudent>().HasOne(a => a._1AEnglish).WithOne(b => b._1AStudent).HasForeignKey<_1AEnglish>(e => e.StudentRef);
            builder.Entity<_1AStudent>().HasOne(a => a._1AGeography).WithOne(b => b._1AStudent).HasForeignKey<_1AGeography>(e => e.StudentRef);
            builder.Entity<_1AStudent>().HasOne(a => a._1AGerman).WithOne(b => b._1AStudent).HasForeignKey<_1AGerman>(e => e.StudentRef);
            builder.Entity<_1AStudent>().HasOne(a => a._1AHistory).WithOne(b => b._1AStudent).HasForeignKey<_1AHistory>(e => e.StudentRef);
            builder.Entity<_1AStudent>().HasOne(a => a._1AMath).WithOne(b => b._1AStudent).HasForeignKey<_1AMath>(e => e.StudentRef);
            builder.Entity<_1AStudent>().HasOne(a => a.ContactStudentInfo1A).WithOne(b => b._1AStudent).HasForeignKey<ContactStudentInfo1A>(e => e.StudentRef);

            builder.Entity<Teacher>().HasOne(a => a.TeacherAddress).WithOne(b => b.Teacher).HasForeignKey<TeacherAddress>(e => e.TeacherRef);
            builder.Entity<Teacher>().HasOne(a => a.TeacherContactInfo).WithOne(b => b.Teacher).HasForeignKey<TeacherContactInfo>(e => e.TeacherRef);
        }
    }
}
