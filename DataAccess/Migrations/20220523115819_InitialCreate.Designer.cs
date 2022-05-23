﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(DataDbContext))]
    [Migration("20220523115819_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Food", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("gün_bozulma_tarihi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("kalori")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("kalsiyum_gr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("karbonhidrat_gr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("karbonhidrat_yüzde")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("kollestrol_gr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("lif_gr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("potasyum_gr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("protein_gr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("protein_yüzde")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("sodyum_gr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("yağ_gr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("yağ_yüzde")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("yemek_ismi")
                        .IsRequired()
                        .HasColumnType("varchar(40)");

                    b.HasKey("id");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            id = 1,
                            gün_bozulma_tarihi = 0,
                            kalori = 0,
                            kalsiyum_gr = 0,
                            karbonhidrat_gr = 0,
                            karbonhidrat_yüzde = 0,
                            kollestrol_gr = 0,
                            lif_gr = 0,
                            potasyum_gr = 0,
                            protein_gr = 0,
                            protein_yüzde = 0,
                            sodyum_gr = 0,
                            yağ_gr = 0,
                            yağ_yüzde = 0,
                            yemek_ismi = "Elma"
                        },
                        new
                        {
                            id = 2,
                            gün_bozulma_tarihi = 0,
                            kalori = 0,
                            kalsiyum_gr = 0,
                            karbonhidrat_gr = 0,
                            karbonhidrat_yüzde = 0,
                            kollestrol_gr = 0,
                            lif_gr = 0,
                            potasyum_gr = 0,
                            protein_gr = 0,
                            protein_yüzde = 0,
                            sodyum_gr = 0,
                            yağ_gr = 0,
                            yağ_yüzde = 0,
                            yemek_ismi = "Erik"
                        },
                        new
                        {
                            id = 3,
                            gün_bozulma_tarihi = 0,
                            kalori = 0,
                            kalsiyum_gr = 0,
                            karbonhidrat_gr = 0,
                            karbonhidrat_yüzde = 0,
                            kollestrol_gr = 0,
                            lif_gr = 0,
                            potasyum_gr = 0,
                            protein_gr = 0,
                            protein_yüzde = 0,
                            sodyum_gr = 0,
                            yağ_gr = 0,
                            yağ_yüzde = 0,
                            yemek_ismi = "Kiraz"
                        });
                });

            modelBuilder.Entity("Entities.Fridge", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(20)")
                        .HasDefaultValue("Buzdolabım");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id");

                    b.ToTable("Fridges");
                });

            modelBuilder.Entity("Entities.My_Food", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Foods_id")
                        .HasColumnType("int");

                    b.Property<int>("Fridges_id")
                        .HasColumnType("int");

                    b.Property<string>("Jobs_id")
                        .HasColumnType("varchar(300)");

                    b.Property<DateTime>("bozulma_tarihi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 5, 23, 14, 58, 19, 497, DateTimeKind.Local).AddTicks(3521));

                    b.Property<DateTime>("eklenme_tarihi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 5, 23, 14, 58, 19, 498, DateTimeKind.Local).AddTicks(2979));

                    b.HasKey("id");

                    b.HasIndex("Foods_id");

                    b.HasIndex("Fridges_id");

                    b.ToTable("My_Foods");
                });

            modelBuilder.Entity("Entities.Notification", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("bildirim")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Entities.NotificationType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("tercih_eposta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("tercih_sms")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("tercih_uygulama")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id")
                        .IsUnique();

                    b.ToTable("NotificationType");
                });

            modelBuilder.Entity("Entities.Notification_Count", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("notificationscount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id");

                    b.ToTable("Notification_Counts");
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Cinsiyet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(15)")
                        .HasDefaultValue("Belirtmemiş");

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Telefon")
                        .HasColumnType("varchar(10)");

                    b.HasKey("id");

                    b.HasIndex("Eposta")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.User_article", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 5, 23, 14, 58, 19, 499, DateTimeKind.Local).AddTicks(4415));

                    b.Property<string>("text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("varchar(3000)");

                    b.Property<int>("user_id")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("user_id");

                    b.ToTable("User_articles");
                });

            modelBuilder.Entity("Entities.Fridge", b =>
                {
                    b.HasOne("Entities.User", "User")
                        .WithMany("Fridge")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.My_Food", b =>
                {
                    b.HasOne("Entities.Food", "Food")
                        .WithOne("My_Food")
                        .HasForeignKey("Entities.My_Food", "Foods_id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Fridge", "Fridge")
                        .WithMany("My_Food")
                        .HasForeignKey("Fridges_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Food");

                    b.Navigation("Fridge");
                });

            modelBuilder.Entity("Entities.Notification", b =>
                {
                    b.HasOne("Entities.User", "User")
                        .WithMany("Notification")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.NotificationType", b =>
                {
                    b.HasOne("Entities.User", "User")
                        .WithOne("NotificationType")
                        .HasForeignKey("Entities.NotificationType", "user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Notification_Count", b =>
                {
                    b.HasOne("Entities.User", "User")
                        .WithOne("Notification_Count")
                        .HasForeignKey("Entities.Notification_Count", "user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.User_article", b =>
                {
                    b.HasOne("Entities.User", "User")
                        .WithMany("User_article")
                        .HasForeignKey("user_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Entities.Food", b =>
                {
                    b.Navigation("My_Food");
                });

            modelBuilder.Entity("Entities.Fridge", b =>
                {
                    b.Navigation("My_Food");
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Navigation("Fridge");

                    b.Navigation("Notification");

                    b.Navigation("Notification_Count");

                    b.Navigation("NotificationType");

                    b.Navigation("User_article");
                });
#pragma warning restore 612, 618
        }
    }
}