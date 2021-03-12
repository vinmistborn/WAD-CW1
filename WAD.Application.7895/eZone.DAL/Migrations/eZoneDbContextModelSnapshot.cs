﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eZone.DAL;

namespace eZone.DAL.Migrations
{
    [DbContext(typeof(eZoneDbContext))]
    partial class eZoneDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eZone..DAL.DBO.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseDuration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseLevel")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Fee")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("eZone.DAL.DBO.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("GroupLevel")
                        .HasColumnType("int");

                    b.Property<int>("GroupTime")
                        .HasColumnType("int");

                    b.Property<int>("LessonDays")
                        .HasColumnType("int");

                    b.Property<int>("NumOfStudents")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("eZone.DAL.DBO.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FirstLesson")
                        .HasColumnType("datetime2");

                    b.Property<int>("FirstName")
                        .HasColumnType("int");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("LastName")
                        .HasColumnType("int");

                    b.Property<int>("PaymentStatus")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("eZone.DAL.DBO.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FirstName")
                        .HasColumnType("int");

                    b.Property<double>("IELTS_Score")
                        .HasColumnType("float");

                    b.Property<int>("LastName")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("eZone.DAL.DBO.Group", b =>
                {
                    b.HasOne("eZone.DAL.DBO.Course", "Course")
                        .WithMany("Group")
                        .HasForeignKey("CourseId");

                    b.HasOne("eZone.DAL.DBO.Teacher", "Teacher")
                        .WithMany("Group")
                        .HasForeignKey("TeacherId");

                    b.Navigation("Course");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("eZone.DAL.DBO.Student", b =>
                {
                    b.HasOne("eZone.DAL.DBO.Group", "Group")
                        .WithMany("Student")
                        .HasForeignKey("GroupId");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("eZone.DAL.DBO.Course", b =>
                {
                    b.Navigation("Group");
                });

            modelBuilder.Entity("eZone.DAL.DBO.Group", b =>
                {
                    b.Navigation("Student");
                });

            modelBuilder.Entity("eZone.DAL.DBO.Teacher", b =>
                {
                    b.Navigation("Group");
                });
#pragma warning restore 612, 618
        }
    }
}
