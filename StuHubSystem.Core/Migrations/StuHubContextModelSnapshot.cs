﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StuHubSystem.Core.Database;

namespace StuHubSystem.Core.Migrations
{
    [DbContext(typeof(StuHubContext))]
    partial class StuHubContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.1.20451.13");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("StuHubSystem.Core.Entities.EducationSystem.School", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Boy")
                        .HasColumnType("int");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("DistrictId")
                        .HasColumnType("int");

                    b.Property<int>("Girl")
                        .HasColumnType("int");

                    b.Property<string>("SchoolAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolBackgroundImages")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolLogoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SchoolName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchoolId");

                    b.HasIndex("CityId");

                    b.HasIndex("DistrictId");

                    b.ToTable("Schools");
                });

            modelBuilder.Entity("StuHubSystem.Core.Entities.EducationSystem.StudyField", b =>
                {
                    b.Property<int>("StudyFieldId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("StudyFieldName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("StudyGroupId")
                        .HasColumnType("int");

                    b.HasKey("StudyFieldId");

                    b.HasIndex("StudyGroupId");

                    b.ToTable("StudyFields");
                });

            modelBuilder.Entity("StuHubSystem.Core.Entities.EducationSystem.StudyGroup", b =>
                {
                    b.Property<int>("StudyGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("StudyGroupColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudyGroupImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudyGroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudyGroupId");

                    b.ToTable("StudyGroups");
                });

            modelBuilder.Entity("StuHubSystem.Core.Entities.Person.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<byte>("Age")
                        .HasColumnType("tinyint");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DayOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("Gender")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

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

                    b.Property<string>("ProfileImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolID")
                        .HasColumnType("int");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudyFieldID")
                        .HasColumnType("int");

                    b.Property<int?>("StudyGroupID")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserAddress")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserCity")
                        .HasColumnType("int");

                    b.Property<int>("UserDistrict")
                        .HasColumnType("int");

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

                    b.HasIndex("StudyFieldID");

                    b.HasIndex("StudyGroupID");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("StuHubSystem.Core.Entities.Subjects.College.CollegeSubjectRequest", b =>
                {
                    b.Property<int>("CollegeSubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CollegeSubjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateUpload")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int?>("SchoolId")
                        .HasColumnType("int");

                    b.Property<int?>("StudyFieldId")
                        .HasColumnType("int");

                    b.Property<int?>("StudyGroupId")
                        .HasColumnType("int");

                    b.Property<string>("Teacher")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CollegeSubjectId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("SchoolId");

                    b.HasIndex("StudyFieldId");

                    b.HasIndex("StudyGroupId");

                    b.ToTable("CollegeSubjectRequests");
                });

            modelBuilder.Entity("StuHubSystem.Core.VietNamLocation.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("StuHubSystem.Core.VietNamLocation.District", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("DistrictName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DistrictId");

                    b.HasIndex("CityId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("StuHubSystem.Core.Entities.Person.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("StuHubSystem.Core.Entities.Person.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StuHubSystem.Core.Entities.Person.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("StuHubSystem.Core.Entities.Person.UserModel", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StuHubSystem.Core.Entities.EducationSystem.School", b =>
                {
                    b.HasOne("StuHubSystem.Core.VietNamLocation.City", "CityID")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.HasOne("StuHubSystem.Core.VietNamLocation.District", "DistrictID")
                        .WithMany()
                        .HasForeignKey("DistrictId");

                    b.Navigation("CityID");

                    b.Navigation("DistrictID");
                });

            modelBuilder.Entity("StuHubSystem.Core.Entities.EducationSystem.StudyField", b =>
                {
                    b.HasOne("StuHubSystem.Core.Entities.EducationSystem.StudyGroup", "StudyGroupID")
                        .WithMany()
                        .HasForeignKey("StudyGroupId");

                    b.Navigation("StudyGroupID");
                });

            modelBuilder.Entity("StuHubSystem.Core.Entities.Person.UserModel", b =>
                {
                    b.HasOne("StuHubSystem.Core.Entities.EducationSystem.StudyField", "StudyField")
                        .WithMany()
                        .HasForeignKey("StudyFieldID");

                    b.HasOne("StuHubSystem.Core.Entities.EducationSystem.StudyGroup", "StudyGroup")
                        .WithMany()
                        .HasForeignKey("StudyGroupID");

                    b.Navigation("StudyField");

                    b.Navigation("StudyGroup");
                });

            modelBuilder.Entity("StuHubSystem.Core.Entities.Subjects.College.CollegeSubjectRequest", b =>
                {
                    b.HasOne("StuHubSystem.Core.Entities.Person.UserModel", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.HasOne("StuHubSystem.Core.Entities.EducationSystem.School", "SchoolID")
                        .WithMany()
                        .HasForeignKey("SchoolId");

                    b.HasOne("StuHubSystem.Core.Entities.EducationSystem.StudyField", "StudyFieldID")
                        .WithMany()
                        .HasForeignKey("StudyFieldId");

                    b.HasOne("StuHubSystem.Core.Entities.EducationSystem.StudyGroup", "StudyGroupID")
                        .WithMany()
                        .HasForeignKey("StudyGroupId");

                    b.Navigation("Owner");

                    b.Navigation("SchoolID");

                    b.Navigation("StudyFieldID");

                    b.Navigation("StudyGroupID");
                });

            modelBuilder.Entity("StuHubSystem.Core.VietNamLocation.District", b =>
                {
                    b.HasOne("StuHubSystem.Core.VietNamLocation.City", "CityID")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.Navigation("CityID");
                });
#pragma warning restore 612, 618
        }
    }
}
