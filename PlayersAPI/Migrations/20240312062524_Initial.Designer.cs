﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlayersAPI.Data;

#nullable disable

namespace PlayersAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240312062524_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PlayersAPI.Entities.Player", b =>
                {
                    b.Property<string>("Nickname")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.Property<int>("group")
                        .HasColumnType("int");

                    b.HasKey("Nickname");

                    b.ToTable("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
