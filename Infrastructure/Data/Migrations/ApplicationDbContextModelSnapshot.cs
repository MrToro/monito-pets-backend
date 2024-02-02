﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonitoPetsBackend.Infrastructure.Data;

#nullable disable

namespace MonitoPetsBackend.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.Breed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SpeciesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SpeciesId");

                    b.ToTable("Breeds");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Persa",
                            SpeciesId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Siamés",
                            SpeciesId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bengalí",
                            SpeciesId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Criollo",
                            SpeciesId = 1
                        },
                        new
                        {
                            Id = 5,
                            Name = "Boston Terrier",
                            SpeciesId = 2
                        },
                        new
                        {
                            Id = 6,
                            Name = "Border Collie",
                            SpeciesId = 2
                        },
                        new
                        {
                            Id = 7,
                            Name = "Bulldog",
                            SpeciesId = 2
                        },
                        new
                        {
                            Id = 8,
                            Name = "Chihuahua",
                            SpeciesId = 2
                        },
                        new
                        {
                            Id = 9,
                            Name = "Canario",
                            SpeciesId = 3
                        },
                        new
                        {
                            Id = 10,
                            Name = "Periquito",
                            SpeciesId = 3
                        },
                        new
                        {
                            Id = 11,
                            Name = "Loro",
                            SpeciesId = 3
                        });
                });

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Blanco"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Negro Peceño"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Negro Hito"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Negro Azabache"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Azul Oscuro"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Caoba"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Rojizo"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Amarillo"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Naranja"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Café"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Dorado"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Chocolate"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Atigrado"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Moteado"
                        });
                });

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.Pet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<int>("BreedId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("date");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("date");

                    b.Property<int>("LastModifiedById")
                        .HasColumnType("int");

                    b.Property<int>("PetDetailId")
                        .HasColumnType("int");

                    b.Property<int>("PetStatisticId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BreedId");

                    b.HasIndex("ColorId");

                    b.HasIndex("CreatedById");

                    b.HasIndex("LastModifiedById");

                    b.HasIndex("UserId");

                    b.ToTable("Pets");
                });

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.PetDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalInfo")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("date");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<bool?>("HasMicrochip")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsDewormed")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsSterilized")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsVaccinated")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("date");

                    b.Property<int>("LastModifiedById")
                        .HasColumnType("int");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("LastModifiedById");

                    b.HasIndex("PetId")
                        .IsUnique();

                    b.ToTable("PetDetails");
                });

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.PetImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("date");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("date");

                    b.Property<int>("LastModifiedById")
                        .HasColumnType("int");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("LastModifiedById");

                    b.HasIndex("PetId");

                    b.ToTable("PetImages");
                });

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.PetStatistic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("date");

                    b.Property<int>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastModified")
                        .HasColumnType("date");

                    b.Property<int>("LastModifiedById")
                        .HasColumnType("int");

                    b.Property<int>("Likes")
                        .HasColumnType("int");

                    b.Property<int>("PetId")
                        .HasColumnType("int");

                    b.Property<int>("Views")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("LastModifiedById");

                    b.HasIndex("PetId")
                        .IsUnique();

                    b.ToTable("PetStatistic");
                });

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.Species", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Species");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Gato"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Perro"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ave"
                        });
                });

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(360)
                        .HasColumnType("nvarchar(360)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "admin@monito.pet",
                            IsActive = true,
                            Name = "Admin",
                            Password = "admin"
                        },
                        new
                        {
                            Id = 2,
                            Email = "common@monito.pet",
                            IsActive = true,
                            Name = "Common",
                            Password = "common"
                        });
                });

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.Breed", b =>
                {
                    b.HasOne("MonitoPetsBackend.Domain.Entities.Species", "Species")
                        .WithMany("Breeds")
                        .HasForeignKey("SpeciesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Species");
                });

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.Pet", b =>
                {
                    b.HasOne("MonitoPetsBackend.Domain.Entities.Breed", "Breed")
                        .WithMany("Pets")
                        .HasForeignKey("BreedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonitoPetsBackend.Domain.Entities.Color", "Color")
                        .WithMany("Pets")
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonitoPetsBackend.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MonitoPetsBackend.Domain.Entities.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MonitoPetsBackend.Domain.Entities.User", null)
                        .WithMany("Pets")
                        .HasForeignKey("UserId");

                    b.Navigation("Breed");

                    b.Navigation("Color");

                    b.Navigation("CreatedBy");

                    b.Navigation("LastModifiedBy");
                });

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.PetDetail", b =>
                {
                    b.HasOne("MonitoPetsBackend.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MonitoPetsBackend.Domain.Entities.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MonitoPetsBackend.Domain.Entities.Pet", "Pet")
                        .WithOne("PetDetail")
                        .HasForeignKey("MonitoPetsBackend.Domain.Entities.PetDetail", "PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("LastModifiedBy");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.PetImage", b =>
                {
                    b.HasOne("MonitoPetsBackend.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MonitoPetsBackend.Domain.Entities.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MonitoPetsBackend.Domain.Entities.Pet", "Pet")
                        .WithMany("PetImages")
                        .HasForeignKey("PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("LastModifiedBy");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.PetStatistic", b =>
                {
                    b.HasOne("MonitoPetsBackend.Domain.Entities.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MonitoPetsBackend.Domain.Entities.User", "LastModifiedBy")
                        .WithMany()
                        .HasForeignKey("LastModifiedById")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("MonitoPetsBackend.Domain.Entities.Pet", "Pet")
                        .WithOne("PetStatistic")
                        .HasForeignKey("MonitoPetsBackend.Domain.Entities.PetStatistic", "PetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CreatedBy");

                    b.Navigation("LastModifiedBy");

                    b.Navigation("Pet");
                });

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.Breed", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.Color", b =>
                {
                    b.Navigation("Pets");
                });

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.Pet", b =>
                {
                    b.Navigation("PetDetail")
                        .IsRequired();

                    b.Navigation("PetImages");

                    b.Navigation("PetStatistic")
                        .IsRequired();
                });

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.Species", b =>
                {
                    b.Navigation("Breeds");
                });

            modelBuilder.Entity("MonitoPetsBackend.Domain.Entities.User", b =>
                {
                    b.Navigation("Pets");
                });
#pragma warning restore 612, 618
        }
    }
}
