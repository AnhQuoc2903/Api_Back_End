﻿// <auto-generated />
using System;
using GraduationAPI_EPOSHBOOKING.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraduationAPI_EPOSHBOOKING.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20240729093017_mainDb")]
    partial class mainDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Account", b =>
                {
                    b.Property<int>("AccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccountID"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("ProfileID")
                        .HasColumnType("int");

                    b.Property<int?>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("AccountID");

                    b.HasIndex("ProfileID");

                    b.HasIndex("RoleID");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Blog", b =>
                {
                    b.Property<int>("BlogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BlogID"));

                    b.Property<int?>("AccountID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReasonReject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BlogID");

                    b.HasIndex("AccountID");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.BlogImage", b =>
                {
                    b.Property<int>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageID"));

                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageID");

                    b.HasIndex("BlogID");

                    b.ToTable("BlogImage");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<int?>("AccountID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("NumberGuest")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfRoom")
                        .HasColumnType("int");

                    b.Property<string>("ReasonCancle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoomID")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TaxesPrice")
                        .HasColumnType("float");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<double>("UnitPrice")
                        .HasColumnType("float");

                    b.Property<int?>("VoucherID")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.HasIndex("AccountID");

                    b.HasIndex("RoomID");

                    b.HasIndex("VoucherID");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.CommentBlog", b =>
                {
                    b.Property<int>("CommentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentID"));

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<int>("BlogID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateComment")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentID");

                    b.HasIndex("AccountID");

                    b.HasIndex("BlogID");

                    b.ToTable("CommentBlog");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.FeedBack", b =>
                {
                    b.Property<int>("FeedBackID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FeedBackID"));

                    b.Property<int?>("AccountID")
                        .HasColumnType("int");

                    b.Property<int?>("BookingID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HotelID")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FeedBackID");

                    b.HasIndex("AccountID");

                    b.HasIndex("BookingID");

                    b.HasIndex("HotelID");

                    b.ToTable("FeedBack");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Hotel", b =>
                {
                    b.Property<int>("HotelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HotelID"));

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<int?>("AddressID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HotelStandar")
                        .HasColumnType("int");

                    b.Property<string>("MainImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OpenedIn")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("isRegister")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HotelID");

                    b.HasIndex("AccountID");

                    b.HasIndex("AddressID");

                    b.ToTable("Hotel");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.HotelAddress", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("latitude")
                        .HasColumnType("float");

                    b.Property<double>("longitude")
                        .HasColumnType("float");

                    b.HasKey("AddressID");

                    b.ToTable("HotelAddress");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.HotelImage", b =>
                {
                    b.Property<int>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageID"));

                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ImageID");

                    b.HasIndex("HotelID");

                    b.ToTable("HotelImage");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.HotelService", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServiceID"));

                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ServiceID");

                    b.HasIndex("HotelID");

                    b.ToTable("HotelService");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.HotelSubService", b =>
                {
                    b.Property<int>("SubServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubServiceID"));

                    b.Property<int>("ServiceID")
                        .HasColumnType("int");

                    b.Property<string>("SubServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubServiceID");

                    b.HasIndex("ServiceID");

                    b.ToTable("HotelSubService");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.MyVoucher", b =>
                {
                    b.Property<int>("VoucherID")
                        .HasColumnType("int");

                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<bool>("IsVoucher")
                        .HasColumnType("bit");

                    b.HasKey("VoucherID", "AccountID");

                    b.HasIndex("AccountID");

                    b.ToTable("MyVoucher");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Profile", b =>
                {
                    b.Property<int>("ProfileID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.HasKey("ProfileID");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.ReportFeedBack", b =>
                {
                    b.Property<int>("ReportID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportID"));

                    b.Property<int>("FeedBackID")
                        .HasColumnType("int");

                    b.Property<string>("ReasonReport")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReporterEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReportID");

                    b.HasIndex("FeedBackID");

                    b.ToTable("ReportFeedBack");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("RoleID");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomID"));

                    b.Property<int?>("HotelID")
                        .HasColumnType("int");

                    b.Property<int>("NumberCapacity")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfBed")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SizeOfRoom")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfBed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfRoom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomID");

                    b.HasIndex("HotelID");

                    b.ToTable("Room");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.RoomImage", b =>
                {
                    b.Property<int>("ImageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ImageID"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.HasKey("ImageID");

                    b.HasIndex("RoomID");

                    b.ToTable("RoomImage");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.RoomService", b =>
                {
                    b.Property<int>("RoomServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomServiceID"));

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomServiceID");

                    b.HasIndex("RoomID");

                    b.ToTable("RoomService");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.RoomSubService", b =>
                {
                    b.Property<int>("SubServiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubServiceID"));

                    b.Property<int>("RoomServiceID")
                        .HasColumnType("int");

                    b.Property<string>("SubName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubServiceID");

                    b.HasIndex("RoomServiceID");

                    b.ToTable("RoomSubService");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.SpecialPrice", b =>
                {
                    b.Property<int>("SpecialPriceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpecialPriceID"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SpecialPriceID");

                    b.HasIndex("RoomID");

                    b.ToTable("SpecialPrice");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Voucher", b =>
                {
                    b.Property<int>("VoucherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VoucherID"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<int>("QuantityUse")
                        .HasColumnType("int");

                    b.Property<string>("VoucherImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VoucherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VoucherID");

                    b.ToTable("Voucher");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Account", b =>
                {
                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileID");

                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID");

                    b.Navigation("Profile");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Blog", b =>
                {
                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Account", "Account")
                        .WithMany("Blogs")
                        .HasForeignKey("AccountID");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.BlogImage", b =>
                {
                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Blog", "Blog")
                        .WithMany("BlogImage")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Booking", b =>
                {
                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountID");

                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomID");

                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Voucher", "Voucher")
                        .WithMany()
                        .HasForeignKey("VoucherID");

                    b.Navigation("Account");

                    b.Navigation("Room");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.CommentBlog", b =>
                {
                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Account", "account")
                        .WithMany()
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Blog", "blog")
                        .WithMany("Comment")
                        .HasForeignKey("BlogID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");

                    b.Navigation("blog");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.FeedBack", b =>
                {
                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountID");

                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Booking", "Booking")
                        .WithMany("feedBacks")
                        .HasForeignKey("BookingID");

                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Hotel", "Hotel")
                        .WithMany("feedBacks")
                        .HasForeignKey("HotelID");

                    b.Navigation("Account");

                    b.Navigation("Booking");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Hotel", b =>
                {
                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Account", "Account")
                        .WithMany("Hotel")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.HotelAddress", "HotelAddress")
                        .WithMany()
                        .HasForeignKey("AddressID");

                    b.Navigation("Account");

                    b.Navigation("HotelAddress");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.HotelImage", b =>
                {
                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Hotel", "Hotel")
                        .WithMany("HotelImages")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.HotelService", b =>
                {
                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Hotel", "Hotel")
                        .WithMany("HotelServices")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.HotelSubService", b =>
                {
                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.HotelService", "HotelService")
                        .WithMany("HotelSubServices")
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HotelService");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.MyVoucher", b =>
                {
                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Account", "Account")
                        .WithMany("MyVouchers")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Voucher", "Voucher")
                        .WithMany("MyVouchers")
                        .HasForeignKey("VoucherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Voucher");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.ReportFeedBack", b =>
                {
                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.FeedBack", "FeedBack")
                        .WithMany()
                        .HasForeignKey("FeedBackID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FeedBack");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Room", b =>
                {
                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Hotel", "Hotel")
                        .WithMany("rooms")
                        .HasForeignKey("HotelID");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.RoomImage", b =>
                {
                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Room", "Room")
                        .WithMany("RoomImages")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.RoomService", b =>
                {
                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Room", "Room")
                        .WithMany("RoomService")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.RoomSubService", b =>
                {
                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.RoomService", "RoomService")
                        .WithMany("RoomSubServices")
                        .HasForeignKey("RoomServiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RoomService");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.SpecialPrice", b =>
                {
                    b.HasOne("GraduationAPI_EPOSHBOOKING.Model.Room", "Room")
                        .WithMany("SpecialPrice")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Account", b =>
                {
                    b.Navigation("Blogs");

                    b.Navigation("Hotel");

                    b.Navigation("MyVouchers");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Blog", b =>
                {
                    b.Navigation("BlogImage");

                    b.Navigation("Comment");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Booking", b =>
                {
                    b.Navigation("feedBacks");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Hotel", b =>
                {
                    b.Navigation("HotelImages");

                    b.Navigation("HotelServices");

                    b.Navigation("feedBacks");

                    b.Navigation("rooms");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.HotelService", b =>
                {
                    b.Navigation("HotelSubServices");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Room", b =>
                {
                    b.Navigation("RoomImages");

                    b.Navigation("RoomService");

                    b.Navigation("SpecialPrice");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.RoomService", b =>
                {
                    b.Navigation("RoomSubServices");
                });

            modelBuilder.Entity("GraduationAPI_EPOSHBOOKING.Model.Voucher", b =>
                {
                    b.Navigation("MyVouchers");
                });
#pragma warning restore 612, 618
        }
    }
}
