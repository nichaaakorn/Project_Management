﻿// <auto-generated />
using ICONEXT.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ICONEXT.Migrations
{
    [DbContext(typeof(ICONEXTContext))]
    [Migration("20200914120411_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ICONEXT.Models.employee", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(50)")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Active")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndDate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("employee");
                });


            //////////////////////////////////////////////////////////////////////////////

            modelBuilder.Entity("ICONEXT.Models.outsource", b =>
            {
                b.Property<string>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("string")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Active")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Nickname")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Position")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Surname")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Title")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Tel")
                   .HasColumnType("nvarchar(max)");

                b.Property<string>("Email")
                   .HasColumnType("nvarchar(max)");

                b.Property<string>("StartDate")
                   .HasColumnType("nvarchar(max)");

                b.Property<string>("EndDate")
                   .HasColumnType("nvarchar(max)");

                b.HasKey("ID");

                b.ToTable("outsource");
            });


            ///////////////////////////////////////////////////////////////////////////
            

            modelBuilder.Entity("ICONEXT.Models.project", b =>
            {

                b.Property<int>("ProjID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Name")
                    .HasColumnType("nvarchar(50)");

                b.Property<string>("Partner")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Customer")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("StartDate")
                    .HasColumnType("nvarchar(max)");


               



                b.HasKey("ProjID");

                b.ToTable("project");
            });


            ///////////////////////////////////////////////////////////////////////////

            modelBuilder.Entity("ICONEXT.Models.TaskProject", b =>
            {

                b.Property<int>("TID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Tasks")
                    .HasColumnType("nvarchar(max)");

               






                b.HasKey("TID");

                b.ToTable("TaskProject");
            });


            ///////////////////////////////////////////////////////////////////////////

            modelBuilder.Entity("ICONEXT.Models.PhaseProject", b =>
            {

                b.Property<int>("PID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Phase")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("FromDate")
                   .HasColumnType("nvarchar(max)");

                b.Property<string>("EndDate")
                   .HasColumnType("nvarchar(max)");

                b.Property<string>("Usage")
                   .HasColumnType("nvarchar(max)");

               







                b.HasKey("PID");

                b.ToTable("PhaseProject");
            });


            ///////////////////////////////////////////////////////////////////////////

            

            modelBuilder.Entity("ICONEXT.Models.Positions", b =>
            {

                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Position")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Description")
                   .HasColumnType("nvarchar(max)");









                b.HasKey("ID");

                b.ToTable("Positions");
            });


            ///////////////////////////////////////////////////////////////////////////


            
#pragma warning restore 612, 618
        }
    }
}
