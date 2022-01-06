﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3.Models;

namespace WebApplication3.Migrations
{
    [DbContext(typeof(EmpContext))]
    [Migration("20220106112341_create databse")]
    partial class createdatabse
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WebApplication3.Models.City", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("WebApplication3.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("CityNo")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("WebApplication3.Models.EmpRole", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("EMPID")
                        .HasColumnType("int");

                    b.Property<int?>("EMPLOYEEID")
                        .HasColumnType("int");

                    b.Property<int>("ROLEID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EMPLOYEEID");

                    b.HasIndex("ROLEID");

                    b.ToTable("EmpRoles");
                });

            modelBuilder.Entity("WebApplication3.Models.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("CityID")
                        .HasColumnType("int");

                    b.Property<int>("CityNo")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<int>("DeptNo")
                        .HasColumnType("int");

                    b.Property<int>("HireDate")
                        .HasColumnType("int");

                    b.Property<int>("IsActive")
                        .HasColumnType("int");

                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("JobId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WebApplication3.Models.Job", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("WebApplication3.Models.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("WebApplication3.Models.EmpRole", b =>
                {
                    b.HasOne("WebApplication3.Models.Employee", "EMPLOYEE")
                        .WithMany("EMPROLE")
                        .HasForeignKey("EMPLOYEEID");

                    b.HasOne("WebApplication3.Models.Role", "ROLE")
                        .WithMany("EMPROLE")
                        .HasForeignKey("ROLEID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EMPLOYEE");

                    b.Navigation("ROLE");
                });

            modelBuilder.Entity("WebApplication3.Models.Employee", b =>
                {
                    b.HasOne("WebApplication3.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID");

                    b.HasOne("WebApplication3.Models.Department", "Department")
                        .WithMany("employees")
                        .HasForeignKey("DepartmentID");

                    b.HasOne("WebApplication3.Models.Job", "Job")
                        .WithMany()
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Department");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("WebApplication3.Models.Department", b =>
                {
                    b.Navigation("employees");
                });

            modelBuilder.Entity("WebApplication3.Models.Employee", b =>
                {
                    b.Navigation("EMPROLE");
                });

            modelBuilder.Entity("WebApplication3.Models.Role", b =>
                {
                    b.Navigation("EMPROLE");
                });
#pragma warning restore 612, 618
        }
    }
}
