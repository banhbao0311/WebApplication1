﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Data;

#nullable disable

namespace WebApplication1.Migrations
{
    [DbContext(typeof(DecorVistaDbContext))]
    partial class DecorVistaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DecorVista.Domain.Blog", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("images")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("interior_designer_id")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("interior_designer_id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("DecorVista.Domain.Cart", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int>("quanity")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("product_id");

                    b.HasIndex("user_id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("DecorVista.Domain.Consultation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("designer_id")
                        .HasColumnType("int");

                    b.Property<string>("notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("scheduled_datetime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("designer_id");

                    b.HasIndex("user_id");

                    b.ToTable("Consultations");
                });

            modelBuilder.Entity("DecorVista.Domain.Functionality", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Functionalities");
                });

            modelBuilder.Entity("DecorVista.Domain.Gallery", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gallery_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("room_type_id")
                        .HasColumnType("int");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("room_type_id");

                    b.ToTable("Galleries");
                });

            modelBuilder.Entity("DecorVista.Domain.GalleryDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("gallery_id")
                        .HasColumnType("int");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("gallery_id");

                    b.HasIndex("product_id");

                    b.ToTable("GalleryDetails");
                });

            modelBuilder.Entity("DecorVista.Domain.InteriorDesigner", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("daywork")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("portfolio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.Property<string>("yearsofexperience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("user_id")
                        .IsUnique();

                    b.ToTable("InteriorDesigners");
                });

            modelBuilder.Entity("DecorVista.Domain.Order", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("total")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("DecorVista.Domain.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("functionality_id")
                        .HasColumnType("int");

                    b.Property<string>("imageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("price")
                        .HasColumnType("real");

                    b.Property<string>("product_code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.HasIndex("functionality_id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("DecorVista.Domain.Review", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("designer_id")
                        .HasColumnType("int");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("designer_id");

                    b.HasIndex("product_id");

                    b.HasIndex("user_id");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("DecorVista.Domain.RoomType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("DecorVista.Domain.Subcribe", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("gallery_id")
                        .HasColumnType("int");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("gallery_id");

                    b.HasIndex("user_id");

                    b.ToTable("Subcribes");
                });

            modelBuilder.Entity("DecorVista.Domain.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DecorVista.Domain.UserDetails", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id")
                        .IsUnique();

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("DecorVista.Domain.Blog", b =>
                {
                    b.HasOne("DecorVista.Domain.InteriorDesigner", "interior_designer")
                        .WithMany("blogs")
                        .HasForeignKey("interior_designer_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("interior_designer");
                });

            modelBuilder.Entity("DecorVista.Domain.Cart", b =>
                {
                    b.HasOne("DecorVista.Domain.Product", "product")
                        .WithMany("carts")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DecorVista.Domain.User", "user")
                        .WithMany("carts")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("product");

                    b.Navigation("user");
                });

            modelBuilder.Entity("DecorVista.Domain.Consultation", b =>
                {
                    b.HasOne("DecorVista.Domain.InteriorDesigner", "interior_designer")
                        .WithMany("consultations")
                        .HasForeignKey("designer_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DecorVista.Domain.User", "user")
                        .WithMany("consultations")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("interior_designer");

                    b.Navigation("user");
                });

            modelBuilder.Entity("DecorVista.Domain.Gallery", b =>
                {
                    b.HasOne("DecorVista.Domain.RoomType", "room_type")
                        .WithMany("galleries")
                        .HasForeignKey("room_type_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("room_type");
                });

            modelBuilder.Entity("DecorVista.Domain.GalleryDetails", b =>
                {
                    b.HasOne("DecorVista.Domain.Gallery", "gallery")
                        .WithMany("galleryDetails")
                        .HasForeignKey("gallery_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DecorVista.Domain.Product", "product")
                        .WithMany("galleryDetails")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("gallery");

                    b.Navigation("product");
                });

            modelBuilder.Entity("DecorVista.Domain.InteriorDesigner", b =>
                {
                    b.HasOne("DecorVista.Domain.User", "user")
                        .WithOne("interiordesigner")
                        .HasForeignKey("DecorVista.Domain.InteriorDesigner", "user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("DecorVista.Domain.Order", b =>
                {
                    b.HasOne("DecorVista.Domain.User", "user")
                        .WithMany("orders")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("DecorVista.Domain.Product", b =>
                {
                    b.HasOne("DecorVista.Domain.Functionality", "functionality")
                        .WithMany("products")
                        .HasForeignKey("functionality_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("functionality");
                });

            modelBuilder.Entity("DecorVista.Domain.Review", b =>
                {
                    b.HasOne("DecorVista.Domain.InteriorDesigner", "interiordesigner")
                        .WithMany("reviews")
                        .HasForeignKey("designer_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DecorVista.Domain.Product", "product")
                        .WithMany("reviews")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DecorVista.Domain.User", "user")
                        .WithMany("reviews")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("interiordesigner");

                    b.Navigation("product");

                    b.Navigation("user");
                });

            modelBuilder.Entity("DecorVista.Domain.Subcribe", b =>
                {
                    b.HasOne("DecorVista.Domain.Gallery", "gallery")
                        .WithMany("subcribes")
                        .HasForeignKey("gallery_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("DecorVista.Domain.User", "user")
                        .WithMany("subcribes")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("gallery");

                    b.Navigation("user");
                });

            modelBuilder.Entity("DecorVista.Domain.UserDetails", b =>
                {
                    b.HasOne("DecorVista.Domain.User", "User")
                        .WithOne("userdetails")
                        .HasForeignKey("DecorVista.Domain.UserDetails", "user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DecorVista.Domain.Functionality", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("DecorVista.Domain.Gallery", b =>
                {
                    b.Navigation("galleryDetails");

                    b.Navigation("subcribes");
                });

            modelBuilder.Entity("DecorVista.Domain.InteriorDesigner", b =>
                {
                    b.Navigation("blogs");

                    b.Navigation("consultations");

                    b.Navigation("reviews");
                });

            modelBuilder.Entity("DecorVista.Domain.Product", b =>
                {
                    b.Navigation("carts");

                    b.Navigation("galleryDetails");

                    b.Navigation("reviews");
                });

            modelBuilder.Entity("DecorVista.Domain.RoomType", b =>
                {
                    b.Navigation("galleries");
                });

            modelBuilder.Entity("DecorVista.Domain.User", b =>
                {
                    b.Navigation("carts");

                    b.Navigation("consultations");

                    b.Navigation("interiordesigner")
                        .IsRequired();

                    b.Navigation("orders");

                    b.Navigation("reviews");

                    b.Navigation("subcribes");

                    b.Navigation("userdetails")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
