/*
 * Author: Sakthi Santhosh
 * Created on: 09/05/2024
 */
using System;
using Challenge1.PizzaAppLibrary;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace PizzaAppLibrary.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240509052946Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Challenge1.PizzaAppLibrary.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<decimal>("PriceDollars")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("Challenge1.PizzaAppLibrary.Topping", b =>
                {
                    b.Property<int>("ToppingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ToppingId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PizzaId")
                        .HasColumnType("int");

                    b.HasKey("ToppingId");

                    b.HasIndex("PizzaId");

                    b.ToTable("Toppings");
                });

            modelBuilder.Entity("Challenge1.PizzaAppLibrary.Topping", b =>
                {
                    b.HasOne("Challenge1.PizzaAppLibrary.Pizza", null)
                        .WithMany("Toppings")
                        .HasForeignKey("PizzaId");
                });

            modelBuilder.Entity("Challenge1.PizzaAppLibrary.Pizza", b =>
                {
                    b.Navigation("Toppings");
                });
#pragma warning restore 612, 618
        }
    }
}
