﻿// <auto-generated />
using System;
using ApplicationProgram.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApplicationProgram.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApplicationProgram.Domain.Models.Candidates.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CurrentResident")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FormId")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Candidate", (string)null);
                });

            modelBuilder.Entity("ApplicationProgram.Domain.Models.Candidates.CustomQuestionAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<string>("ChoiceIdList")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateTimeAnswer")
                        .HasColumnType("datetime2");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionType")
                        .HasColumnType("int");

                    b.Property<string>("WrittenAnswer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("YesNoAnswer")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.ToTable("Candidate_CustomQuestionAnswer", (string)null);
                });

            modelBuilder.Entity("ApplicationProgram.Domain.Models.ProgramForms.AnswerChoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Choice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustomQuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomQuestionId");

                    b.ToTable("Question_AnswerChoice", (string)null);
                });

            modelBuilder.Entity("ApplicationProgram.Domain.Models.ProgramForms.CustomQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MaxChoice")
                        .HasColumnType("int");

                    b.Property<bool?>("OtherEnabled")
                        .HasColumnType("bit");

                    b.Property<int>("ProgramFormId")
                        .HasColumnType("int");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProgramFormId");

                    b.ToTable("ProgramForm_CustomQuestion", (string)null);
                });

            modelBuilder.Entity("ApplicationProgram.Domain.Models.ProgramForms.ProgramForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProgramForm", (string)null);
                });

            modelBuilder.Entity("ApplicationProgram.Domain.Models.Candidates.CustomQuestionAnswer", b =>
                {
                    b.HasOne("ApplicationProgram.Domain.Models.Candidates.Candidate", null)
                        .WithMany("CustomQuestionAnswers")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationProgram.Domain.Models.ProgramForms.AnswerChoice", b =>
                {
                    b.HasOne("ApplicationProgram.Domain.Models.ProgramForms.CustomQuestion", null)
                        .WithMany("Choices")
                        .HasForeignKey("CustomQuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationProgram.Domain.Models.ProgramForms.CustomQuestion", b =>
                {
                    b.HasOne("ApplicationProgram.Domain.Models.ProgramForms.ProgramForm", null)
                        .WithMany("CustomQuestions")
                        .HasForeignKey("ProgramFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApplicationProgram.Domain.Models.Candidates.Candidate", b =>
                {
                    b.Navigation("CustomQuestionAnswers");
                });

            modelBuilder.Entity("ApplicationProgram.Domain.Models.ProgramForms.CustomQuestion", b =>
                {
                    b.Navigation("Choices");
                });

            modelBuilder.Entity("ApplicationProgram.Domain.Models.ProgramForms.ProgramForm", b =>
                {
                    b.Navigation("CustomQuestions");
                });
#pragma warning restore 612, 618
        }
    }
}
