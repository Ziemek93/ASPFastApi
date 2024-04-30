using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASPFastApi.Migrations
{
    /// <inheritdoc />
    public partial class addedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 8, 5 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 8, 18 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 9, 17 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 13, 2 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 13, 11 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 14, 1 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 14, 20 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 19, 9 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 20, 8 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 21, 4 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 21, 9 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 22, 1 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 24, 18 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 25, 11 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 25, 14 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 25, 17 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 26, 16 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 27, 6 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 27, 15 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 28, 14 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 29, 10 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 29, 19 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 32, 17 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 33, 2 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 33, 17 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 34, 7 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 34, 8 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 35, 1 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 36, 3 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 37, 2 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 37, 19 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 39, 18 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 40, 4 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 41, 15 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 42, 2 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 42, 11 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 44, 12 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 45, 2 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 45, 8 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 45, 19 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 46, 17 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 47, 20 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 50, 6 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 50, 13 });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "ArticleTag",
                columns: new[] { "ArticleId", "TagId" },
                values: new object[,]
                {
                    { 1, 19 },
                    { 3, 11 },
                    { 6, 3 },
                    { 7, 7 },
                    { 9, 14 },
                    { 9, 16 },
                    { 11, 16 },
                    { 13, 12 },
                    { 13, 14 },
                    { 16, 10 },
                    { 16, 20 },
                    { 18, 1 },
                    { 18, 15 },
                    { 18, 18 },
                    { 20, 5 },
                    { 20, 17 },
                    { 21, 17 },
                    { 21, 20 },
                    { 22, 5 },
                    { 23, 10 },
                    { 24, 17 },
                    { 26, 7 },
                    { 27, 5 },
                    { 27, 20 },
                    { 28, 6 },
                    { 28, 10 },
                    { 28, 12 },
                    { 29, 18 },
                    { 30, 15 },
                    { 31, 8 },
                    { 32, 10 },
                    { 34, 19 },
                    { 36, 4 },
                    { 37, 16 },
                    { 38, 5 },
                    { 38, 10 },
                    { 39, 16 },
                    { 40, 11 },
                    { 40, 13 },
                    { 41, 16 },
                    { 42, 1 },
                    { 42, 8 },
                    { 46, 5 },
                    { 48, 20 },
                    { 49, 3 },
                    { 49, 15 },
                    { 49, 18 }
                });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "tqonneaiieu bp" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "a tru iudriiiip " });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3,
                column: "ArticleName",
                value: " ndn  mUox boltd xlmbuqnemuena");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "ier ta" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5,
                column: "ArticleName",
                value: "d upntge aoeea rtc nu anli eiu");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 6,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "Letidmeoiiiai io" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 7,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "rrusxeusirrde" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 8,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "i misiuere ru erinni audeleulf" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 9,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", " l ctixnetxi l" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 10,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "aprmeehea erup" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 11,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "aopilo uib ac isot sodedpoemip" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 12,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "bmisnta p  q ina tiue p" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 13,
                column: "ArticleName",
                value: "soaoetet cioxcstlrrbtsso tne f");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 14,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "ciiix ta" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 15,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "uinirae  ltee maua irilidddlnn" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 16,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "eeliipeurfeafrveu u erstr nodu" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 17,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "xttla Ulvqqt t Un uioots uddim" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 18,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "imodrdi qiau aeitldotsgoddt ld" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 19,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "dsl dc   lleu s  nsnqseb" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 20,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "msodntntnli biiiiurimc  fdtpin" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 21,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "acrcc ioreddd im icdd die r o " });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 22,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "d lttesci tdtelnom" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 23,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "exclso" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 24,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "raopio iului sdseutlrtpiltsaeu" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 25,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "trld g t" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 26,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "ssn euetosmmeoiina i xtiea" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 27,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "dadu lpadsiliit tmna" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 28,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "Llqsr dreuolid odaao " });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 29,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "elie ft  harioe  lcs vaooler" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 30,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", " oo i m mb mmdnostuoie nib " });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 31,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "tvitr lsu eudnuid ldrpnersmaap" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 32,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "lfu le eir t   oeeri lcanatadi" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 33,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "mcasmo ins o iasnnin  uisac ta" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 34,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "ioqrcqitn ecacuuc  xsedoi " });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 35,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "oieol c iosuourearD rial  esef" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 36,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", " aeiiteumitqa saqeda  s" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 37,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "a edr  rialimgon " });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 38,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "cstpor  ennccauoe loiepo dsu" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 39,
                column: "ArticleName",
                value: "ec cuucpu inmm smadmlai a alq");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 40,
                column: "ArticleName",
                value: "curarrrlriuiaetitcredaeanennln");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 41,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "ntru ep m   e nit aurl eD eout" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 42,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "rt lsma " });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 43,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "iul lsernrtpa ef hinlo  anaina" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 44,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "piqen n ui mt qnsua i i" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 45,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "t  ie mguti  sr ed  dleupaiiin" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 46,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "u Eisudoa i otc smpirauo " });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 47,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", " nontao" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 48,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "as  gtp oetgui epr o" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 49,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "oderocsLtaaoq" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 50,
                column: "ArticleName",
                value: "aoiat  enaotteurnenut");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "eiasct mtedlib " });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea co", "omstiilo nool pemasl nd u" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla ", "acnqo" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim", " e    a " });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nul", " m nEtldltunsinudannxinml arciittlefosi tci oomti" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea co", " teeutrciuele qpeue  oios aes  u   m" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut ", "ddtpasiam" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia des", "tt lerdollciol oluaslnuuleu" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "e r erteicdpupaa lodcltst rcdpltmo bd" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "c pr io lti ne et eemuanc " });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 50, "o uqv ne ltllmioan qaicestUd rtpeop ineiiqtvxtiranooaisad c sdestn raoem slbp qm pm  timmai uu aasodieooud osemnd man" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 26, "mnaaem qqobaictmoctdnuaio ea memrsi qsxnnrtuss bmuimmuacmc nmdmcdmstebaedciola itn   ciidsaoacuoisct ootovi roeieo qeieoimli ssi" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 12, "tolinoiccditatUrtssammiaamuaa  i xcldao dccxdnuepaq s  sq ssemieexmsuoiavxemnvai omqo loiuiiniuou" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 6, "tlteneut rqt  atdiamianuqu ili sainn m oi mti teonqoiir uiomolU ooi  uneimmiqau rrc  o  litqio tdbtuotqounasosa" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 20, "eeiidqeceitplgobnudm  tol puoanse i titorioieamiilu  isalaio" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 5, "unt asn iuteoteei ruilr iepsipr ies " });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 21, "ittmrta  nlcliicatla" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 13, "puanfnldtluctaaipuno eis ieui  ttt riomoui uErirplsoupieitbtaanrcosonltocaftnuu " });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 9,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 46, "ruaultutl aradlrim   l slanrirriuesniigtiilpdpeocaeuul" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 10,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 2, "druahoaldanauutaenvufmoltner  sl eavauetesnirluei asli lipuntniroall errtuioiahloi dnidouiov nelru  ruol ltilrepdeuointfuteuagusv uerphtlrutlin ora" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 1,
                column: "Title",
                value: "baalellalWbltT a");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 2,
                column: "Title",
                value: "l bWstblolrae");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 3,
                column: "Title",
                value: "ddd oa");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 4,
                column: "Title",
                value: " elToadtrbaabtoea");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 5,
                column: "Title",
                value: "a eeWsea");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 6,
                column: "Title",
                value: "a bWo");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 7,
                column: "Title",
                value: " eo WlTalb");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 8,
                column: "Title",
                value: "etttdl o");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 9,
                column: "Title",
                value: " r t lrs as");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 10,
                column: "Title",
                value: "be asab bTla   ");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 11,
                column: "Title",
                value: "Wte tosaobll");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 12,
                column: "Title",
                value: "serTbdWso TWrabr r");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 13,
                column: "Title",
                value: " oers d albaW  TlsW");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 14,
                column: "Title",
                value: "ltslbeodaab broetr ");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 15,
                column: "Title",
                value: "oTaWera d");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 16,
                column: "Title",
                value: "as bsell  detl");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 17,
                column: "Title",
                value: "a dlldaslta");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 18,
                column: "Title",
                value: "sebtoaealter ol Wa");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 19,
                column: "Title",
                value: "earsdoW");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 20,
                column: "Title",
                value: "aadtllrorrbTb lao a");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 1, 19 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 9, 14 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 9, 16 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 11, 16 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 13, 12 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 13, 14 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 16, 10 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 16, 20 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 18, 1 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 18, 15 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 18, 18 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 20, 5 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 20, 17 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 21, 17 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 21, 20 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 22, 5 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 23, 10 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 24, 17 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 26, 7 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 27, 5 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 27, 20 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 28, 6 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 28, 10 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 28, 12 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 29, 18 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 30, 15 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 31, 8 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 32, 10 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 34, 19 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 36, 4 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 37, 16 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 38, 5 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 38, 10 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 39, 16 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 40, 11 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 40, 13 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 41, 16 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 42, 1 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 42, 8 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 46, 5 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 48, 20 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 49, 3 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 49, 15 });

            migrationBuilder.DeleteData(
                table: "ArticleTag",
                keyColumns: new[] { "ArticleId", "TagId" },
                keyValues: new object[] { 49, 18 });

            migrationBuilder.InsertData(
                table: "ArticleTag",
                columns: new[] { "ArticleId", "TagId" },
                values: new object[,]
                {
                    { 2, 5 },
                    { 6, 6 },
                    { 8, 5 },
                    { 8, 18 },
                    { 9, 17 },
                    { 12, 12 },
                    { 13, 2 },
                    { 13, 11 },
                    { 14, 1 },
                    { 14, 20 },
                    { 19, 9 },
                    { 20, 8 },
                    { 21, 4 },
                    { 21, 9 },
                    { 22, 1 },
                    { 24, 18 },
                    { 25, 11 },
                    { 25, 14 },
                    { 25, 17 },
                    { 26, 16 },
                    { 27, 6 },
                    { 27, 15 },
                    { 28, 14 },
                    { 29, 10 },
                    { 29, 19 },
                    { 32, 17 },
                    { 33, 2 },
                    { 33, 17 },
                    { 34, 7 },
                    { 34, 8 },
                    { 35, 1 },
                    { 36, 3 },
                    { 37, 2 },
                    { 37, 19 },
                    { 39, 18 },
                    { 40, 4 },
                    { 41, 15 },
                    { 42, 2 },
                    { 42, 11 },
                    { 44, 12 },
                    { 45, 2 },
                    { 45, 8 },
                    { 45, 19 },
                    { 46, 17 },
                    { 47, 20 },
                    { 50, 6 },
                    { 50, 13 }
                });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "toaldetatoq mevoumqcsc  e iraq" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "rlpeunl eaaDigphuu" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3,
                column: "ArticleName",
                value: " uutsm sioiimmsaiso ouictaeqsi");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", " ati aito" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 5,
                column: "ArticleName",
                value: "inavi i anxu");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 6,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "natel agliilon" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 7,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "xu ctarustri" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 8,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "nf u ifi ed atoe a tsembl" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 9,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "eide  pldtduas lsrul teseo one" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 10,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "al mednu  nq mcoteia  aomiio r" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 11,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "   nn lru lou ltttvn" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 12,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", " edp  rm mtn rssomsitoaarcn" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 13,
                column: "ArticleName",
                value: "qneuqqa otnUoivimdesuis illt");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 14,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "rerr  udnnvt  e r l  tlivutp a" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 15,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "oo a oaimdnstt dsnlct refnlmcl" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 16,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "nlmiat" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 17,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "arcen iciipmxi  b" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 18,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "din ndl eaea lo" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 19,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", " nnepritiruu mu mi naieodniutr" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 20,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "eevtiidsmalatt xdb o lxda" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 21,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "iuid ite" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 22,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "meceiil nio ico" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 23,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "u ilrrn dra" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 24,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", " umbsmadardnUsrcl" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 25,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "lfsp noirio t a n t opcsnde no" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 26,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "rsreervtilou u llr erupun" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 27,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", " xisoxcmeppruE auoapaclicfin" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 28,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "drtimsdnototidts udeiooruooidd" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 29,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "amq uiecusdtbxUia mqooq urlroi" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 30,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "inqoaiaicai ibeuqrn  ovac elne" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 31,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "natcctx  n  iueolt tnb noblcnp" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 32,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "s smueaimadngurgce uin iqesuee" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 33,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "a neutde rnfEi" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 34,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "omtup aonip duiua" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 35,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "mi mnerame c c" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 36,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "i dei i pet  ltdctmo eaom ttei" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 37,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "ianaqop" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 38,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "dlteraeau rrttiur sDe lDee" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 39,
                column: "ArticleName",
                value: "ueomt ");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 40,
                column: "ArticleName",
                value: "tgtceiu");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 41,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "olsusnad omisrs" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 42,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "oe tp ti" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 43,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "d un pp" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 44,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", " s lnut" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 45,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "i e ooa autaougi   lvolravve " });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 46,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", " aoiam itrti ri" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 47,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", " eataonrlcnim cttpl eitpintaec" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 48,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "uutaiooiedbunpctaae n tt" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 49,
                columns: new[] { "ArticleDescription", "ArticleName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "pcr l pd a" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 50,
                column: "ArticleName",
                value: "tintro ds ei soeaeuirc nuex nt");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labo", "o imomc epcueduet oneuo rie ot snaloaroeea" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id ", "i  c em   opta olot octsepa" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "sir vaa onioudrr ttn e v pfvlelella" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla ", "ioar euttn  deiDl lesanpev  duiratiemco i " });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "reddarst rdq dls  dui eu" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "tou ftstqbsleec" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ", "v gsr re   eh trreDrlerurtuuprheaeemiiuilDrldtnum" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla ", "op cmscqEi  e " });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 9,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", " pr oecd tinloicc cn tu   ioufnf" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 10,
                columns: new[] { "CategoryDescription", "CategoryName" },
                values: new object[] { "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pari", "an looiivuocaincire ei xUisrstinmnerxca c dsa" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 26, "dam uruapu  aurttebuofnanadtblrl  qpeianuuE rcnmieptudo f rsotcnolonit umreodndndoqcl t nao ecrtuatsimxrcoid pofai" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 31, " tofnetplnfnciaeceelou ttouasm oracn lfu on cnmcinsre iuiiulcquu rixEtmramtaoiendftptedaafsllla cccataras uniuoox lu cfcostciic cictntittcrotoe Enmtfbst" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 45, " etodi mnmurop bir o ridl xn  uxm uo" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 26, "iu ia mtpesaoavapesit ie Dirutueeddguole" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 4, "iupsu n op  t m   uuclaiixttf rt" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 46, "tis uuatl aourn arelirduingn" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 4, "cle u pdaen   ctEonionsiEcl e boitacari  maat cutntinecnstifdmc dpcn  fiuiaidacpa  bdalutidlanqitaq Ea ndcttuautectE utemo uotsElu ntt iuii ut ap" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 17, " titol  rcttltnsu eepetotisianeruiertsm sdame ooae" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 9,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 50, "rstrne  diiieeu  dtr astuhirtvutea  ealaeoet l" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 10,
                columns: new[] { "ArticleId", "Content" },
                values: new object[] { 11, "rdoca  tcerat ua oenaleixtsur qiclssinu  tqod uiosn tmnt bntidla sii b qimruq qcb atmaietaoxoirteleo aemisa u niua irneasq cuneco sitiacaiib" });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 1,
                column: "Title",
                value: "olTsls a TT");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 2,
                column: "Title",
                value: " rbaa WalWrTbaa");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 3,
                column: "Title",
                value: "W eosdW tbl t ");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 4,
                column: "Title",
                value: "WTdllalras a");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 5,
                column: "Title",
                value: "abatatWdWddesa T ");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 6,
                column: "Title",
                value: "abbabbbTralla");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 7,
                column: "Title",
                value: "abeaodlWstla blWWrs");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 8,
                column: "Title",
                value: "To b WT asabdaWT");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 9,
                column: "Title",
                value: "WaetlWreas");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 10,
                column: "Title",
                value: "aWs  alabbblW a");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 11,
                column: "Title",
                value: "Wo asdb");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 12,
                column: "Title",
                value: "ala l sal");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 13,
                column: "Title",
                value: "oTbdrW ab ");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 14,
                column: "Title",
                value: "loda  aa  a odTb");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 15,
                column: "Title",
                value: "slTbrlrdsabbosdabl");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 16,
                column: "Title",
                value: " bsarTaa");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 17,
                column: "Title",
                value: " da l abtd l");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 18,
                column: "Title",
                value: "t o ssllbl la");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 19,
                column: "Title",
                value: "l o drb W  odeWa l");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 20,
                column: "Title",
                value: "borlo  lerW");
        }
    }
}
