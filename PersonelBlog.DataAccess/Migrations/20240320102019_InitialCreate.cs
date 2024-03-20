using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalBlog.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutMe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Job = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    JobFA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CVUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutMe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SecurityQuestion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SecurityQuestionAnswer = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CategoryFA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShortAdress = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    LongAdress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    School = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Avarage = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomePageSliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ShortContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePageSliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Text = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiteIdentity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Keywords = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Description = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    LogoText = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LogoFA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteIdentity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PercentageValue = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialMediaAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Account = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AccountFA = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AccountUrl = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMediaAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Summary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "NVARCHAR(500)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summary", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ShortContent = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    SeoTags = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SeoDescription = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Article_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Text = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_Article_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Article",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AboutMe",
                columns: new[] { "Id", "BirthDate", "CVUrl", "CreatedBy", "CreatedTime", "FirstName", "ImageUrl", "IsActive", "IsDelete", "Job", "JobFA", "LastName", "ModifiedBy", "ModifiedTime" },
                values: new object[] { 1, new DateTime(1996, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(5387), "İbrahim", "", false, false, "Software Developer", "<i class=\"fa-solid fa-laptop-code\"></i>", "Çınğı", "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(5387) });

            migrationBuilder.InsertData(
                table: "Admin",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Email", "IsActive", "IsDelete", "ModifiedBy", "ModifiedTime", "Password", "SecurityQuestion", "SecurityQuestionAnswer" },
                values: new object[] { 1, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(6774), "ibrahmcingi@gmail.com", false, false, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(6775), "0a03d005fde3340906dc104434906a46", "Anne Kızlık Soyadı", "d10de61f3ecca60a812b7f13f820fe8d" });

            migrationBuilder.InsertData(
                table: "ContactInfo",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Email", "IsActive", "IsDelete", "LongAdress", "ModifiedBy", "ModifiedTime", "PhoneNumber", "ShortAdress" },
                values: new object[] { 1, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(9119), "ibrahmcingi@gmail.com", false, false, "Bağlaraltı Mah. Erikli Cad. A302. Sokak Erikli Evleri Kat:5 D:23", "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(9120), "+905319857784", "Yıldırım/BURSA" });

            migrationBuilder.InsertData(
                table: "Education",
                columns: new[] { "Id", "Avarage", "CreatedBy", "CreatedTime", "Description", "Duration", "IsActive", "IsDelete", "ModifiedBy", "ModifiedTime", "School", "Title" },
                values: new object[] { 1, "2.59", "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(8040), "1 sene ingilizce hazırlık olmak üzere %30 ingilizce mekatronik mühendisliği eğitimimi tamamladım.", "2014-2021", false, false, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(8041), "Kocaeli Mekatronik Mühendisliği", "Lisans" });

            migrationBuilder.InsertData(
                table: "Experiences",
                columns: new[] { "Id", "CompanyName", "CreatedBy", "CreatedTime", "Description", "Duration", "IsActive", "IsDelete", "ModifiedBy", "ModifiedTime", "Title" },
                values: new object[,]
                {
                    { 1, "Altesa Mühendislik", "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(1728), "CREO ile Makine kaynak montaj fikstürlerinin 3D modellerin hazırlanması, imalat için 2D teknik resimlerinin, montaj resimlerinin hazırlanması", "06.2016/09.2016", false, false, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(1729), "STAJ - ENDİSTÜRİYEL MAKİNE TASARIMI" },
                    { 2, "SANPARK SMART PARKING SYSTEM", "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(1740), "Solidwork ile akıllı katlı otopark sistemlerinin AR-GE’si. 3D modellerinin yapılması, 2D teknik çizimlerinin  Hazırlanması. Iso 9001 -2018 Kapsamında şirketin kalite kontrol sisteminin kurulması, makinelerin bakım ve kontrollerinin planlanması.", "07.2021/07.2022", false, false, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(1741), "SANPARK - ENDİSTÜRİYEL MAKİNE TASARIMI" },
                    { 3, "NiceTry Games Studio", "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(1746), "Unity ile sıfırdan oyun prototipleri hazırlama, c# diliyle yeniden kullanılabilir, temiz, SOLID prensiplerine uygun kodlarının hazırlanması. Level ve UI Tasarımlarının yapılması.", "07.2022/03.2024", false, false, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(1746), "NiceTry Games Studio - OYUN YAZILIMCISI" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "IsActive", "IsDelete", "ModifiedBy", "ModifiedTime", "Text" },
                values: new object[,]
                {
                    { 1, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 637, DateTimeKind.Local).AddTicks(7025), false, false, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 637, DateTimeKind.Local).AddTicks(7026), "Bilgisayar Donanımları, Bileşenleri ve Yazılımları" },
                    { 2, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 637, DateTimeKind.Local).AddTicks(7037), false, false, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 637, DateTimeKind.Local).AddTicks(7038), "Vizyon filmleri takip etmek ve izlemek, Film incelemelerini okumak" }
                });

            migrationBuilder.InsertData(
                table: "HomePageSliders",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedTime", "IsActive", "IsDelete", "ModifiedBy", "ModifiedTime", "ShortContent", "Title" },
                values: new object[] { 1, "Unity ile sıfırdan oyun prototipleri hazırlama, c# diliyle yeniden kullanılabilir, temiz, SOLID prensiplerine uygun kodlarının hazırlanması. Level ve UI Tasarımlarının yapılması.", "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 637, DateTimeKind.Local).AddTicks(9522), false, false, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 637, DateTimeKind.Local).AddTicks(9523), "Unity Oyun Motoru Ile Oyun Geliştirilmesi", "Unity Game Developer" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Email", "FirstName", "IsActive", "IsDelete", "LastName", "ModifiedBy", "ModifiedTime", "Subject", "Text" },
                values: new object[] { 1, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(2858), "test@gmail.com", "Hasan", false, false, "Erdal", "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(2858), "Test", "Test" });

            migrationBuilder.InsertData(
                table: "SiteIdentity",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Description", "IsActive", "IsDelete", "Keywords", "LogoFA", "LogoText", "ModifiedBy", "ModifiedTime", "Title" },
                values: new object[] { 1, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(4113), "Ibrahim Çınğı Developer", false, false, "C#, NET, WEB, SOFTWARE, .NET", "<i class= \"fas fa-h-square\"></i>", "İbrahim Çınğı", "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(4114), "İbrahim Çınğı" });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "IsActive", "IsDelete", "ModifiedBy", "ModifiedTime", "PercentageValue", "Title" },
                values: new object[] { 1, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(576), false, false, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 638, DateTimeKind.Local).AddTicks(577), 90, "C#" });

            migrationBuilder.InsertData(
                table: "SocialMediaAccounts",
                columns: new[] { "Id", "Account", "AccountFA", "AccountUrl", "CreatedBy", "CreatedTime", "IsActive", "IsDelete", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { 1, "Linkedin", "<i class=\"fa-brands fa-linkedin\"></i>", "https://www.linkedin.com/in/ibrahim-cingi/", "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 637, DateTimeKind.Local).AddTicks(8351), false, false, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 637, DateTimeKind.Local).AddTicks(8352) },
                    { 2, "Instagram", "<i class=\"fa-brands fa-instagram\"></i>", "https://www.instagram.com/ibrahimcngi", "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 637, DateTimeKind.Local).AddTicks(8365), false, false, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 637, DateTimeKind.Local).AddTicks(8366) },
                    { 3, "Github", "<i class=\"fa-brands fa-github\"></i>", "https://www.github.com/Roestee", "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 637, DateTimeKind.Local).AddTicks(8370), false, false, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 637, DateTimeKind.Local).AddTicks(8370) }
                });

            migrationBuilder.InsertData(
                table: "Summary",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedTime", "IsActive", "IsDelete", "ModifiedBy", "ModifiedTime" },
                values: new object[] { 1, "Content", "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 637, DateTimeKind.Local).AddTicks(5989), false, false, "InitialCreated", new DateTime(2024, 3, 20, 13, 20, 18, 637, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.CreateIndex(
                name: "IX_Article_CategoryId",
                table: "Article",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_ArticleId",
                table: "Comment",
                column: "ArticleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutMe");

            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "ContactInfo");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "HomePageSliders");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "SiteIdentity");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "SocialMediaAccounts");

            migrationBuilder.DropTable(
                name: "Summary");

            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
