﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eDrsDB.Data;

namespace eDrsDB.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210216124815_priority")]
    partial class priority
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eDrsDB.Models.ApplicationForm", b =>
                {
                    b.Property<long>("ApplicationFormId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("ApplicationFormId1")
                        .HasColumnType("bigint");

                    b.Property<long>("DocumentReferenceId")
                        .HasColumnType("bigint");

                    b.Property<int>("FeeInPence")
                        .HasColumnType("int");

                    b.Property<long?>("PartyId")
                        .HasColumnType("bigint");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<long?>("SupportingDocumentsSupportingDocumentId")
                        .HasColumnType("bigint");

                    b.Property<long?>("TitleNumberId")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicationFormId");

                    b.HasIndex("ApplicationFormId1");

                    b.HasIndex("DocumentReferenceId");

                    b.HasIndex("PartyId");

                    b.HasIndex("SupportingDocumentsSupportingDocumentId");

                    b.HasIndex("TitleNumberId");

                    b.ToTable("ApplicationForms");
                });

            modelBuilder.Entity("eDrsDB.Models.Document", b =>
                {
                    b.Property<long>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ApplicationFormId")
                        .HasColumnType("bigint");

                    b.Property<string>("CertifiedCopy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocumentId");

                    b.HasIndex("ApplicationFormId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("eDrsDB.Models.DocumentReference", b =>
                {
                    b.Property<long>("DocumentReferenceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AP1WarningUnderstood")
                        .HasColumnType("bit");

                    b.Property<string>("ApplicationAffects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DisclosableOveridingInterests")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalAuthority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostcodeOfProperty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("TelephoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("TotalFeeInPence")
                        .HasColumnType("int");

                    b.Property<long?>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("DocumentReferenceId");

                    b.HasIndex("UserId");

                    b.ToTable("DocumentReferences");
                });

            modelBuilder.Entity("eDrsDB.Models.ErrorLogs", b =>
                {
                    b.Property<long>("ErrorLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassName")
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Datetime")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Message")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(2147483647);

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(2147483647);

                    b.Property<string>("StackTraceString")
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(2147483647);

                    b.HasKey("ErrorLogId");

                    b.ToTable("ErrorLogs");
                });

            modelBuilder.Entity("eDrsDB.Models.Party", b =>
                {
                    b.Property<long>("PartyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyOrForeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DocumentReferenceId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsApplicant")
                        .HasColumnType("bit");

                    b.Property<string>("PartyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roles")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PartyId");

                    b.HasIndex("DocumentReferenceId");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("eDrsDB.Models.RegistrationType", b =>
                {
                    b.Property<long>("RegistrationTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("TypeCode")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("TypeName")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.HasKey("RegistrationTypeId");

                    b.ToTable("RegistrationTypes");

                    b.HasData(
                        new
                        {
                            RegistrationTypeId = 1L,
                            Status = true,
                            TypeCode = "doc_reg",
                            TypeName = "Document Registration",
                            UpdatedDate = new DateTime(2021, 2, 16, 18, 18, 14, 775, DateTimeKind.Local).AddTicks(9958),
                            Url = "document-registration"
                        },
                        new
                        {
                            RegistrationTypeId = 2L,
                            Status = true,
                            TypeCode = "lease_ext",
                            TypeName = "Lease Extension",
                            UpdatedDate = new DateTime(2021, 2, 16, 18, 18, 14, 776, DateTimeKind.Local).AddTicks(8200),
                            Url = "lease-extension"
                        },
                        new
                        {
                            RegistrationTypeId = 3L,
                            Status = true,
                            TypeCode = "new_lease",
                            TypeName = "New Lease",
                            UpdatedDate = new DateTime(2021, 2, 16, 18, 18, 14, 776, DateTimeKind.Local).AddTicks(8228),
                            Url = "new-lease"
                        },
                        new
                        {
                            RegistrationTypeId = 4L,
                            Status = true,
                            TypeCode = "transfer",
                            TypeName = "Transfer of Part",
                            UpdatedDate = new DateTime(2021, 2, 16, 18, 18, 14, 776, DateTimeKind.Local).AddTicks(8231),
                            Url = "transfer"
                        },
                        new
                        {
                            RegistrationTypeId = 5L,
                            Status = true,
                            TypeCode = "rem_frm",
                            TypeName = "Removal of default form A restriction (JP1)",
                            UpdatedDate = new DateTime(2021, 2, 16, 18, 18, 14, 776, DateTimeKind.Local).AddTicks(8233),
                            Url = "removal-form"
                        });
                });

            modelBuilder.Entity("eDrsDB.Models.SupportingDocuments", b =>
                {
                    b.Property<long>("SupportingDocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CertifiedCopy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DocumentReferenceId")
                        .HasColumnType("bigint");

                    b.HasKey("SupportingDocumentId");

                    b.HasIndex("DocumentReferenceId");

                    b.ToTable("SupportingDocuments");
                });

            modelBuilder.Entity("eDrsDB.Models.TitleNumber", b =>
                {
                    b.Property<long>("TitleNumberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<long>("DocumentReferenceId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("TitleNumberCode")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("TitleNumberId");

                    b.HasIndex("DocumentReferenceId");

                    b.ToTable("TitleNumbers");
                });

            modelBuilder.Entity("eDrsDB.Models.User", b =>
                {
                    b.Property<long>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(350)")
                        .HasMaxLength(350);

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Lastname")
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1L,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Designation = "admin",
                            Email = "dushyanthaccura@gmail.com",
                            Firstname = "Admin",
                            PasswordHash = new byte[] { 106, 141, 231, 2, 163, 53, 157, 242, 20, 231, 71, 214, 252, 221, 47, 142, 2, 125, 131, 223, 69, 35, 59, 61, 138, 186, 242, 162, 66, 246, 156, 248, 7, 95, 73, 42, 32, 31, 202, 127, 157, 2, 98, 27, 56, 105, 129, 78, 220, 190, 229, 190, 90, 233, 20, 125, 229, 44, 132, 215, 147, 75, 219, 121 },
                            PasswordSalt = new byte[] { 115, 123, 0, 178, 96, 138, 253, 192, 2, 255, 154, 203, 4, 249, 114, 62, 250, 222, 93, 233, 110, 250, 93, 131, 88, 206, 248, 25, 9, 204, 1, 59, 60, 52, 177, 11, 111, 49, 230, 142, 107, 46, 135, 14, 114, 240, 71, 188, 151, 212, 233, 242, 185, 87, 181, 36, 166, 69, 106, 138, 68, 51, 123, 220, 104, 225, 87, 193, 31, 160, 215, 23, 221, 248, 105, 83, 42, 172, 193, 212, 12, 230, 33, 80, 102, 87, 212, 41, 162, 212, 18, 73, 3, 132, 39, 236, 202, 243, 29, 68, 132, 228, 179, 102, 169, 225, 109, 220, 124, 57, 143, 66, 28, 107, 128, 132, 147, 223, 197, 2, 48, 188, 66, 30, 120, 251, 176, 40 },
                            Status = true,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("eDrsDB.Models.ApplicationForm", b =>
                {
                    b.HasOne("eDrsDB.Models.ApplicationForm", null)
                        .WithMany("ApplicationForms")
                        .HasForeignKey("ApplicationFormId1");

                    b.HasOne("eDrsDB.Models.DocumentReference", "DocumentReference")
                        .WithMany("Applications")
                        .HasForeignKey("DocumentReferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eDrsDB.Models.Party", null)
                        .WithMany("ApplicationForms")
                        .HasForeignKey("PartyId");

                    b.HasOne("eDrsDB.Models.SupportingDocuments", null)
                        .WithMany("ApplicationForms")
                        .HasForeignKey("SupportingDocumentsSupportingDocumentId");

                    b.HasOne("eDrsDB.Models.TitleNumber", null)
                        .WithMany("ApplicationForms")
                        .HasForeignKey("TitleNumberId");
                });

            modelBuilder.Entity("eDrsDB.Models.Document", b =>
                {
                    b.HasOne("eDrsDB.Models.ApplicationForm", "ApplicationForm")
                        .WithMany()
                        .HasForeignKey("ApplicationFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eDrsDB.Models.DocumentReference", b =>
                {
                    b.HasOne("eDrsDB.Models.User", null)
                        .WithMany("DocumentReferences")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("eDrsDB.Models.Party", b =>
                {
                    b.HasOne("eDrsDB.Models.DocumentReference", "DocumentReference")
                        .WithMany("Parties")
                        .HasForeignKey("DocumentReferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eDrsDB.Models.SupportingDocuments", b =>
                {
                    b.HasOne("eDrsDB.Models.DocumentReference", "DocumentReference")
                        .WithMany("SupportingDocuments")
                        .HasForeignKey("DocumentReferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eDrsDB.Models.TitleNumber", b =>
                {
                    b.HasOne("eDrsDB.Models.DocumentReference", "DocumentReference")
                        .WithMany("Titles")
                        .HasForeignKey("DocumentReferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}