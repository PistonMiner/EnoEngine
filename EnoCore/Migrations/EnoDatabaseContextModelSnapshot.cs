﻿// <auto-generated />
using System;
using EnoCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EnoCore.Migrations
{
    [DbContext(typeof(EnoDatabaseContext))]
    partial class EnoDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("EnoCore.Models.Database.CheckerTask", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<int>("CheckerResult")
                        .HasColumnType("integer");

                    b.Property<int>("CheckerTaskLaunchStatus")
                        .HasColumnType("integer");

                    b.Property<string>("CheckerUrl")
                        .HasColumnType("text");

                    b.Property<long>("CurrentRoundId")
                        .HasColumnType("bigint");

                    b.Property<int>("MaxRunningTime")
                        .HasColumnType("integer");

                    b.Property<string>("Payload")
                        .HasColumnType("text");

                    b.Property<long>("RelatedRoundId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoundLength")
                        .HasColumnType("bigint");

                    b.Property<long>("ServiceId")
                        .HasColumnType("bigint");

                    b.Property<string>("ServiceName")
                        .HasColumnType("text");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("TaskIndex")
                        .HasColumnType("bigint");

                    b.Property<string>("TaskType")
                        .HasColumnType("text");

                    b.Property<long>("TeamId")
                        .HasColumnType("bigint");

                    b.Property<string>("TeamName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CheckerTaskLaunchStatus");

                    b.HasIndex("TeamId");

                    b.ToTable("CheckerTasks");
                });

            modelBuilder.Entity("EnoCore.Models.Database.Havoc", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("GameRoundId")
                        .HasColumnType("bigint");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<long>("ServiceId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("GameRoundId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Havocs");
                });

            modelBuilder.Entity("EnoCore.Models.Database.Noise", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("GameRoundId")
                        .HasColumnType("bigint");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<int>("RoundOffset")
                        .HasColumnType("integer");

                    b.Property<long>("ServiceId")
                        .HasColumnType("bigint");

                    b.Property<string>("StringRepresentation")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("GameRoundId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Noises");
                });

            modelBuilder.Entity("EnoCore.Models.Database.ServiceStatsSnapshot", b =>
                {
                    b.Property<long>("ServiceId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoundId")
                        .HasColumnType("bigint");

                    b.Property<long>("TeamId")
                        .HasColumnType("bigint");

                    b.Property<double>("AttackPoints")
                        .HasColumnType("double precision");

                    b.Property<double>("LostDefensePoints")
                        .HasColumnType("double precision");

                    b.Property<double>("ServiceLevelAgreementPoints")
                        .HasColumnType("double precision");

                    b.HasKey("ServiceId", "RoundId", "TeamId");

                    b.HasIndex("RoundId");

                    b.HasIndex("TeamId");

                    b.ToTable("ServiceStatsSnapshots");
                });

            modelBuilder.Entity("EnoCore.Models.Flag", b =>
                {
                    b.Property<long>("ServiceId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoundId")
                        .HasColumnType("bigint");

                    b.Property<long>("OwnerId")
                        .HasColumnType("bigint");

                    b.Property<int>("RoundOffset")
                        .HasColumnType("integer");

                    b.Property<long>("Captures")
                        .HasColumnType("bigint");

                    b.HasKey("ServiceId", "RoundId", "OwnerId", "RoundOffset");

                    b.HasIndex("OwnerId");

                    b.HasIndex("RoundId");

                    b.ToTable("Flags");
                });

            modelBuilder.Entity("EnoCore.Models.Round", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Begin")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("End")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Quarter2")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Quarter3")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Quarter4")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("EnoCore.Models.RoundTeamServiceState", b =>
                {
                    b.Property<long>("ServiceId")
                        .HasColumnType("bigint");

                    b.Property<long>("TeamId")
                        .HasColumnType("bigint");

                    b.Property<long>("GameRoundId")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("ServiceId", "TeamId", "GameRoundId");

                    b.HasIndex("GameRoundId");

                    b.HasIndex("TeamId");

                    b.ToTable("RoundTeamServiceStates");
                });

            modelBuilder.Entity("EnoCore.Models.Service", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<int>("FlagsPerRound")
                        .HasColumnType("integer");

                    b.Property<int>("HavocsPerRound")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("NoisesPerRound")
                        .HasColumnType("integer");

                    b.Property<long>("ServiceStatsId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("EnoCore.Models.ServiceStats", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("AttackPoints")
                        .HasColumnType("double precision");

                    b.Property<double>("LostDefensePoints")
                        .HasColumnType("double precision");

                    b.Property<long>("ServiceId")
                        .HasColumnType("bigint");

                    b.Property<double>("ServiceLevelAgreementPoints")
                        .HasColumnType("double precision");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<long>("TeamId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.HasIndex("TeamId");

                    b.ToTable("ServiceStats");
                });

            modelBuilder.Entity("EnoCore.Models.SubmittedFlag", b =>
                {
                    b.Property<long>("FlagServiceId")
                        .HasColumnType("bigint");

                    b.Property<long>("FlagRoundId")
                        .HasColumnType("bigint");

                    b.Property<long>("FlagOwnerId")
                        .HasColumnType("bigint");

                    b.Property<int>("FlagRoundOffset")
                        .HasColumnType("integer");

                    b.Property<long>("AttackerTeamId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoundId")
                        .HasColumnType("bigint");

                    b.Property<long>("SubmissionsCount")
                        .HasColumnType("bigint");

                    b.HasKey("FlagServiceId", "FlagRoundId", "FlagOwnerId", "FlagRoundOffset", "AttackerTeamId");

                    b.HasIndex("AttackerTeamId");

                    b.HasIndex("RoundId");

                    b.ToTable("SubmittedFlags");
                });

            modelBuilder.Entity("EnoCore.Models.Team", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<double>("AttackPoints")
                        .HasColumnType("double precision");

                    b.Property<double>("LostDefensePoints")
                        .HasColumnType("double precision");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<double>("ServiceLevelAgreementPoints")
                        .HasColumnType("double precision");

                    b.Property<long>("ServiceStatsId")
                        .HasColumnType("bigint");

                    b.Property<string>("TeamSubnet")
                        .HasColumnType("text");

                    b.Property<double>("TotalPoints")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("EnoCore.Models.Database.CheckerTask", b =>
                {
                    b.HasOne("EnoCore.Models.Team", null)
                        .WithMany("CheckerTasks")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnoCore.Models.Database.Havoc", b =>
                {
                    b.HasOne("EnoCore.Models.Round", "GameRound")
                        .WithMany()
                        .HasForeignKey("GameRoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnoCore.Models.Team", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnoCore.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnoCore.Models.Database.Noise", b =>
                {
                    b.HasOne("EnoCore.Models.Round", "GameRound")
                        .WithMany()
                        .HasForeignKey("GameRoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnoCore.Models.Team", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnoCore.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnoCore.Models.Database.ServiceStatsSnapshot", b =>
                {
                    b.HasOne("EnoCore.Models.Round", "Round")
                        .WithMany()
                        .HasForeignKey("RoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnoCore.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnoCore.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnoCore.Models.Flag", b =>
                {
                    b.HasOne("EnoCore.Models.Team", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnoCore.Models.Round", "Round")
                        .WithMany()
                        .HasForeignKey("RoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnoCore.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnoCore.Models.RoundTeamServiceState", b =>
                {
                    b.HasOne("EnoCore.Models.Round", "GameRound")
                        .WithMany()
                        .HasForeignKey("GameRoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnoCore.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnoCore.Models.Team", "Team")
                        .WithMany("ServiceDetails")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnoCore.Models.ServiceStats", b =>
                {
                    b.HasOne("EnoCore.Models.Service", "Service")
                        .WithMany("ServiceStats")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnoCore.Models.Team", "Team")
                        .WithMany("ServiceStats")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EnoCore.Models.SubmittedFlag", b =>
                {
                    b.HasOne("EnoCore.Models.Team", "AttackerTeam")
                        .WithMany()
                        .HasForeignKey("AttackerTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnoCore.Models.Round", "Round")
                        .WithMany()
                        .HasForeignKey("RoundId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnoCore.Models.Flag", "Flag")
                        .WithMany()
                        .HasForeignKey("FlagServiceId", "FlagRoundId", "FlagOwnerId", "FlagRoundOffset")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
