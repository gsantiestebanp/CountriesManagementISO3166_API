﻿// <auto-generated />
using CountriesManagementISO3166_API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CountriesManagementISO3166_API.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Countries_Management_ISO3166_API.Models.Countrie", b =>
                {
                    b.Property<int>("CountrieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Alpha2Code")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<string>("Alpha3Code")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("CommonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsoName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberSubdivisions")
                        .HasColumnType("int");

                    b.Property<int>("NumericCode")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<string>("Observation")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountrieId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Countries_Management_ISO3166_API.Models.Subdivision", b =>
                {
                    b.Property<int>("SubdivisionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubdivisionCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubdivisionId");

                    b.ToTable("Subdivisions");
                });
#pragma warning restore 612, 618
        }
    }
}
