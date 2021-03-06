// <auto-generated />
using System;
using Clinic.Models.myDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Clinic.Migrations
{
    [DbContext(typeof(myDBcontext))]
    [Migration("20210403101614_usersmigration")]
    partial class usersmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ADweya", b =>
                {
                    b.Property<int>("id_adweya")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name_adweya")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("supplier_adweya")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("uses_adwya")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("id_adweya");

                    b.ToTable("aDweyas");
                });

            modelBuilder.Entity("IRadat", b =>
                {
                    b.Property<int>("id_irad")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("addtime_irad")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("irad_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("id_irad");

                    b.ToTable("iradats");
                });

            modelBuilder.Entity("Masrofat", b =>
                {
                    b.Property<int>("id_masrof")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("addtime_masrof")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("masrof_type")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.HasKey("id_masrof");

                    b.ToTable("masrofats");
                });

            modelBuilder.Entity("Online", b =>
                {
                    b.Property<int>("id_online")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adress_online")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime>("date_online")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("name_online")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("phone_online")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_online");

                    b.ToTable("onlines");
                });

            modelBuilder.Entity("Setting", b =>
                {
                    b.Property<int>("id_clinic")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("doctor_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_clinic")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_clinic");

                    b.ToTable("settings");
                });

            modelBuilder.Entity("Users", b =>
                {
                    b.Property<int>("id_user")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("id_user");

                    b.ToTable("users");
                });

            modelBuilder.Entity("patient", b =>
                {
                    b.Property<int>("idpatiend")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("addtime")
                        .HasColumnType("datetime2");

                    b.Property<string>("adress_patient")
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<int>("code")
                        .HasColumnType("int");

                    b.Property<string>("name_patient")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<decimal>("paied")
                        .HasColumnType("decimal(6,2)");

                    b.Property<string>("phone_patient")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type_kashf")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("idpatiend");

                    b.ToTable("patients");
                });
#pragma warning restore 612, 618
        }
    }
}
