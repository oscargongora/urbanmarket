﻿// <auto-generated />
using System;
using ChicStreetwear.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChicStreetwear.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ChicStreetwearDbContext))]
    [Migration("20230529022639_Add payments columns to order table")]
    partial class Addpaymentscolumnstoordertable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ChicStreetwear.Domain.Aggregates.Cart.Cart", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("ChicStreetwear.Domain.Aggregates.Category.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ChicStreetwear.Domain.Aggregates.Order.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeliveredDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DispatchedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PaymentIntent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PaymentIntentClientSecret")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PlacedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReceiptEmail")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ChicStreetwear.Domain.Aggregates.Product.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("HasAttributes")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("SellerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ChicStreetwear.Domain.Aggregates.ProductReview.ProductReview", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasMaxLength(1024)
                        .HasColumnType("nvarchar(1024)");

                    b.Property<DateTime>("CreatedDateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<Guid>("SellerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UpdatedDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ProductReviews");
                });

            modelBuilder.Entity("ChicStreetwear.Domain.Aggregates.User.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ChicStreetwear.Domain.Aggregates.Cart.Cart", b =>
                {
                    b.OwnsMany("ChicStreetwear.Domain.Aggregates.Cart.Entities.CartProduct", "Products", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("CartId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Description")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<decimal>("Price")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Quantity")
                                .HasColumnType("int");

                            b1.Property<Guid>("SellerId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid?>("VariationId")
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("Id", "CartId");

                            b1.HasIndex("CartId");

                            b1.ToTable("CartProduct");

                            b1.WithOwner()
                                .HasForeignKey("CartId");

                            b1.OwnsMany("ChicStreetwear.Domain.Aggregates.Cart.ValueObjects.CartProductAttribute", "Attributes", b2 =>
                                {
                                    b2.Property<Guid>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<Guid>("CartProductId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<Guid>("CartId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<string>("Name")
                                        .IsRequired()
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Value")
                                        .IsRequired()
                                        .HasMaxLength(16)
                                        .HasColumnType("nvarchar(16)");

                                    b2.HasKey("Id", "CartProductId", "CartId");

                                    b2.HasIndex("CartProductId", "CartId");

                                    b2.ToTable("CartProductAttribute");

                                    b2.WithOwner()
                                        .HasForeignKey("CartProductId", "CartId");
                                });

                            b1.Navigation("Attributes");
                        });

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ChicStreetwear.Domain.Aggregates.Order.Order", b =>
                {
                    b.OwnsMany("ChicStreetwear.Domain.Aggregates.Order.Entities.OrderProduct", "Products", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("OrderId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Description")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.Property<decimal>("Price")
                                .HasColumnType("decimal(18,2)");

                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Quantity")
                                .HasColumnType("int");

                            b1.Property<Guid>("SellerId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid?>("VariationId")
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("Id", "OrderId");

                            b1.HasIndex("OrderId");

                            b1.ToTable("OrderProduct");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");

                            b1.OwnsMany("ChicStreetwear.Domain.Aggregates.Order.ValueObjects.OrderProductAttribute", "Attributes", b2 =>
                                {
                                    b2.Property<Guid>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<Guid>("OrderProductId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<Guid>("OrderId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<string>("Name")
                                        .IsRequired()
                                        .HasMaxLength(50)
                                        .HasColumnType("nvarchar(50)");

                                    b2.Property<string>("Value")
                                        .IsRequired()
                                        .HasMaxLength(16)
                                        .HasColumnType("nvarchar(16)");

                                    b2.HasKey("Id", "OrderProductId", "OrderId");

                                    b2.HasIndex("OrderProductId", "OrderId");

                                    b2.ToTable("OrderProductAttribute");

                                    b2.WithOwner()
                                        .HasForeignKey("OrderProductId", "OrderId");
                                });

                            b1.Navigation("Attributes");
                        });

                    b.OwnsOne("ChicStreetwear.Domain.ValueObjects.Address", "DeliveredAddress", b1 =>
                        {
                            b1.Property<Guid>("OrderId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("AddressLine1")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("nvarchar(256)")
                                .HasColumnName("AddressLine1");

                            b1.Property<string>("AddressLine2")
                                .HasMaxLength(256)
                                .HasColumnType("nvarchar(256)")
                                .HasColumnName("AddressLine2");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(64)
                                .HasColumnType("nvarchar(64)")
                                .HasColumnName("City");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasMaxLength(64)
                                .HasColumnType("nvarchar(64)")
                                .HasColumnName("Country");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("nvarchar(256)")
                                .HasColumnName("Email");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)")
                                .HasColumnName("LastName");

                            b1.Property<string>("PhoneNumber")
                                .IsRequired()
                                .HasMaxLength(16)
                                .HasColumnType("nvarchar(16)")
                                .HasColumnName("PhoneNumber");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasMaxLength(16)
                                .HasColumnType("nvarchar(16)")
                                .HasColumnName("PostalCode");

                            b1.Property<string>("State")
                                .IsRequired()
                                .HasMaxLength(64)
                                .HasColumnType("nvarchar(64)")
                                .HasColumnName("State");

                            b1.HasKey("OrderId");

                            b1.ToTable("Orders");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");
                        });

                    b.Navigation("DeliveredAddress")
                        .IsRequired();

                    b.Navigation("Products");
                });

            modelBuilder.Entity("ChicStreetwear.Domain.Aggregates.Product.Product", b =>
                {
                    b.OwnsMany("ChicStreetwear.Domain.Aggregates.Product.Entities.ProductCategory", "Categories", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("CategoryId")
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("ProductId", "Id");

                            b1.HasIndex("CategoryId");

                            b1.ToTable("ProductCategory");

                            b1.HasOne("ChicStreetwear.Domain.Aggregates.Category.Category", null)
                                .WithMany()
                                .HasForeignKey("CategoryId")
                                .OnDelete(DeleteBehavior.Cascade)
                                .IsRequired();

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsMany("ChicStreetwear.Domain.Aggregates.Product.Entities.Variation", "Variations", b1 =>
                        {
                            b1.Property<Guid>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("uniqueidentifier");

                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.HasKey("Id", "ProductId");

                            b1.HasIndex("ProductId");

                            b1.ToTable("Variation");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");

                            b1.OwnsMany("ChicStreetwear.Domain.Aggregates.Product.Entities.AttributeVariation", "Attributes", b2 =>
                                {
                                    b2.Property<Guid>("Id")
                                        .ValueGeneratedOnAdd()
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<Guid>("VariationId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<Guid>("ProductId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<string>("Value")
                                        .IsRequired()
                                        .HasMaxLength(16)
                                        .HasColumnType("nvarchar(16)");

                                    b2.HasKey("Id", "VariationId", "ProductId");

                                    b2.HasIndex("VariationId", "ProductId");

                                    b2.ToTable("AttributeVariation");

                                    b2.WithOwner()
                                        .HasForeignKey("VariationId", "ProductId");

                                    b2.OwnsOne("ChicStreetwear.Domain.Aggregates.Product.ValueObjects.Attribute", "Attribute", b3 =>
                                        {
                                            b3.Property<Guid>("AttributeVariationId")
                                                .HasColumnType("uniqueidentifier");

                                            b3.Property<Guid>("AttributeVariationVariationId")
                                                .HasColumnType("uniqueidentifier");

                                            b3.Property<Guid>("AttributeVariationProductId")
                                                .HasColumnType("uniqueidentifier");

                                            b3.Property<string>("Name")
                                                .IsRequired()
                                                .HasMaxLength(50)
                                                .HasColumnType("nvarchar(50)")
                                                .HasColumnName("Attribute");

                                            b3.HasKey("AttributeVariationId", "AttributeVariationVariationId", "AttributeVariationProductId");

                                            b3.ToTable("AttributeVariation");

                                            b3.WithOwner()
                                                .HasForeignKey("AttributeVariationId", "AttributeVariationVariationId", "AttributeVariationProductId");
                                        });

                                    b2.Navigation("Attribute")
                                        .IsRequired();
                                });

                            b1.OwnsOne("ChicStreetwear.Domain.ValueObjects.Money", "PurchasedPrice", b2 =>
                                {
                                    b2.Property<Guid>("VariationId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<Guid>("VariationProductId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<decimal>("Amount")
                                        .HasColumnType("money")
                                        .HasColumnName("PurchasedPrice");

                                    b2.HasKey("VariationId", "VariationProductId");

                                    b2.ToTable("Variation");

                                    b2.WithOwner()
                                        .HasForeignKey("VariationId", "VariationProductId");
                                });

                            b1.OwnsOne("ChicStreetwear.Domain.ValueObjects.Money", "RegularPrice", b2 =>
                                {
                                    b2.Property<Guid>("VariationId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<Guid>("VariationProductId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<decimal>("Amount")
                                        .HasColumnType("money")
                                        .HasColumnName("RegularPrice");

                                    b2.HasKey("VariationId", "VariationProductId");

                                    b2.ToTable("Variation");

                                    b2.WithOwner()
                                        .HasForeignKey("VariationId", "VariationProductId");
                                });

                            b1.OwnsOne("ChicStreetwear.Domain.ValueObjects.Money", "SalePrice", b2 =>
                                {
                                    b2.Property<Guid>("VariationId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<Guid>("VariationProductId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<decimal>("Amount")
                                        .HasColumnType("money")
                                        .HasColumnName("SalePrice");

                                    b2.HasKey("VariationId", "VariationProductId");

                                    b2.ToTable("Variation");

                                    b2.WithOwner()
                                        .HasForeignKey("VariationId", "VariationProductId");
                                });

                            b1.OwnsOne("ChicStreetwear.Domain.Aggregates.Product.ValueObjects.Stock", "Stock", b2 =>
                                {
                                    b2.Property<Guid>("VariationId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<Guid>("VariationProductId")
                                        .HasColumnType("uniqueidentifier");

                                    b2.Property<int>("Quantity")
                                        .HasColumnType("int")
                                        .HasColumnName("StockQuantity");

                                    b2.HasKey("VariationId", "VariationProductId");

                                    b2.ToTable("Variation");

                                    b2.WithOwner()
                                        .HasForeignKey("VariationId", "VariationProductId");
                                });

                            b1.Navigation("Attributes");

                            b1.Navigation("PurchasedPrice")
                                .IsRequired();

                            b1.Navigation("RegularPrice")
                                .IsRequired();

                            b1.Navigation("SalePrice");

                            b1.Navigation("Stock")
                                .IsRequired();
                        });

                    b.OwnsMany("ChicStreetwear.Domain.Aggregates.Product.ValueObjects.Attribute", "Attributes", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)");

                            b1.HasKey("ProductId", "Id");

                            b1.ToTable("Attributes", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("ChicStreetwear.Domain.ValueObjects.Picture", "CoverPicture", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("FileName")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("nvarchar(256)")
                                .HasColumnName("CoverPictureFileName");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("nvarchar(256)")
                                .HasColumnName("CoverPictureName");

                            b1.Property<string>("ThumbnailUrl")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("CoverPictureThumbnailUrl");

                            b1.Property<string>("Url")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("CoverPictureUrl");

                            b1.HasKey("ProductId");

                            b1.ToTable("Products");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsMany("ChicStreetwear.Domain.ValueObjects.Picture", "Pictures", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<string>("FileName")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("nvarchar(256)");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("nvarchar(256)");

                            b1.Property<string>("ThumbnailUrl")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Url")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("ProductId", "Id");

                            b1.HasIndex("FileName");

                            b1.ToTable("ProductPictures", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("ChicStreetwear.Domain.ValueObjects.Money", "PurchasedPrice", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Amount")
                                .HasColumnType("money")
                                .HasColumnName("PurchasedPrice");

                            b1.HasKey("ProductId");

                            b1.ToTable("Products");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("ChicStreetwear.Domain.ValueObjects.Money", "RegularPrice", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Amount")
                                .HasColumnType("money")
                                .HasColumnName("RegularPrice");

                            b1.HasKey("ProductId");

                            b1.ToTable("Products");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("ChicStreetwear.Domain.ValueObjects.Money", "SalePrice", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<decimal>("Amount")
                                .HasColumnType("money")
                                .HasColumnName("SalePrice");

                            b1.HasKey("ProductId");

                            b1.ToTable("Products");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("ChicStreetwear.Domain.Aggregates.Product.ValueObjects.Stock", "Stock", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Quantity")
                                .HasColumnType("int")
                                .HasColumnName("StockQuantity");

                            b1.HasKey("ProductId");

                            b1.ToTable("Products");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.OwnsOne("ChicStreetwear.Domain.ValueObjects.Rating", "Rating", b1 =>
                        {
                            b1.Property<Guid>("ProductId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Count")
                                .HasColumnType("int")
                                .HasColumnName("RatingCount");

                            b1.Property<float>("Value")
                                .HasColumnType("real")
                                .HasColumnName("RatingValue");

                            b1.HasKey("ProductId");

                            b1.ToTable("Products");

                            b1.WithOwner()
                                .HasForeignKey("ProductId");
                        });

                    b.Navigation("Attributes");

                    b.Navigation("Categories");

                    b.Navigation("CoverPicture");

                    b.Navigation("Pictures");

                    b.Navigation("PurchasedPrice");

                    b.Navigation("Rating")
                        .IsRequired();

                    b.Navigation("RegularPrice");

                    b.Navigation("SalePrice");

                    b.Navigation("Stock")
                        .IsRequired();

                    b.Navigation("Variations");
                });

            modelBuilder.Entity("ChicStreetwear.Domain.Aggregates.User.User", b =>
                {
                    b.OwnsMany("ChicStreetwear.Domain.ValueObjects.Address", "Addresses", b1 =>
                        {
                            b1.Property<Guid>("UserId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int");

                            SqlServerPropertyBuilderExtensions.UseIdentityColumn(b1.Property<int>("Id"));

                            b1.Property<string>("AddressLine1")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("nvarchar(256)")
                                .HasColumnName("AddressLine1");

                            b1.Property<string>("AddressLine2")
                                .HasMaxLength(256)
                                .HasColumnType("nvarchar(256)")
                                .HasColumnName("AddressLine2");

                            b1.Property<string>("City")
                                .IsRequired()
                                .HasMaxLength(64)
                                .HasColumnType("nvarchar(64)")
                                .HasColumnName("City");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasMaxLength(64)
                                .HasColumnType("nvarchar(64)")
                                .HasColumnName("Country");

                            b1.Property<string>("Email")
                                .IsRequired()
                                .HasMaxLength(256)
                                .HasColumnType("nvarchar(256)")
                                .HasColumnName("Email");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)")
                                .HasColumnName("LastName");

                            b1.Property<string>("PhoneNumber")
                                .IsRequired()
                                .HasMaxLength(16)
                                .HasColumnType("nvarchar(16)")
                                .HasColumnName("PhoneNumber");

                            b1.Property<string>("PostalCode")
                                .IsRequired()
                                .HasMaxLength(16)
                                .HasColumnType("nvarchar(16)")
                                .HasColumnName("PostalCode");

                            b1.Property<string>("State")
                                .IsRequired()
                                .HasMaxLength(64)
                                .HasColumnType("nvarchar(64)")
                                .HasColumnName("State");

                            b1.HasKey("UserId", "Id");

                            b1.ToTable("Users_Addresses");

                            b1.WithOwner()
                                .HasForeignKey("UserId");
                        });

                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
