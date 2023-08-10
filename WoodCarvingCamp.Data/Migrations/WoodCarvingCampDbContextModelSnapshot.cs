﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WoodCarvingCamp.Data;

#nullable disable

namespace WoodCarvingCamp.Data.Migrations
{
    [DbContext(typeof(WoodCarvingCampDbContext))]
    partial class WoodCarvingCampDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CartItemShoppingCart", b =>
                {
                    b.Property<int>("CartItemsId")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("int");

                    b.HasKey("CartItemsId", "ShoppingCartId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("CartItemShoppingCart");
                });

            modelBuilder.Entity("CommentGalleryPhoto", b =>
                {
                    b.Property<int>("CommentsId")
                        .HasColumnType("int");

                    b.Property<int>("GalleryPhotosId")
                        .HasColumnType("int");

                    b.HasKey("CommentsId", "GalleryPhotosId");

                    b.HasIndex("GalleryPhotosId");

                    b.ToTable("CommentGalleryPhoto");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

                    b.ToTable("AspNetRoles", (string)null);
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

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
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

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

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

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShoppingCartId")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

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

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("f8a67313-d93c-417d-b6f1-3516c9344e0e"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "52c730c5-c396-4bdc-a7f9-471f0ac919c6",
                            Email = "admin@woodcarvingcamp.bg",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Adminov",
                            LockoutEnabled = false,
                            NormalizedEmail = "admin@woodcarvingcamp.bg",
                            NormalizedUserName = "admin@woodcarvingcamp.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEPSei9MiLXXJ1VWT/GDcVM5JalMSfYs4fETx0UGQHg1hCN9S5qqsHT84aHshnaNDqw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "0a64a102-2c20-4e86-8ad1-2427adb983f8",
                            TwoFactorEnabled = false,
                            UserName = "admin@woodcarvingcamp.bg"
                        },
                        new
                        {
                            Id = new Guid("dfc6ee85-e1cd-45d5-82b8-f5bbba23d087"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5d192385-ea84-4622-8b63-306cf3c2fe6a",
                            Email = "stefcho@abv.bg",
                            EmailConfirmed = false,
                            FirstName = "Stefcho",
                            LastName = "Stefanov",
                            LockoutEnabled = false,
                            NormalizedEmail = "stefcho@abv.bg",
                            NormalizedUserName = "stefcho@abv.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAECusDS7shjRFtEd6VyZEncr9V3OKfzPOgZaXQj2oHCvb1Iup5VObj2HjSWOn+enCpw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9c7145e5-d5a0-418c-a347-d7647153710c",
                            TwoFactorEnabled = false,
                            UserName = "stefcho@abv.bg"
                        });
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.CarvingCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<bool>("IsPaid")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("CarvingCourses");
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Carving Chisels"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Carving Knives"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Carving Gloves"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Sharpening & Accessories"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Carving Tools Storage"
                        });
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PhotoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<decimal>("DiscountPercent")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.GalleryPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("GalleryPhotos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9146),
                            Description = "Beautiful flower carved in wood.",
                            ImageUrl = "/images/GalleryImages/flower carved in wood.jpeg",
                            Title = "Beautiful flower carved in wood."
                        },
                        new
                        {
                            Id = 2,
                            CreatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9194),
                            Description = "Jesus Face - Just Extraordinary.",
                            ImageUrl = "/images/GalleryImages/Jesus Face.jpeg",
                            Title = "Jesus Face - Just Extraordinary."
                        },
                        new
                        {
                            Id = 3,
                            CreatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9198),
                            Description = "Owl - Amazing work.",
                            ImageUrl = "/images/GalleryImages/Owl.jpg",
                            Title = "Owl - Amazing work."
                        });
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PaymentStatus")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("TransactionId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9357),
                            Description = "Woodworking chisels range from small hand tools for tiny details, to large chisels used to remove big sections of wood, in 'roughing out' the shape of a pattern or design.",
                            ImageUrl = "/Images/ShopImages/Chisel one.jpg",
                            Name = "5 Piece - Set Starter - Carving Chisels",
                            Price = 49.99m,
                            UpdatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9362)
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9369),
                            Description = "Hook Carving Knife good for carcing spoons or making special details on your special projects",
                            ImageUrl = "/Images/ShopImages/Knife one.jpg",
                            Name = "Hook Carving Knife",
                            Price = 15.99m,
                            UpdatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9372)
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9375),
                            Description = "Set of four knife made to help you carve your perfect project!",
                            ImageUrl = "/Images/ShopImages/Knife two.jpg",
                            Name = "Hook Carving Knifes Set",
                            Price = 45.99m,
                            UpdatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9377)
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9381),
                            Description = "The one knife you need the most - the basic carving knife to start your journey!",
                            ImageUrl = "/Images/ShopImages/Knife three.jpg",
                            Name = "Carving Knife",
                            Price = 9.99m,
                            UpdatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9383)
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            CreatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9389),
                            Description = "Set of four knife made to help you carve your perfect project!",
                            ImageUrl = "/Images/ShopImages/Chisel two.jpg",
                            Name = "Small Carving Chisel For Wood Carving",
                            Price = 9.99m,
                            UpdatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9391)
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            CreatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9395),
                            Description = "Really good gloves to avoid accidentally cuts and injuries!",
                            ImageUrl = "/Images/ShopImages/Gloves one.jpg",
                            Name = "Level 6a Resistant Cut Gloves",
                            Price = 20.00m,
                            UpdatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9397)
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            CreatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9400),
                            Description = "Really good gloves to avoid accidentally cuts and injuries!",
                            ImageUrl = "/Images/ShopImages/Gloves two.jpg",
                            Name = "Wood Carving Gloves",
                            Price = 15.49m,
                            UpdatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9402)
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 5,
                            CreatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9405),
                            Description = "Tools storage to store your knifes, chisels and other accessories!",
                            ImageUrl = "/Images/ShopImages/Tools Storage.jpg",
                            Name = "Tools Storage",
                            Price = 30.49m,
                            UpdatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9407)
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 4,
                            CreatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9413),
                            Description = "Kepp your knifes sharp to make shure you have the perfect expirince while doing your projects!",
                            ImageUrl = "/Images/ShopImages/Sharpening stone.jpg",
                            Name = "Sharpening stone",
                            Price = 30.49m,
                            UpdatedOn = new DateTime(2023, 8, 10, 15, 56, 33, 843, DateTimeKind.Local).AddTicks(9415)
                        });
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid?>("UserId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("CartItemShoppingCart", b =>
                {
                    b.HasOne("WoodCarvingCamp.Data.Models.CartItem", null)
                        .WithMany()
                        .HasForeignKey("CartItemsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WoodCarvingCamp.Data.Models.ShoppingCart", null)
                        .WithMany()
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CommentGalleryPhoto", b =>
                {
                    b.HasOne("WoodCarvingCamp.Data.Models.Comment", null)
                        .WithMany()
                        .HasForeignKey("CommentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WoodCarvingCamp.Data.Models.GalleryPhoto", null)
                        .WithMany()
                        .HasForeignKey("GalleryPhotosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("WoodCarvingCamp.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("WoodCarvingCamp.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WoodCarvingCamp.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("WoodCarvingCamp.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.ApplicationUser", b =>
                {
                    b.HasOne("WoodCarvingCamp.Data.Models.ShoppingCart", "ShoppingCart")
                        .WithMany()
                        .HasForeignKey("ShoppingCartId");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.CartItem", b =>
                {
                    b.HasOne("WoodCarvingCamp.Data.Models.Order", null)
                        .WithMany("CartItems")
                        .HasForeignKey("OrderId");

                    b.HasOne("WoodCarvingCamp.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.CarvingCourse", b =>
                {
                    b.HasOne("WoodCarvingCamp.Data.Models.ApplicationUser", null)
                        .WithMany("CarvingCourses")
                        .HasForeignKey("ApplicationUserId");
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.Comment", b =>
                {
                    b.HasOne("WoodCarvingCamp.Data.Models.ApplicationUser", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.Order", b =>
                {
                    b.HasOne("WoodCarvingCamp.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.Product", b =>
                {
                    b.HasOne("WoodCarvingCamp.Data.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.ShoppingCart", b =>
                {
                    b.HasOne("WoodCarvingCamp.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("CarvingCourses");
                });

            modelBuilder.Entity("WoodCarvingCamp.Data.Models.Order", b =>
                {
                    b.Navigation("CartItems");
                });
#pragma warning restore 612, 618
        }
    }
}
