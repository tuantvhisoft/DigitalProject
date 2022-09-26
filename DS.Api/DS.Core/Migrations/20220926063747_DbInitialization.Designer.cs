﻿// <auto-generated />
using System;
using DS.Core.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DS.Core.Migrations
{
    [DbContext(typeof(DsDbContext))]
    [Migration("20220926063747_DbInitialization")]
    partial class DbInitialization
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DS.Core.Entity.Document", b =>
                {
                    b.Property<int>("DocID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocID"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DocumentTypeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("FileExtension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<bool>("IsInternal")
                        .HasColumnType("bit");

                    b.Property<string>("NameFile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("StartDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusID")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocID");

                    b.HasIndex("DocumentTypeId");

                    b.HasIndex("StatusID");

                    b.ToTable("Documents", (string)null);
                });

            modelBuilder.Entity("DS.Core.Entity.DocumentType", b =>
                {
                    b.Property<int>("DocumentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DocumentTypeId"), 1L, 1);

                    b.Property<string>("DocumentTypeName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Temple")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("DocumentTypeId");

                    b.ToTable("DocumentTypes", (string)null);
                });

            modelBuilder.Entity("DS.Core.Entity.ExternalSigner", b =>
                {
                    b.Property<int>("ExternalSignerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ExternalSignerId"), 1L, 1);

                    b.Property<string>("CerNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DocumentID")
                        .HasColumnType("int");

                    b.Property<float>("ExHeight")
                        .HasColumnType("real");

                    b.Property<float>("ExWidth")
                        .HasColumnType("real");

                    b.Property<float>("ExXsignPos")
                        .HasColumnType("real");

                    b.Property<float>("ExYsignPos")
                        .HasColumnType("real");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ValidDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ExternalSignerId");

                    b.HasIndex("DocumentID");

                    b.ToTable("ExternalSigners");
                });

            modelBuilder.Entity("DS.Core.Entity.HsmExpireTime", b =>
                {
                    b.Property<int>("HsmExpireTimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HsmExpireTimeId"), 1L, 1);

                    b.Property<DateTime>("FromDateGet")
                        .HasColumnType("datetime2");

                    b.Property<int>("HsmInId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ToDateExpire")
                        .HasColumnType("datetime2");

                    b.HasKey("HsmExpireTimeId");

                    b.HasIndex("HsmInId");

                    b.ToTable("HsmExpireTimes", (string)null);
                });

            modelBuilder.Entity("DS.Core.Entity.HsmInformation", b =>
                {
                    b.Property<int>("HsmInId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HsmInId"), 1L, 1);

                    b.Property<string>("IdentityCard")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("TokenHsm")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("HsmInId");

                    b.HasIndex("UserId");

                    b.ToTable("HsmInformations", (string)null);
                });

            modelBuilder.Entity("DS.Core.Entity.InitialDetail", b =>
                {
                    b.Property<int>("InitialDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InitialDetailId"), 1L, 1);

                    b.Property<string>("DetailStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InitialSignerId")
                        .HasColumnType("int");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("InitialDetailId");

                    b.HasIndex("InitialSignerId");

                    b.HasIndex("UserId");

                    b.ToTable("InitialDetails", (string)null);
                });

            modelBuilder.Entity("DS.Core.Entity.InitialSigner", b =>
                {
                    b.Property<int>("InitialSignerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InitialSignerId"), 1L, 1);

                    b.Property<string>("InSignerStatus")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("InitialSignerId");

                    b.ToTable("InitialSigners", (string)null);
                });

            modelBuilder.Entity("DS.Core.Entity.Role", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles", (string)null);
                });

            modelBuilder.Entity("DS.Core.Entity.Signer", b =>
                {
                    b.Property<int>("SignerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SignerId"), 1L, 1);

                    b.Property<int>("DocumentId")
                        .HasColumnType("int");

                    b.Property<float>("InHeight")
                        .HasColumnType("real");

                    b.Property<float>("InWidth")
                        .HasColumnType("real");

                    b.Property<float>("InXsignPos")
                        .HasColumnType("real");

                    b.Property<float>("InYsignPos")
                        .HasColumnType("real");

                    b.Property<int>("InitialSignerId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SignerId");

                    b.HasIndex("DocumentId");

                    b.HasIndex("InitialSignerId")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Signers", (string)null);
                });

            modelBuilder.Entity("DS.Core.Entity.SignerDocType", b =>
                {
                    b.Property<int>("SignerDocTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SignerDocTypeId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DocumentTypeId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("SignerDocTypeId");

                    b.HasIndex("DocumentTypeId");

                    b.HasIndex("UserId");

                    b.ToTable("SignerDocTypes", (string)null);
                });

            modelBuilder.Entity("DS.Core.Entity.Status", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatusID"), 1L, 1);

                    b.Property<string>("StatusName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("StatusID");

                    b.ToTable("Status", (string)null);
                });

            modelBuilder.Entity("DS.Core.Entity.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxCode")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppEmpLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("AppEmpTokens", (string)null);
                });

            modelBuilder.Entity("DS.Core.Entity.Document", b =>
                {
                    b.HasOne("DS.Core.Entity.DocumentType", "DocumentType")
                        .WithMany("Document")
                        .HasForeignKey("DocumentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DS.Core.Entity.Status", "Status")
                        .WithMany("Document")
                        .HasForeignKey("StatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DocumentType");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("DS.Core.Entity.ExternalSigner", b =>
                {
                    b.HasOne("DS.Core.Entity.Document", null)
                        .WithMany("ExternalSingers")
                        .HasForeignKey("DocumentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DS.Core.Entity.HsmExpireTime", b =>
                {
                    b.HasOne("DS.Core.Entity.HsmInformation", "HsmInformation")
                        .WithMany("HsmExpireTimes")
                        .HasForeignKey("HsmInId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HsmInformation");
                });

            modelBuilder.Entity("DS.Core.Entity.HsmInformation", b =>
                {
                    b.HasOne("DS.Core.Entity.User", "User")
                        .WithMany("HsmInformation")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DS.Core.Entity.InitialDetail", b =>
                {
                    b.HasOne("DS.Core.Entity.InitialSigner", "InitialSigner")
                        .WithMany("InitialDetails")
                        .HasForeignKey("InitialSignerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DS.Core.Entity.User", "User")
                        .WithMany("InitialDetails")
                        .HasForeignKey("UserId");

                    b.Navigation("InitialSigner");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DS.Core.Entity.Signer", b =>
                {
                    b.HasOne("DS.Core.Entity.Document", "Document")
                        .WithMany("Signers")
                        .HasForeignKey("DocumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DS.Core.Entity.InitialSigner", "InitialSigner")
                        .WithOne("Signer")
                        .HasForeignKey("DS.Core.Entity.Signer", "InitialSignerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DS.Core.Entity.User", "User")
                        .WithMany("Signers")
                        .HasForeignKey("UserId");

                    b.Navigation("Document");

                    b.Navigation("InitialSigner");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DS.Core.Entity.SignerDocType", b =>
                {
                    b.HasOne("DS.Core.Entity.DocumentType", "DocumentType")
                        .WithMany("SignerDocTypes")
                        .HasForeignKey("DocumentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DS.Core.Entity.User", "User")
                        .WithMany("SignerDocTypes")
                        .HasForeignKey("UserId");

                    b.Navigation("DocumentType");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DS.Core.Entity.Document", b =>
                {
                    b.Navigation("ExternalSingers");

                    b.Navigation("Signers");
                });

            modelBuilder.Entity("DS.Core.Entity.DocumentType", b =>
                {
                    b.Navigation("Document");

                    b.Navigation("SignerDocTypes");
                });

            modelBuilder.Entity("DS.Core.Entity.HsmInformation", b =>
                {
                    b.Navigation("HsmExpireTimes");
                });

            modelBuilder.Entity("DS.Core.Entity.InitialSigner", b =>
                {
                    b.Navigation("InitialDetails");

                    b.Navigation("Signer");
                });

            modelBuilder.Entity("DS.Core.Entity.Status", b =>
                {
                    b.Navigation("Document");
                });

            modelBuilder.Entity("DS.Core.Entity.User", b =>
                {
                    b.Navigation("HsmInformation");

                    b.Navigation("InitialDetails");

                    b.Navigation("SignerDocTypes");

                    b.Navigation("Signers");
                });
#pragma warning restore 612, 618
        }
    }
}
