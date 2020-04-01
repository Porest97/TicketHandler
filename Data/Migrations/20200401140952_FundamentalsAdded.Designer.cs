﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketHandler.Data;

namespace TicketHandler.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200401140952_FundamentalsAdded")]
    partial class FundamentalsAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TicketHandler.Models.DataModels.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("TicketHandler.Models.DataModels.Incident", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FEScheduled")
                        .HasColumnType("datetime2");

                    b.Property<string>("IncidentNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IncidentPriorityId")
                        .HasColumnType("int");

                    b.Property<int?>("IncidentStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("IncidentTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("IssueResolved")
                        .HasColumnType("datetime2");

                    b.Property<string>("Logg")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<int?>("PersonId1")
                        .HasColumnType("int");

                    b.Property<int?>("PersonId2")
                        .HasColumnType("int");

                    b.Property<int?>("PurchaseOrderId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Received")
                        .HasColumnType("datetime2");

                    b.Property<string>("Resolution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SiteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IncidentPriorityId");

                    b.HasIndex("IncidentStatusId");

                    b.HasIndex("IncidentTypeId");

                    b.HasIndex("PersonId");

                    b.HasIndex("PersonId1");

                    b.HasIndex("PersonId2");

                    b.HasIndex("PurchaseOrderId");

                    b.HasIndex("SiteId");

                    b.ToTable("Incident");
                });

            modelBuilder.Entity("TicketHandler.Models.DataModels.IncidentPriority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IncidentPriorityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IncidentPriority");
                });

            modelBuilder.Entity("TicketHandler.Models.DataModels.IncidentStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IncidentStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IncidentStatus");
                });

            modelBuilder.Entity("TicketHandler.Models.DataModels.IncidentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IncidentTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IncidentType");
                });

            modelBuilder.Entity("TicketHandler.Models.DataModels.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BankAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ssn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SwishNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("TicketHandler.Models.DataModels.PurchaseOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateTimeApproved")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("POHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PONumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PurchaseOrder");
                });

            modelBuilder.Entity("TicketHandler.Models.DataModels.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumberOfFloors")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int");

                    b.Property<int?>("PersonId1")
                        .HasColumnType("int");

                    b.Property<string>("SiteName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SiteRoleId")
                        .HasColumnType("int");

                    b.Property<int?>("SiteTypeId")
                        .HasColumnType("int");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("PersonId");

                    b.HasIndex("PersonId1");

                    b.HasIndex("SiteRoleId");

                    b.HasIndex("SiteTypeId");

                    b.ToTable("Site");
                });

            modelBuilder.Entity("TicketHandler.Models.DataModels.SiteRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SiteRoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SiteRole");
                });

            modelBuilder.Entity("TicketHandler.Models.DataModels.SiteType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SiteTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SiteType");
                });

            modelBuilder.Entity("TicketHandler.Models.DataModels.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("IncidentId")
                        .HasColumnType("int");

                    b.Property<string>("TicketNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkLogId")
                        .HasColumnType("int");

                    b.Property<int?>("WorkLogId1")
                        .HasColumnType("int");

                    b.Property<int?>("WorkLogId2")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IncidentId");

                    b.HasIndex("WorkLogId");

                    b.HasIndex("WorkLogId1");

                    b.HasIndex("WorkLogId2");

                    b.ToTable("Ticket");
                });

            modelBuilder.Entity("TicketHandler.Models.DataModels.WorkLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BusUnit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateTimeFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTimeTo")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FEEExitsSite")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FEEntersSite")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IncidentId")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WLNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkLogStatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IncidentId");

                    b.HasIndex("WorkLogStatusId");

                    b.ToTable("WorkLog");
                });

            modelBuilder.Entity("TicketHandler.Models.DataModels.WorkLogStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("WorkLogStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkLogStatus");
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

            modelBuilder.Entity("TicketHandler.Models.DataModels.Incident", b =>
                {
                    b.HasOne("TicketHandler.Models.DataModels.IncidentPriority", "IncidentPriority")
                        .WithMany()
                        .HasForeignKey("IncidentPriorityId");

                    b.HasOne("TicketHandler.Models.DataModels.IncidentStatus", "IncidentStatus")
                        .WithMany()
                        .HasForeignKey("IncidentStatusId");

                    b.HasOne("TicketHandler.Models.DataModels.IncidentType", "IncidentType")
                        .WithMany()
                        .HasForeignKey("IncidentTypeId");

                    b.HasOne("TicketHandler.Models.DataModels.Person", "Creator")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("TicketHandler.Models.DataModels.Person", "Receiver")
                        .WithMany()
                        .HasForeignKey("PersonId1");

                    b.HasOne("TicketHandler.Models.DataModels.Person", "FEAssigned")
                        .WithMany()
                        .HasForeignKey("PersonId2");

                    b.HasOne("TicketHandler.Models.DataModels.PurchaseOrder", "PurchaseOrder")
                        .WithMany()
                        .HasForeignKey("PurchaseOrderId");

                    b.HasOne("TicketHandler.Models.DataModels.Site", "Site")
                        .WithMany()
                        .HasForeignKey("SiteId");
                });

            modelBuilder.Entity("TicketHandler.Models.DataModels.Person", b =>
                {
                    b.HasOne("TicketHandler.Models.DataModels.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");
                });

            modelBuilder.Entity("TicketHandler.Models.DataModels.Site", b =>
                {
                    b.HasOne("TicketHandler.Models.DataModels.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId");

                    b.HasOne("TicketHandler.Models.DataModels.Person", "Contact1")
                        .WithMany()
                        .HasForeignKey("PersonId");

                    b.HasOne("TicketHandler.Models.DataModels.Person", "Contact2")
                        .WithMany()
                        .HasForeignKey("PersonId1");

                    b.HasOne("TicketHandler.Models.DataModels.SiteRole", "SiteRole")
                        .WithMany()
                        .HasForeignKey("SiteRoleId");

                    b.HasOne("TicketHandler.Models.DataModels.SiteType", "SiteType")
                        .WithMany()
                        .HasForeignKey("SiteTypeId");
                });

            modelBuilder.Entity("TicketHandler.Models.DataModels.Ticket", b =>
                {
                    b.HasOne("TicketHandler.Models.DataModels.Incident", "Incident")
                        .WithMany()
                        .HasForeignKey("IncidentId");

                    b.HasOne("TicketHandler.Models.DataModels.WorkLog", "WL1")
                        .WithMany()
                        .HasForeignKey("WorkLogId");

                    b.HasOne("TicketHandler.Models.DataModels.WorkLog", "WL2")
                        .WithMany()
                        .HasForeignKey("WorkLogId1");

                    b.HasOne("TicketHandler.Models.DataModels.WorkLog", "WL3")
                        .WithMany()
                        .HasForeignKey("WorkLogId2");
                });

            modelBuilder.Entity("TicketHandler.Models.DataModels.WorkLog", b =>
                {
                    b.HasOne("TicketHandler.Models.DataModels.Incident", "Incident")
                        .WithMany()
                        .HasForeignKey("IncidentId");

                    b.HasOne("TicketHandler.Models.DataModels.WorkLogStatus", "WorkLogStatus")
                        .WithMany()
                        .HasForeignKey("WorkLogStatusId");
                });
#pragma warning restore 612, 618
        }
    }
}
