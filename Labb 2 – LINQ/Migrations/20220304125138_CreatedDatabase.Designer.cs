﻿// <auto-generated />
using System;
using Labb_2___LINQ.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Labb_2___LINQ.Migrations
{
    [DbContext(typeof(Labb_2DbContext))]
    [Migration("20220304125138_CreatedDatabase")]
    partial class CreatedDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Labb_2___LINQ.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Labb_2___LINQ.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StudentDateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("StudentFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("TeacherID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Labb_2___LINQ.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeacherID")
                        .HasColumnType("int");

                    b.HasKey("SubjectId");

                    b.HasIndex("TeacherID");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("Labb_2___LINQ.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("TeacherDateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("TeacherFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherGender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherLastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Labb_2___LINQ.Models.Student", b =>
                {
                    b.HasOne("Labb_2___LINQ.Models.Course", null)
                        .WithMany("Student")
                        .HasForeignKey("CourseId");

                    b.HasOne("Labb_2___LINQ.Models.Teacher", null)
                        .WithMany("Student")
                        .HasForeignKey("TeacherID");
                });

            modelBuilder.Entity("Labb_2___LINQ.Models.Subject", b =>
                {
                    b.HasOne("Labb_2___LINQ.Models.Teacher", null)
                        .WithMany("Subject")
                        .HasForeignKey("TeacherID");
                });
#pragma warning restore 612, 618
        }
    }
}
