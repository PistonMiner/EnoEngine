﻿// <auto-generated />
using System;
using EnoCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EnoCore.Migrations
{
    [DbContext(typeof(EnoEngineDBContext))]
    partial class EnoEngineDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("EnoCore.Models.Database.CheckerLogMessage", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Message");

                    b.Property<string>("Origin");

                    b.Property<long>("RelatedTaskId");

                    b.Property<int>("Severity");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("RelatedTaskId");

                    b.HasIndex("Timestamp");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("EnoCore.Models.Database.CheckerTask", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<int>("CheckerResult");

                    b.Property<int>("CheckerTaskLaunchStatus");

                    b.Property<long>("CurrentRoundId");

                    b.Property<int>("MaxRunningTime");

                    b.Property<string>("Payload");

                    b.Property<long>("RelatedRoundId");

                    b.Property<long>("ServiceId");

                    b.Property<string>("ServiceName");

                    b.Property<DateTime>("StartTime");

                    b.Property<long>("TaskIndex");

                    b.Property<string>("TaskType");

                    b.Property<long>("TeamId");

                    b.Property<string>("TeamName");

                    b.HasKey("Id");

                    b.HasIndex("CheckerTaskLaunchStatus");

                    b.HasIndex("Id");

                    b.ToTable("CheckerTasks");
                });

            modelBuilder.Entity("EnoCore.Models.Flag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("GameRoundId");

                    b.Property<long>("OwnerId");

                    b.Property<int>("RoundOffset");

                    b.Property<long>("ServiceId");

                    b.Property<string>("StringRepresentation");

                    b.HasKey("Id");

                    b.HasIndex("GameRoundId");

                    b.HasIndex("Id");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Flags");
                });

            modelBuilder.Entity("EnoCore.Models.Round", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Begin");

                    b.Property<DateTime>("End");

                    b.Property<DateTime>("Quarter2");

                    b.Property<DateTime>("Quarter3");

                    b.Property<DateTime>("Quarter4");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Rounds");
                });

            modelBuilder.Entity("EnoCore.Models.RoundTeamServiceState", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("FlagsCaptured");

                    b.Property<long>("FlagsLost");

                    b.Property<long>("GameRoundId");

                    b.Property<long>("ServiceId");

                    b.Property<int>("Status");

                    b.Property<long>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("GameRoundId");

                    b.HasIndex("Id");

                    b.HasIndex("ServiceId");

                    b.HasIndex("TeamId");

                    b.ToTable("RoundTeamServiceStates");
                });

            modelBuilder.Entity("EnoCore.Models.Service", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FlagsPerRound");

                    b.Property<string>("Name");

                    b.Property<long>("ServiceStatsId");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("EnoCore.Models.ServiceStats", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AttackPoints");

                    b.Property<double>("LostDefensePoints");

                    b.Property<long>("ServiceId");

                    b.Property<double>("ServiceLevelAgreementPoints");

                    b.Property<int>("Status");

                    b.Property<long>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.HasIndex("ServiceId");

                    b.HasIndex("TeamId");

                    b.ToTable("ServiceStats");
                });

            modelBuilder.Entity("EnoCore.Models.SubmittedFlag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long>("AttackerTeamId");

                    b.Property<long>("FlagId");

                    b.Property<long>("RoundId");

                    b.Property<long>("SubmissionsCount");

                    b.HasKey("Id");

                    b.HasIndex("AttackerTeamId");

                    b.HasIndex("FlagId");

                    b.HasIndex("Id");

                    b.HasIndex("RoundId");

                    b.ToTable("SubmittedFlags");
                });

            modelBuilder.Entity("EnoCore.Models.Team", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("AttackPoints");

                    b.Property<string>("GatewayAddress");

                    b.Property<double>("LostDefensePoints");

                    b.Property<string>("Name");

                    b.Property<double>("ServiceLevelAgreementPoints");

                    b.Property<long>("ServiceStatsId");

                    b.Property<long>("TeamId");

                    b.Property<double>("TotalPoints");

                    b.Property<string>("VulnboxAddress");

                    b.HasKey("Id");

                    b.HasIndex("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("EnoCore.Models.Database.CheckerLogMessage", b =>
                {
                    b.HasOne("EnoCore.Models.Database.CheckerTask", "RelatedTask")
                        .WithMany()
                        .HasForeignKey("RelatedTaskId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EnoCore.Models.Flag", b =>
                {
                    b.HasOne("EnoCore.Models.Round", "GameRound")
                        .WithMany()
                        .HasForeignKey("GameRoundId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EnoCore.Models.Team", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EnoCore.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EnoCore.Models.RoundTeamServiceState", b =>
                {
                    b.HasOne("EnoCore.Models.Round", "GameRound")
                        .WithMany()
                        .HasForeignKey("GameRoundId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EnoCore.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EnoCore.Models.Team", "Team")
                        .WithMany("ServiceDetails")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EnoCore.Models.ServiceStats", b =>
                {
                    b.HasOne("EnoCore.Models.Service", "Service")
                        .WithMany("ServiceStats")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EnoCore.Models.Team", "Team")
                        .WithMany("ServiceStats")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EnoCore.Models.SubmittedFlag", b =>
                {
                    b.HasOne("EnoCore.Models.Team", "AttackerTeam")
                        .WithMany()
                        .HasForeignKey("AttackerTeamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EnoCore.Models.Flag", "Flag")
                        .WithMany()
                        .HasForeignKey("FlagId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EnoCore.Models.Round", "Round")
                        .WithMany()
                        .HasForeignKey("RoundId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
