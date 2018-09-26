﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UtilidorApi.Data;

namespace UtilidorApi.Migrations
{
    [DbContext(typeof(UtilidorContext))]
    [Migration("20180926150118_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UtilidorApi.Models.Instance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CompleteTime");

                    b.Property<int?>("Denominator");

                    b.Property<int?>("Numerator");

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("UtilityId");

                    b.HasKey("Id");

                    b.HasIndex("UtilityId");

                    b.ToTable("Instances");
                });

            modelBuilder.Entity("UtilidorApi.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InstanceId");

                    b.Property<int>("Level");

                    b.Property<string>("Message");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.HasIndex("InstanceId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("UtilidorApi.Models.Utility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Utilities");
                });

            modelBuilder.Entity("UtilidorApi.Models.Instance", b =>
                {
                    b.HasOne("UtilidorApi.Models.Utility")
                        .WithMany("Instances")
                        .HasForeignKey("UtilityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UtilidorApi.Models.Log", b =>
                {
                    b.HasOne("UtilidorApi.Models.Instance")
                        .WithMany("Logs")
                        .HasForeignKey("InstanceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}