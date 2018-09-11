﻿// <auto-generated />
using CoreApp.Data.EF;
using CoreApp.Data.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CoreApp.Data.EF.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreApp.Data.Entities.Advertisement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdvertisementPositionId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<string>("Image")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<string>("PositionId");

                    b.Property<int>("SortOrder");

                    b.Property<int>("Status");

                    b.Property<string>("Url")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("AdvertisementPositionId");

                    b.ToTable("Advertisements");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.AdvertisementPage", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("AdvertisementPages");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.AdvertisementPosition", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20);

                    b.Property<string>("AdvertisementPageId");

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.Property<string>("PageId")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.HasIndex("AdvertisementPageId");

                    b.ToTable("AdvertisementPositions");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Announcement", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .HasMaxLength(250);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("Status");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<Guid>("UserId")
                        .HasMaxLength(450);

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Announcements");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.AnnouncementUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AnnouncementId")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<bool?>("HasRead");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("AnnouncementId");

                    b.ToTable("AnnouncementUsers");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.AppRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedName");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.AppUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Avatar");

                    b.Property<decimal>("Balance");

                    b.Property<DateTime?>("Birthday");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<int>("Status");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BillStatus");

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<Guid>("CustomerId");

                    b.Property<string>("CustomerMessage")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("CustomerMobile")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("PaymentMethod");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.BillDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BillId");

                    b.Property<int>("ColorId");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<int>("SizeId");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SizeId");

                    b.ToTable("BillDetails");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<bool?>("HomeFlag");

                    b.Property<bool?>("HotFlag");

                    b.Property<string>("Image")
                        .HasMaxLength(256);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("SeoAlias");

                    b.Property<string>("SeoDescription");

                    b.Property<string>("SeoKeywords");

                    b.Property<string>("SeoPageTitle");

                    b.Property<int>("Status");

                    b.Property<string>("Tags");

                    b.Property<int?>("ViewCount");

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.BlogTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255);

                    b.Property<int>("BlogId");

                    b.Property<string>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.HasIndex("TagId");

                    b.ToTable("BlogTags");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ColorCode")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Contact", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255);

                    b.Property<string>("Address")
                        .HasMaxLength(250);

                    b.Property<string>("Email")
                        .HasMaxLength(250);

                    b.Property<double?>("Lat");

                    b.Property<double?>("Long");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Other");

                    b.Property<string>("Phone")
                        .HasMaxLength(50);

                    b.Property<int>("Status");

                    b.Property<string>("Website")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Email")
                        .HasMaxLength(250);

                    b.Property<string>("Message")
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Footer", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Content")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Footers");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Function", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IconCss");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("ParentId")
                        .HasMaxLength(128);

                    b.Property<int>("SortOrder");

                    b.Property<int>("Status");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Functions");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Language", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDefault");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<string>("Resources");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255);

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("Content");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CanCreate");

                    b.Property<bool>("CanDelete");

                    b.Property<bool>("CanRead");

                    b.Property<bool>("CanUpdate");

                    b.Property<string>("FunctionId")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("FunctionId");

                    b.HasIndex("RoleId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<bool?>("HomeFlag");

                    b.Property<bool?>("HotFlag");

                    b.Property<string>("Image")
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<decimal>("OriginalPrice");

                    b.Property<decimal>("Price");

                    b.Property<decimal>("PromotionPrice");

                    b.Property<string>("SeoAlias")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("SeoDescription")
                        .HasMaxLength(255);

                    b.Property<string>("SeoKeywords")
                        .HasMaxLength(255);

                    b.Property<string>("SeoPageTitle");

                    b.Property<int>("Status");

                    b.Property<string>("Tags")
                        .HasMaxLength(255);

                    b.Property<string>("Unit");

                    b.Property<int?>("ViewCount");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("Description");

                    b.Property<bool?>("HomeFlag");

                    b.Property<int?>("HomeOrder");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<int?>("ParentId");

                    b.Property<string>("SeoAlias");

                    b.Property<string>("SeoDescription");

                    b.Property<string>("SeoKeywords");

                    b.Property<string>("SeoPageTitle");

                    b.Property<int>("SortOrder");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Caption")
                        .HasMaxLength(250);

                    b.Property<string>("Path")
                        .HasMaxLength(250);

                    b.Property<int>("ProductId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImages");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.ProductQuantity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ColorId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.Property<int>("SizeId");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SizeId");

                    b.ToTable("ProductQuantities");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.ProductTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ProductId");

                    b.Property<string>("TagId")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TagId");

                    b.ToTable("ProductTags");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Slide", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<string>("Description")
                        .HasMaxLength(250);

                    b.Property<int?>("DisplayOrder");

                    b.Property<string>("GroupAlias")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<bool>("Status");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Slides");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.SystemConfig", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(255);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128);

                    b.Property<int>("Status");

                    b.Property<string>("Value1");

                    b.Property<int?>("Value2");

                    b.Property<bool?>("Value3");

                    b.Property<decimal?>("Value4");

                    b.Property<DateTime?>("Value5");

                    b.HasKey("Id");

                    b.ToTable("SystemConfigs");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Tag", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.WholePrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FromQuantity");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductId");

                    b.Property<int>("ToQuantity");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("WholePrices");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("RoleId");

                    b.HasKey("Id");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("ProviderKey");

                    b.HasKey("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("UserId");

                    b.HasKey("RoleId", "UserId");

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Advertisement", b =>
                {
                    b.HasOne("CoreApp.Data.Entities.AdvertisementPosition")
                        .WithMany("Advertisements")
                        .HasForeignKey("AdvertisementPositionId");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.AdvertisementPosition", b =>
                {
                    b.HasOne("CoreApp.Data.Entities.AdvertisementPage", "AdvertisementPage")
                        .WithMany("AdvertisementPositions")
                        .HasForeignKey("AdvertisementPageId");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Announcement", b =>
                {
                    b.HasOne("CoreApp.Data.Entities.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreApp.Data.Entities.AnnouncementUser", b =>
                {
                    b.HasOne("CoreApp.Data.Entities.Announcement", "Announcement")
                        .WithMany("AnnouncementUsers")
                        .HasForeignKey("AnnouncementId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Bill", b =>
                {
                    b.HasOne("CoreApp.Data.Entities.AppUser", "User")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreApp.Data.Entities.BillDetail", b =>
                {
                    b.HasOne("CoreApp.Data.Entities.Bill", "Bill")
                        .WithMany("BillDetails")
                        .HasForeignKey("BillId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreApp.Data.Entities.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreApp.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreApp.Data.Entities.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreApp.Data.Entities.BlogTag", b =>
                {
                    b.HasOne("CoreApp.Data.Entities.Blog", "Blog")
                        .WithMany("BlogTags")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreApp.Data.Entities.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId");
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Permission", b =>
                {
                    b.HasOne("CoreApp.Data.Entities.Function", "Function")
                        .WithMany()
                        .HasForeignKey("FunctionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreApp.Data.Entities.AppRole", "AppRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreApp.Data.Entities.Product", b =>
                {
                    b.HasOne("CoreApp.Data.Entities.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreApp.Data.Entities.ProductImage", b =>
                {
                    b.HasOne("CoreApp.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreApp.Data.Entities.ProductQuantity", b =>
                {
                    b.HasOne("CoreApp.Data.Entities.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreApp.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreApp.Data.Entities.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreApp.Data.Entities.ProductTag", b =>
                {
                    b.HasOne("CoreApp.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CoreApp.Data.Entities.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreApp.Data.Entities.WholePrice", b =>
                {
                    b.HasOne("CoreApp.Data.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
