﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eRecept.Repositories;

namespace eRecept.Migrations.FeedbackRepositoryMigrations
{
    [DbContext(typeof(FeedbackRepository))]
    [Migration("20200607220707_UserMigration")]
    partial class UserMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eRecept.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<string>("RecipeId")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(5)");

                    b.HasKey("Id");

                    b.ToTable("Feedbacks");
                });
#pragma warning restore 612, 618
        }
    }
}
