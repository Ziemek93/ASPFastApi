using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ASPFastApi.Migrations
{
    /// <inheritdoc />
    public partial class initpostgres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    CategoryDescription = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryId = table.Column<int>(type: "integer", nullable: true),
                    ArticleName = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    ArticleDescription = table.Column<string>(type: "text", nullable: true),
                    Visibility = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                    table.ForeignKey(
                        name: "FK_Articles_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "ArticleTag",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "integer", nullable: false),
                    TagId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleTag", x => new { x.ArticleId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ArticleTag_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleTag_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    ArticleId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labo", "o imomc epcueduet oneuo rie ot snaloaroeea" },
                    { 2, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id ", "i  c em   opta olot octsepa" },
                    { 3, "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "sir vaa onioudrr ttn e v pfvlelella" },
                    { 4, "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla ", "ioar euttn  deiDl lesanpev  duiratiemco i " },
                    { 5, "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "reddarst rdq dls  dui eu" },
                    { 6, "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "tou ftstqbsleec" },
                    { 7, "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ", "v gsr re   eh trreDrlerurtuuprheaeemiiuilDrldtnum" },
                    { 8, "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla ", "op cmscqEi  e " },
                    { 9, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", " pr oecd tinloicc cn tu   ioufnf" },
                    { 10, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pari", "an looiivuocaincire ei xUisrstinmnerxca c dsa" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Title" },
                values: new object[,]
                {
                    { 1, "olTsls a TT" },
                    { 2, " rbaa WalWrTbaa" },
                    { 3, "W eosdW tbl t " },
                    { 4, "WTdllalras a" },
                    { 5, "abatatWdWddesa T " },
                    { 6, "abbabbbTralla" },
                    { 7, "abeaodlWstla blWWrs" },
                    { 8, "To b WT asabdaWT" },
                    { 9, "WaetlWreas" },
                    { 10, "aWs  alabbblW a" },
                    { 11, "Wo asdb" },
                    { 12, "ala l sal" },
                    { 13, "oTbdrW ab " },
                    { 14, "loda  aa  a odTb" },
                    { 15, "slTbrlrdsabbosdabl" },
                    { 16, " bsarTaa" },
                    { 17, " da l abtd l" },
                    { 18, "t o ssllbl la" },
                    { 19, "l o drb W  odeWa l" },
                    { 20, "borlo  lerW" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "ArticleDescription", "ArticleName", "CategoryId", "Visibility" },
                values: new object[,]
                {
                    { 1, "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "toaldetatoq mevoumqcsc  e iraq", 1, true },
                    { 2, "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "rlpeunl eaaDigphuu", 1, true },
                    { 3, "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", " uutsm sioiimmsaiso ouictaeqsi", 1, true },
                    { 4, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", " ati aito", 1, true },
                    { 5, "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "inavi i anxu", 1, true },
                    { 6, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "natel agliilon", 2, true },
                    { 7, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "xu ctarustri", 2, true },
                    { 8, "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "nf u ifi ed atoe a tsembl", 2, true },
                    { 9, "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "eide  pldtduas lsrul teseo one", 2, true },
                    { 10, "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "al mednu  nq mcoteia  aomiio r", 2, true },
                    { 11, "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "   nn lru lou ltttvn", 3, true },
                    { 12, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", " edp  rm mtn rssomsitoaarcn", 3, true },
                    { 13, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "qneuqqa otnUoivimdesuis illt", 3, true },
                    { 14, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "rerr  udnnvt  e r l  tlivutp a", 3, true },
                    { 15, "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "oo a oaimdnstt dsnlct refnlmcl", 3, true },
                    { 16, "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "nlmiat", 4, true },
                    { 17, "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "arcen iciipmxi  b", 4, true },
                    { 18, "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "din ndl eaea lo", 4, true },
                    { 19, "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", " nnepritiruu mu mi naieodniutr", 4, true },
                    { 20, "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "eevtiidsmalatt xdb o lxda", 4, true },
                    { 21, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "iuid ite", 5, true },
                    { 22, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "meceiil nio ico", 5, true },
                    { 23, "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "u ilrrn dra", 5, true },
                    { 24, "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", " umbsmadardnUsrcl", 5, true },
                    { 25, "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "lfsp noirio t a n t opcsnde no", 5, true },
                    { 26, "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "rsreervtilou u llr erupun", 6, true },
                    { 27, "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", " xisoxcmeppruE auoapaclicfin", 6, true },
                    { 28, "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "drtimsdnototidts udeiooruooidd", 6, true },
                    { 29, "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "amq uiecusdtbxUia mqooq urlroi", 6, true },
                    { 30, "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "inqoaiaicai ibeuqrn  ovac elne", 6, true },
                    { 31, "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "natcctx  n  iueolt tnb noblcnp", 7, true },
                    { 32, "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "s smueaimadngurgce uin iqesuee", 7, true },
                    { 33, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "a neutde rnfEi", 7, true },
                    { 34, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", "omtup aonip duiua", 7, true },
                    { 35, "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "mi mnerame c c", 7, true },
                    { 36, "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "i dei i pet  ltdctmo eaom ttei", 8, true },
                    { 37, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "ianaqop", 8, true },
                    { 38, "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "dlteraeau rrttiur sDe lDee", 8, true },
                    { 39, "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "ueomt ", 8, true },
                    { 40, "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "tgtceiu", 8, true },
                    { 41, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "olsusnad omisrs", 9, true },
                    { 42, "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "oe tp ti", 9, true },
                    { 43, "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "d un pp", 9, true },
                    { 44, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", " s lnut", 9, true },
                    { 45, "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "i e ooa autaougi   lvolravve ", 9, true },
                    { 46, "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", " aoiam itrti ri", 10, true },
                    { 47, "Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", " eataonrlcnim cttpl eitpintaec", 10, true },
                    { 48, "Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat", "uutaiooiedbunpctaae n tt", 10, true },
                    { 49, "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum. Lorem ipsum dolor sit amet  consectetur adipisicing elit sed do eiusmod tempor incididunt ut labore et dolore magna aliqua", "pcr l pd a", 10, true },
                    { 50, "Excepteur sint occaecat cupidatat non proident sunt in culpa qui officia deserunt mollit anim id est laborum", "tintro ds ei soeaeuirc nuex nt", 10, true }
                });

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
                    { 18, 13 },
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

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "ArticleId", "Content" },
                values: new object[,]
                {
                    { 1, 26, "dam uruapu  aurttebuofnanadtblrl  qpeianuuE rcnmieptudo f rsotcnolonit umreodndndoqcl t nao ecrtuatsimxrcoid pofai" },
                    { 2, 31, " tofnetplnfnciaeceelou ttouasm oracn lfu on cnmcinsre iuiiulcquu rixEtmramtaoiendftptedaafsllla cccataras uniuoox lu cfcostciic cictntittcrotoe Enmtfbst" },
                    { 3, 45, " etodi mnmurop bir o ridl xn  uxm uo" },
                    { 4, 26, "iu ia mtpesaoavapesit ie Dirutueeddguole" },
                    { 5, 4, "iupsu n op  t m   uuclaiixttf rt" },
                    { 6, 46, "tis uuatl aourn arelirduingn" },
                    { 7, 4, "cle u pdaen   ctEonionsiEcl e boitacari  maat cutntinecnstifdmc dpcn  fiuiaidacpa  bdalutidlanqitaq Ea ndcttuautectE utemo uotsElu ntt iuii ut ap" },
                    { 8, 17, " titol  rcttltnsu eepetotisianeruiertsm sdame ooae" },
                    { 9, 50, "rstrne  diiieeu  dtr astuhirtvutea  ealaeoet l" },
                    { 10, 11, "rdoca  tcerat ua oenaleixtsur qiclssinu  tqod uiosn tmnt bntidla sii b qimruq qcb atmaietaoxoirteleo aemisa u niua irneasq cuneco sitiacaiib" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_CategoryId",
                table: "Articles",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleTag_TagId",
                table: "ArticleTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleTag");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
