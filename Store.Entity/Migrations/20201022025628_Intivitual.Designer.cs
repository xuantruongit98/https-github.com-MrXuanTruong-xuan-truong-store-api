﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store.Entity;

namespace Store.Entity.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20201022025628_Intivitual")]
    partial class Intivitual
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Store.Entity.Domains.Account", b =>
                {
                    b.Property<long>("AccountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountTypeId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("AccountId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            AccountId = 1L,
                            Address = "Quận 9",
                            CreatedDate = new DateTime(2020, 10, 22, 2, 56, 27, 957, DateTimeKind.Utc).AddTicks(8351),
                            DateOfBirth = new DateTime(1991, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "xuantruongmu98@gmail.com",
                            FullName = "Admin",
                            Password = "e10adc3949ba59abbe56e057f20f883e",
                            Phone = "0345286525",
                            UpdatedDate = new DateTime(2020, 10, 22, 2, 56, 27, 958, DateTimeKind.Utc).AddTicks(351),
                            Username = "admin"
                        },
                        new
                        {
                            AccountId = 2L,
                            CreatedDate = new DateTime(2020, 10, 22, 2, 56, 27, 958, DateTimeKind.Utc).AddTicks(1801),
                            DateOfBirth = new DateTime(1991, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "locxtit1@gmail.com",
                            FullName = "locxtit",
                            Password = "e10adc3949ba59abbe56e057f20f883e",
                            Phone = "0986210955",
                            UpdatedDate = new DateTime(2020, 10, 22, 2, 56, 27, 958, DateTimeKind.Utc).AddTicks(1825),
                            Username = "locxtit"
                        });
                });

            modelBuilder.Entity("Store.Entity.Domains.AccountStatus", b =>
                {
                    b.Property<string>("AccountStatusId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AccountStatusName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AccountStatusId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("AccountStatuses");
                });

            modelBuilder.Entity("Store.Entity.Domains.AccountType", b =>
                {
                    b.Property<string>("AccountTypeId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AccountTypeName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AccountTypeId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("AccountTypes");
                });

            modelBuilder.Entity("Store.Entity.Domains.Branch", b =>
                {
                    b.Property<long>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("BranchName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BranchId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Store.Entity.Domains.BranchType", b =>
                {
                    b.Property<long>("BranchTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BranchTypeName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BranchTypeId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("BranchTypes");
                });

            modelBuilder.Entity("Store.Entity.Domains.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CategoryId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Store.Entity.Domains.District", b =>
                {
                    b.Property<long>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DistrictName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DistrictId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("Store.Entity.Domains.Order", b =>
                {
                    b.Property<long>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalAmount")
                        .HasColumnType("float");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Store.Entity.Domains.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2")
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasMaxLength(50);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Stock")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ViewCount")
                        .HasColumnType("int")
                        .HasMaxLength(100);

                    b.HasKey("ProductId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Store.Entity.Domains.ProductBranch", b =>
                {
                    b.Property<int>("ProductBranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductBranchId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("ProductBranches");
                });

            modelBuilder.Entity("Store.Entity.Domains.ProductColor", b =>
                {
                    b.Property<int>("ProductColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasMaxLength(50);

                    b.Property<string>("ProductColorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductColorId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("ProductColors");
                });

            modelBuilder.Entity("Store.Entity.Domains.ProductImage", b =>
                {
                    b.Property<int>("ProductImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductId")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ProductImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductImageId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("Store.Entity.Domains.Province", b =>
                {
                    b.Property<long>("ProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProvinceName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<long?>("UpdatedBy")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProvinceId");

                    b.HasIndex("CreatedBy");

                    b.HasIndex("UpdatedBy");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("Store.Entity.Domains.Account", b =>
                {
                    b.HasOne("Store.Entity.Domains.Account", "CreatedProduct")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Store.Entity.Domains.Account", "UpdatedAccount")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("Store.Entity.Domains.AccountStatus", b =>
                {
                    b.HasOne("Store.Entity.Domains.Account", "CreatedProduct")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Store.Entity.Domains.Account", "UpdatedAccount")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("Store.Entity.Domains.AccountType", b =>
                {
                    b.HasOne("Store.Entity.Domains.Account", "CreatedProduct")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Store.Entity.Domains.Account", "UpdatedAccount")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("Store.Entity.Domains.Branch", b =>
                {
                    b.HasOne("Store.Entity.Domains.Account", "CreatedProduct")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Store.Entity.Domains.Account", "UpdatedAccount")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("Store.Entity.Domains.BranchType", b =>
                {
                    b.HasOne("Store.Entity.Domains.Account", "CreatedProduct")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Store.Entity.Domains.Account", "UpdatedAccount")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("Store.Entity.Domains.Category", b =>
                {
                    b.HasOne("Store.Entity.Domains.Account", "CreatedProduct")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Store.Entity.Domains.Account", "UpdatedAccount")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("Store.Entity.Domains.District", b =>
                {
                    b.HasOne("Store.Entity.Domains.Account", "CreatedProduct")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Store.Entity.Domains.Account", "UpdatedAccount")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("Store.Entity.Domains.Order", b =>
                {
                    b.HasOne("Store.Entity.Domains.Account", "CreatedProduct")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Store.Entity.Domains.Account", "UpdatedAccount")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("Store.Entity.Domains.Product", b =>
                {
                    b.HasOne("Store.Entity.Domains.Account", "CreatedProduct")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Store.Entity.Domains.Account", "UpdatedAccount")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("Store.Entity.Domains.ProductBranch", b =>
                {
                    b.HasOne("Store.Entity.Domains.Account", "CreatedProduct")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Store.Entity.Domains.Account", "UpdatedAccount")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("Store.Entity.Domains.ProductColor", b =>
                {
                    b.HasOne("Store.Entity.Domains.Account", "CreatedProduct")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Store.Entity.Domains.Account", "UpdatedAccount")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("Store.Entity.Domains.ProductImage", b =>
                {
                    b.HasOne("Store.Entity.Domains.Account", "CreatedProduct")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Store.Entity.Domains.Account", "UpdatedAccount")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });

            modelBuilder.Entity("Store.Entity.Domains.Province", b =>
                {
                    b.HasOne("Store.Entity.Domains.Account", "CreatedProduct")
                        .WithMany()
                        .HasForeignKey("CreatedBy");

                    b.HasOne("Store.Entity.Domains.Account", "UpdatedAccount")
                        .WithMany()
                        .HasForeignKey("UpdatedBy");
                });
#pragma warning restore 612, 618
        }
    }
}
