﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dziennik_elektroniczny.Infrastructure;

#nullable disable

namespace dziennik_elektroniczny.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241013131323_newUpdate")]
    partial class newUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.Biology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("HomeworkAvarage")
                        .HasColumnType("float");

                    b.Property<double>("ShortQuizAvarage")
                        .HasColumnType("float");

                    b.Property<int>("StudentRef")
                        .HasColumnType("int");

                    b.Property<double>("TestAvarage")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("StudentRef")
                        .IsUnique();

                    b.ToTable("Biology");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.Chemistry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("HomeworkAvarage")
                        .HasColumnType("float");

                    b.Property<double>("ShortQuizAvarage")
                        .HasColumnType("float");

                    b.Property<int>("StudentRef")
                        .HasColumnType("int");

                    b.Property<double>("TestAvarage")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("StudentRef")
                        .IsUnique();

                    b.ToTable("Chemistry");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.ContactStudentInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentRef")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentRef")
                        .IsUnique();

                    b.ToTable("ContactStudentInfo");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.English", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("HomeworkAvarage")
                        .HasColumnType("float");

                    b.Property<double>("ShortQuizAvarage")
                        .HasColumnType("float");

                    b.Property<int>("StudentRef")
                        .HasColumnType("int");

                    b.Property<double>("TestAvarage")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("StudentRef")
                        .IsUnique();

                    b.ToTable("English");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.Geography", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("HomeworkAvarage")
                        .HasColumnType("float");

                    b.Property<double>("ShortQuizAvarage")
                        .HasColumnType("float");

                    b.Property<int>("StudentRef")
                        .HasColumnType("int");

                    b.Property<double>("TestAvarage")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("StudentRef")
                        .IsUnique();

                    b.ToTable("Geography");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.German", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("HomeworkAvarage")
                        .HasColumnType("float");

                    b.Property<double>("ShortQuizAvarage")
                        .HasColumnType("float");

                    b.Property<int>("StudentRef")
                        .HasColumnType("int");

                    b.Property<double>("TestAvarage")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("StudentRef")
                        .IsUnique();

                    b.ToTable("German");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.History", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("HomeworkAvarage")
                        .HasColumnType("float");

                    b.Property<double>("ShortQuizAvarage")
                        .HasColumnType("float");

                    b.Property<int>("StudentRef")
                        .HasColumnType("int");

                    b.Property<double>("TestAvarage")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("StudentRef")
                        .IsUnique();

                    b.ToTable("History");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.Maths", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("HomeworkAvarage")
                        .HasColumnType("float");

                    b.Property<double>("ShortQuizAvarage")
                        .HasColumnType("float");

                    b.Property<int>("StudentRef")
                        .HasColumnType("int");

                    b.Property<double>("TestAvarage")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("StudentRef")
                        .IsUnique();

                    b.ToTable("Maths");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClassId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.TeacherInfo.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearsOfTeaching")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.TeacherInfo.TeacherAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherRef")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("TeacherRef")
                        .IsUnique();

                    b.ToTable("TeacherAddresses");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.TeacherInfo.TeacherContactInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherRef")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherRef")
                        .IsUnique();

                    b.ToTable("TeacherContactInfos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.Biology", b =>
                {
                    b.HasOne("dziennik_elektroniczny.Domain.Model.StudentInfo.Student", "Student")
                        .WithOne("Biology")
                        .HasForeignKey("dziennik_elektroniczny.Domain.Model.StudentInfo.Biology", "StudentRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.Chemistry", b =>
                {
                    b.HasOne("dziennik_elektroniczny.Domain.Model.StudentInfo.Student", "Student")
                        .WithOne("Chemistry")
                        .HasForeignKey("dziennik_elektroniczny.Domain.Model.StudentInfo.Chemistry", "StudentRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.ContactStudentInfo", b =>
                {
                    b.HasOne("dziennik_elektroniczny.Domain.Model.StudentInfo.Student", "Student")
                        .WithOne("ContactStudentInfo")
                        .HasForeignKey("dziennik_elektroniczny.Domain.Model.StudentInfo.ContactStudentInfo", "StudentRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.English", b =>
                {
                    b.HasOne("dziennik_elektroniczny.Domain.Model.StudentInfo.Student", "Student")
                        .WithOne("English")
                        .HasForeignKey("dziennik_elektroniczny.Domain.Model.StudentInfo.English", "StudentRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.Geography", b =>
                {
                    b.HasOne("dziennik_elektroniczny.Domain.Model.StudentInfo.Student", "Student")
                        .WithOne("Geography")
                        .HasForeignKey("dziennik_elektroniczny.Domain.Model.StudentInfo.Geography", "StudentRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.German", b =>
                {
                    b.HasOne("dziennik_elektroniczny.Domain.Model.StudentInfo.Student", "Student")
                        .WithOne("German")
                        .HasForeignKey("dziennik_elektroniczny.Domain.Model.StudentInfo.German", "StudentRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.History", b =>
                {
                    b.HasOne("dziennik_elektroniczny.Domain.Model.StudentInfo.Student", "Student")
                        .WithOne("History")
                        .HasForeignKey("dziennik_elektroniczny.Domain.Model.StudentInfo.History", "StudentRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.Maths", b =>
                {
                    b.HasOne("dziennik_elektroniczny.Domain.Model.StudentInfo.Student", "Student")
                        .WithOne("Maths")
                        .HasForeignKey("dziennik_elektroniczny.Domain.Model.StudentInfo.Maths", "StudentRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.TeacherInfo.TeacherAddress", b =>
                {
                    b.HasOne("dziennik_elektroniczny.Domain.Model.TeacherInfo.Teacher", "Teacher")
                        .WithOne("TeacherAddress")
                        .HasForeignKey("dziennik_elektroniczny.Domain.Model.TeacherInfo.TeacherAddress", "TeacherRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.TeacherInfo.TeacherContactInfo", b =>
                {
                    b.HasOne("dziennik_elektroniczny.Domain.Model.TeacherInfo.Teacher", "Teacher")
                        .WithOne("TeacherContactInfo")
                        .HasForeignKey("dziennik_elektroniczny.Domain.Model.TeacherInfo.TeacherContactInfo", "TeacherRef")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.StudentInfo.Student", b =>
                {
                    b.Navigation("Biology")
                        .IsRequired();

                    b.Navigation("Chemistry")
                        .IsRequired();

                    b.Navigation("ContactStudentInfo")
                        .IsRequired();

                    b.Navigation("English")
                        .IsRequired();

                    b.Navigation("Geography")
                        .IsRequired();

                    b.Navigation("German")
                        .IsRequired();

                    b.Navigation("History")
                        .IsRequired();

                    b.Navigation("Maths")
                        .IsRequired();
                });

            modelBuilder.Entity("dziennik_elektroniczny.Domain.Model.TeacherInfo.Teacher", b =>
                {
                    b.Navigation("TeacherAddress")
                        .IsRequired();

                    b.Navigation("TeacherContactInfo")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
