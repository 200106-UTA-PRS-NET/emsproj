﻿// <auto-generated />
using System;
using EMS_Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EMS_Data.Migrations
{
    [DbContext(typeof(EmployeeDbContext))]
    partial class EmployeeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EMS_Data.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Head")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Training",
                            Phone = "7894561230"
                        },
                        new
                        {
                            Id = 2,
                            Name = "HR",
                            Phone = "9876543210"
                        });
                });

            modelBuilder.Entity("EMS_Data.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnName("age")
                        .HasColumnType("int");

                    b.Property<int?>("Deptid")
                        .HasColumnType("int");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Lname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Mname")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<decimal?>("Salary")
                        .HasColumnName("salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Ssn")
                        .HasColumnName("ssn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Startdate")
                        .HasColumnName("startdate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Deptid");

                    b.ToTable("employee","Revature");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 35,
                            Deptid = 1,
                            Fname = "Fred",
                            Lname = "Belotte",
                            Salary = 11000.00m,
                            Ssn = "789kl45",
                            Startdate = new DateTime(2020, 1, 29, 7, 45, 39, 677, DateTimeKind.Local).AddTicks(4808)
                        },
                        new
                        {
                            Id = 2,
                            Age = 25,
                            Deptid = 2,
                            Fname = "Cameron",
                            Lname = "Coley",
                            Salary = 5000.00m,
                            Ssn = "745kl65",
                            Startdate = new DateTime(2020, 1, 29, 7, 45, 39, 679, DateTimeKind.Local).AddTicks(3133)
                        });
                });

            modelBuilder.Entity("EMS_Data.Models.Employee", b =>
                {
                    b.HasOne("EMS_Data.Models.Department", "Dept")
                        .WithMany("Employee")
                        .HasForeignKey("Deptid");
                });
#pragma warning restore 612, 618
        }
    }
}
