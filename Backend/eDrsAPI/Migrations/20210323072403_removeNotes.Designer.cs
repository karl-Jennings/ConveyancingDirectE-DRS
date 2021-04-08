﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eDrsDB.Data;

namespace eDrsAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210323072403_removeNotes")]
    partial class removeNotes
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

                    b.Property<string>("CertifiedCopy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ChargeDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("DocumentReferenceId")
                        .HasColumnType("bigint");

                    b.Property<string>("ExternalReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FeeInPence")
                        .HasColumnType("int");

                    b.Property<string>("IsMdRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MdRef")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<string>("SortCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Variety")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicationFormId");

                    b.HasIndex("DocumentReferenceId");

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

                    b.Property<string>("Base64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocumentId");

                    b.HasIndex("ApplicationFormId")
                        .IsUnique();

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

                    b.Property<string>("AdditionalProviderFilter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationAffects")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ApplicationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("DisclosableOveridingInterests")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocalAuthority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostcodeOfProperty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RegistrationTypeId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<long>("TelephoneNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("TotalFeeInPence")
                        .HasColumnType("int");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("DocumentReferenceId");

                    b.HasIndex("RegistrationTypeId");

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

            modelBuilder.Entity("eDrsDB.Models.LrCredential", b =>
                {
                    b.Property<long>("LrCredentialsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LrCredentialsId");

                    b.ToTable("LrCredentials");

                    b.HasData(
                        new
                        {
                            LrCredentialsId = 1L,
                            Password = "landreg001",
                            Username = "BGUser001"
                        });
                });

            modelBuilder.Entity("eDrsDB.Models.Outstanding", b =>
                {
                    b.Property<long>("OutstandingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("DocumentReferenceId")
                        .HasColumnType("bigint");

                    b.Property<string>("LandRegistryId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("NewResponse")
                        .HasColumnType("bit");

                    b.Property<string>("ServiceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeCode")
                        .HasColumnType("int");

                    b.HasKey("OutstandingId");

                    b.HasIndex("DocumentReferenceId");

                    b.ToTable("Outstanding");
                });

            modelBuilder.Entity("eDrsDB.Models.Party", b =>
                {
                    b.Property<long>("PartyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressForService")
                        .HasColumnType("nvarchar(max)");

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
                            TypeCode = "trns_chrge",
                            TypeName = "Transfer and charge",
                            UpdatedDate = new DateTime(2021, 3, 23, 12, 54, 3, 91, DateTimeKind.Local).AddTicks(7211),
                            Url = "transfer-and-charge"
                        },
                        new
                        {
                            RegistrationTypeId = 2L,
                            Status = true,
                            TypeCode = "rem_gage",
                            TypeName = "Remortgage",
                            UpdatedDate = new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6138),
                            Url = "remortgage"
                        },
                        new
                        {
                            RegistrationTypeId = 3L,
                            Status = true,
                            TypeCode = "trns_eqty",
                            TypeName = "Transfer of equity",
                            UpdatedDate = new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6161),
                            Url = "transfer-equity"
                        },
                        new
                        {
                            RegistrationTypeId = 4L,
                            Status = true,
                            TypeCode = "rem_frm",
                            TypeName = "Restriction, hostile takeover",
                            UpdatedDate = new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6164),
                            Url = "removal-form"
                        },
                        new
                        {
                            RegistrationTypeId = 5L,
                            Status = true,
                            TypeCode = "chngName",
                            TypeName = "Change of name",
                            UpdatedDate = new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6165),
                            Url = "change-name"
                        },
                        new
                        {
                            RegistrationTypeId = 6L,
                            Status = true,
                            TypeCode = "dispositionary",
                            TypeName = "Dispositionary first lease",
                            UpdatedDate = new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6167),
                            Url = "dispositionary"
                        },
                        new
                        {
                            RegistrationTypeId = 7L,
                            Status = true,
                            TypeCode = "transfer",
                            TypeName = "Transfer of part",
                            UpdatedDate = new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6169),
                            Url = "transfer"
                        },
                        new
                        {
                            RegistrationTypeId = 8L,
                            Status = true,
                            TypeCode = "lease_ext",
                            TypeName = "Lease extension",
                            UpdatedDate = new DateTime(2021, 3, 23, 12, 54, 3, 92, DateTimeKind.Local).AddTicks(6170),
                            Url = "lease-extension"
                        });
                });

            modelBuilder.Entity("eDrsDB.Models.Representation", b =>
                {
                    b.Property<long>("RepresentationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CareOfName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CareOfReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DocumentReferenceId")
                        .HasColumnType("bigint");

                    b.Property<string>("DxExchange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DxNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RepresentativeId")
                        .HasColumnType("bigint");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RepresentationId");

                    b.HasIndex("DocumentReferenceId");

                    b.ToTable("Representations");
                });

            modelBuilder.Entity("eDrsDB.Models.RequestLog", b =>
                {
                    b.Property<long>("RequestLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppMessageId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AttachmentId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DocumentReferenceId")
                        .HasColumnType("bigint");

                    b.Property<string>("File")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RejectionReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponseJson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ResponseType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValidationErrors")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequestLogId");

                    b.HasIndex("DocumentReferenceId");

                    b.ToTable("RequestLogs");
                });

            modelBuilder.Entity("eDrsDB.Models.SupportingDocuments", b =>
                {
                    b.Property<long>("SupportingDocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalProviderFilter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationMessageId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationService")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Base64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertifiedCopy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DocumentId")
                        .HasColumnType("bigint");

                    b.Property<string>("DocumentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DocumentReferenceId")
                        .HasColumnType("bigint");

                    b.Property<string>("DocumentType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("MessageId")
                        .HasColumnType("bigint");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("LesseeTitleNumber")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

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
                            PasswordHash = new byte[] { 64, 179, 175, 142, 224, 85, 77, 242, 120, 24, 149, 51, 37, 206, 47, 65, 223, 96, 8, 153, 220, 243, 16, 228, 131, 162, 197, 60, 54, 231, 204, 35, 205, 84, 19, 141, 98, 83, 138, 18, 247, 121, 36, 43, 21, 35, 181, 38, 228, 231, 152, 223, 96, 179, 17, 35, 206, 135, 14, 251, 162, 71, 254, 251 },
                            PasswordSalt = new byte[] { 22, 106, 186, 162, 90, 181, 202, 213, 36, 235, 74, 205, 113, 230, 145, 6, 130, 115, 112, 190, 142, 167, 105, 72, 215, 107, 199, 113, 98, 121, 84, 26, 5, 102, 24, 12, 34, 151, 122, 148, 172, 148, 232, 129, 234, 125, 94, 30, 89, 159, 227, 177, 31, 237, 28, 66, 157, 59, 194, 101, 221, 17, 9, 206, 221, 76, 16, 73, 235, 158, 224, 171, 93, 59, 58, 155, 137, 236, 144, 24, 83, 100, 82, 109, 140, 202, 219, 236, 103, 199, 219, 143, 146, 34, 91, 193, 255, 9, 122, 185, 175, 200, 103, 118, 80, 120, 113, 201, 122, 17, 160, 197, 190, 57, 158, 156, 222, 219, 171, 144, 78, 237, 237, 16, 65, 22, 181, 102 },
                            Status = true,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Username = "edrs-admin"
                        });
                });

            modelBuilder.Entity("eDrsDB.Models.ApplicationForm", b =>
                {
                    b.HasOne("eDrsDB.Models.DocumentReference", "DocumentReference")
                        .WithMany("Applications")
                        .HasForeignKey("DocumentReferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eDrsDB.Models.Document", b =>
                {
                    b.HasOne("eDrsDB.Models.ApplicationForm", "ApplicationForm")
                        .WithOne("Document")
                        .HasForeignKey("eDrsDB.Models.Document", "ApplicationFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eDrsDB.Models.DocumentReference", b =>
                {
                    b.HasOne("eDrsDB.Models.RegistrationType", "RegistrationType")
                        .WithMany()
                        .HasForeignKey("RegistrationTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eDrsDB.Models.User", "User")
                        .WithMany("DocumentReferences")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eDrsDB.Models.Outstanding", b =>
                {
                    b.HasOne("eDrsDB.Models.DocumentReference", "DocumentReference")
                        .WithMany("Outstanding")
                        .HasForeignKey("DocumentReferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eDrsDB.Models.Party", b =>
                {
                    b.HasOne("eDrsDB.Models.DocumentReference", "DocumentReference")
                        .WithMany("Parties")
                        .HasForeignKey("DocumentReferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eDrsDB.Models.Representation", b =>
                {
                    b.HasOne("eDrsDB.Models.DocumentReference", "DocumentReference")
                        .WithMany("Representations")
                        .HasForeignKey("DocumentReferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eDrsDB.Models.RequestLog", b =>
                {
                    b.HasOne("eDrsDB.Models.DocumentReference", "DocumentReference")
                        .WithMany("RequestLogs")
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