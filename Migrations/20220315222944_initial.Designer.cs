// <auto-generated />
using System;
using Class4_Journals.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Class4_Journals.Migrations
{
    [DbContext(typeof(JournalsContext))]
    [Migration("20220315222944_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Class4_Journals.Models.Comment", b =>
                {
                    b.Property<int>("CommentNumber")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("JournalNumber")
                        .HasColumnType("int");

                    b.HasKey("CommentNumber");

                    b.HasIndex("JournalNumber");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Class4_Journals.Models.Journal", b =>
                {
                    b.Property<int>("JournalNumber")
                        .HasColumnType("int");

                    b.Property<string>("JournalCotent")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("UserNumber")
                        .HasColumnType("int");

                    b.HasKey("JournalNumber");

                    b.HasIndex("UserNumber");

                    b.ToTable("Journal");
                });

            modelBuilder.Entity("Class4_Journals.Models.User", b =>
                {
                    b.Property<int>("UserNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("UserNumber");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Class4_Journals.Models.Comment", b =>
                {
                    b.HasOne("Class4_Journals.Models.Journal", null)
                        .WithMany("Comments")
                        .HasForeignKey("JournalNumber");
                });

            modelBuilder.Entity("Class4_Journals.Models.Journal", b =>
                {
                    b.HasOne("Class4_Journals.Models.User", "User")
                        .WithMany("Journals")
                        .HasForeignKey("UserNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Class4_Journals.Models.Journal", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Class4_Journals.Models.User", b =>
                {
                    b.Navigation("Journals");
                });
#pragma warning restore 612, 618
        }
    }
}
