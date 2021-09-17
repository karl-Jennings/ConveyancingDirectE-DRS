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
    [Migration("20210409072030_v2")]
    partial class v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eDrsDB.Models.Address", b =>
                {
                    b.Property<long>("AddressId")
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

                    b.Property<string>("DxExchange")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DxNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("PartyId")
                        .HasColumnType("bigint");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.HasIndex("PartyId");

                    b.ToTable("Addresses");
                });

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

                    b.Property<bool>("IsChecked")
                        .HasColumnType("bit");

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

                    b.Property<long>("AttachmentId")
                        .HasColumnType("bigint");

                    b.Property<string>("Base64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileExtension")
                        .IsRequired()
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

                    b.Property<bool>("IsApiSuccess")
                        .HasColumnType("bit");

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
                            UpdatedDate = new DateTime(2021, 4, 9, 12, 50, 29, 822, DateTimeKind.Local).AddTicks(1087),
                            Url = "transfer-and-charge"
                        },
                        new
                        {
                            RegistrationTypeId = 2L,
                            Status = true,
                            TypeCode = "rem_gage",
                            TypeName = "Remortgage",
                            UpdatedDate = new DateTime(2021, 4, 9, 12, 50, 29, 823, DateTimeKind.Local).AddTicks(185),
                            Url = "remortgage"
                        },
                        new
                        {
                            RegistrationTypeId = 3L,
                            Status = true,
                            TypeCode = "trns_eqty",
                            TypeName = "Transfer of equity",
                            UpdatedDate = new DateTime(2021, 4, 9, 12, 50, 29, 823, DateTimeKind.Local).AddTicks(211),
                            Url = "transfer-equity"
                        },
                        new
                        {
                            RegistrationTypeId = 4L,
                            Status = true,
                            TypeCode = "rem_frm",
                            TypeName = "Restriction, hostile takeover",
                            UpdatedDate = new DateTime(2021, 4, 9, 12, 50, 29, 823, DateTimeKind.Local).AddTicks(214),
                            Url = "removal-form"
                        },
                        new
                        {
                            RegistrationTypeId = 5L,
                            Status = true,
                            TypeCode = "chngName",
                            TypeName = "Change of name",
                            UpdatedDate = new DateTime(2021, 4, 9, 12, 50, 29, 823, DateTimeKind.Local).AddTicks(216),
                            Url = "change-name"
                        },
                        new
                        {
                            RegistrationTypeId = 6L,
                            Status = true,
                            TypeCode = "dispositionary",
                            TypeName = "Dispositionary first lease",
                            UpdatedDate = new DateTime(2021, 4, 9, 12, 50, 29, 823, DateTimeKind.Local).AddTicks(219),
                            Url = "dispositionary"
                        },
                        new
                        {
                            RegistrationTypeId = 7L,
                            Status = true,
                            TypeCode = "transfer",
                            TypeName = "Transfer of part",
                            UpdatedDate = new DateTime(2021, 4, 9, 12, 50, 29, 823, DateTimeKind.Local).AddTicks(220),
                            Url = "transfer"
                        },
                        new
                        {
                            RegistrationTypeId = 8L,
                            Status = true,
                            TypeCode = "lease_ext",
                            TypeName = "Lease extension",
                            UpdatedDate = new DateTime(2021, 4, 9, 12, 50, 29, 823, DateTimeKind.Local).AddTicks(221),
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

                    b.Property<string>("DxNumber")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<string>("Base64")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertifiedCopy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DocumentId")
                        .HasColumnType("bigint");

                    b.Property<string>("DocumentName")
                        .IsRequired()
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

                    b.Property<bool>("IsChecked")
                        .HasColumnType("bit");

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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(350)")
                        .HasMaxLength(350);

                    b.Property<string>("Firstname")
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
                            Email = "it@cdpll.co.uk",
                            Firstname = "Admin",
                            PasswordHash = new byte[] { 45, 152, 96, 208, 174, 242, 9, 227, 178, 116, 64, 114, 6, 222, 70, 136, 135, 75, 1, 232, 236, 80, 154, 157, 66, 126, 114, 129, 141, 149, 58, 127, 246, 206, 74, 81, 207, 83, 81, 224, 252, 173, 47, 8, 84, 226, 32, 3, 141, 9, 88, 186, 242, 75, 189, 213, 238, 194, 13, 99, 98, 165, 25, 205 },
                            PasswordSalt = new byte[] { 14, 217, 187, 86, 204, 190, 31, 100, 186, 189, 1, 20, 228, 51, 35, 151, 2, 98, 198, 191, 190, 2, 96, 211, 48, 111, 133, 103, 195, 24, 9, 79, 66, 192, 12, 91, 227, 87, 126, 233, 220, 15, 252, 122, 82, 79, 31, 43, 56, 237, 25, 32, 48, 189, 174, 3, 206, 39, 247, 37, 118, 129, 74, 200, 98, 98, 4, 176, 129, 46, 232, 229, 31, 224, 35, 85, 75, 136, 7, 185, 187, 205, 77, 167, 127, 156, 32, 174, 82, 197, 203, 192, 224, 125, 100, 103, 119, 58, 1, 57, 169, 191, 39, 24, 20, 182, 189, 30, 93, 104, 113, 130, 144, 84, 250, 60, 66, 127, 233, 231, 109, 246, 251, 196, 104, 5, 117, 130 },
                            Status = true,
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Username = "edrs-admin"
                        });
                });

            modelBuilder.Entity("eDrsDB.Models.Address", b =>
                {
                    b.HasOne("eDrsDB.Models.Party", "Party")
                        .WithMany("Addresses")
                        .HasForeignKey("PartyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrsDB.Models.ApplicationForm", b =>
                {
                    b.HasOne("eDrsDB.Models.DocumentReference", "DocumentReference")
                        .WithMany("Applications")
                        .HasForeignKey("DocumentReferenceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrsDB.Models.Document", b =>
                {
                    b.HasOne("eDrsDB.Models.ApplicationForm", "ApplicationForm")
                        .WithOne("Document")
                        .HasForeignKey("eDrsDB.Models.Document", "ApplicationFormId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrsDB.Models.DocumentReference", b =>
                {
                    b.HasOne("eDrsDB.Models.RegistrationType", "RegistrationType")
                        .WithMany()
                        .HasForeignKey("RegistrationTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eDrsDB.Models.User", "User")
                        .WithMany("DocumentReferences")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrsDB.Models.Outstanding", b =>
                {
                    b.HasOne("eDrsDB.Models.DocumentReference", "DocumentReference")
                        .WithMany("Outstanding")
                        .HasForeignKey("DocumentReferenceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrsDB.Models.Party", b =>
                {
                    b.HasOne("eDrsDB.Models.DocumentReference", "DocumentReference")
                        .WithMany("Parties")
                        .HasForeignKey("DocumentReferenceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrsDB.Models.Representation", b =>
                {
                    b.HasOne("eDrsDB.Models.DocumentReference", "DocumentReference")
                        .WithMany("Representations")
                        .HasForeignKey("DocumentReferenceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrsDB.Models.RequestLog", b =>
                {
                    b.HasOne("eDrsDB.Models.DocumentReference", "DocumentReference")
                        .WithMany("RequestLogs")
                        .HasForeignKey("DocumentReferenceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrsDB.Models.SupportingDocuments", b =>
                {
                    b.HasOne("eDrsDB.Models.DocumentReference", "DocumentReference")
                        .WithMany("SupportingDocuments")
                        .HasForeignKey("DocumentReferenceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrsDB.Models.TitleNumber", b =>
                {
                    b.HasOne("eDrsDB.Models.DocumentReference", "DocumentReference")
                        .WithMany("Titles")
                        .HasForeignKey("DocumentReferenceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
