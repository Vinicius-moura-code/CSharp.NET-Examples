using Microsoft.EntityFrameworkCore.Migrations;

namespace GenshinImpact.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConsumablesFood",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rarity = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Effect = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HasRecipe = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Proficiency = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumablesFood", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConsumablesPotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rarity = table.Column<int>(type: "int", nullable: false),
                    Effect = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumablesPotions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enemies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Faction = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mora_gained = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enemies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rarity = table.Column<int>(type: "int", nullable: false),
                    BaseAttack = table.Column<int>(type: "int", nullable: false),
                    SubStat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassiveName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubSpassiveDesctat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ConsumablesFoodId = table.Column<int>(type: "int", nullable: true),
                    ConsumablesPotionsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recipe_ConsumablesFood_ConsumablesFoodId",
                        column: x => x.ConsumablesFoodId,
                        principalTable: "ConsumablesFood",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Recipe_ConsumablesPotions_ConsumablesPotionsId",
                        column: x => x.ConsumablesPotionsId,
                        principalTable: "ConsumablesPotions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Artifacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Max_rarity = table.Column<int>(type: "int", nullable: false),
                    Two_piece_bonus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Four_piece__bonus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnemiesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artifacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artifacts_Enemies_EnemiesId",
                        column: x => x.EnemiesId,
                        principalTable: "Enemies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Constellations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unlock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    CharactersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constellations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PassiveTalents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unlock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<int>(type: "int", nullable: false),
                    CharactersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassiveTalents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillTalents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unlock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharactersId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillTalents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vision = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdWeapon = table.Column<int>(type: "int", nullable: false),
                    IdNation = table.Column<int>(type: "int", nullable: false),
                    Affiliation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rarity = table.Column<int>(type: "int", nullable: false),
                    IdConstellation = table.Column<int>(type: "int", nullable: false),
                    Birthday = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vision_key = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Constellations_IdConstellation",
                        column: x => x.IdConstellation,
                        principalTable: "Constellations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Weapons_IdWeapon",
                        column: x => x.IdWeapon,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Drops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Drop_min = table.Column<int>(type: "int", nullable: false),
                    Drop_max = table.Column<int>(type: "int", nullable: false),
                    DetailsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Elements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainsId = table.Column<int>(type: "int", nullable: true),
                    EnemiesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Elements_Enemies_EnemiesId",
                        column: x => x.EnemiesId,
                        principalTable: "Enemies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Elemental",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elemental", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Elemental_Elements_IdKey",
                        column: x => x.IdKey,
                        principalTable: "Elements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElementalDesciption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdElement = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnemiesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementalDesciption", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElementalDesciption_Elements_IdElement",
                        column: x => x.IdElement,
                        principalTable: "Elements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElementalDesciption_Enemies_EnemiesId",
                        column: x => x.EnemiesId,
                        principalTable: "Enemies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materials_Elements_IdType",
                        column: x => x.IdType,
                        principalTable: "Elements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdElement = table.Column<int>(type: "int", nullable: false),
                    Archon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ControllingEntity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nations_Elements_IdElement",
                        column: x => x.IdElement,
                        principalTable: "Elements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdElements = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElementalId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reactions_Elemental_ElementalId",
                        column: x => x.ElementalId,
                        principalTable: "Elemental",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reactions_Elements_IdElements",
                        column: x => x.IdElements,
                        principalTable: "Elements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Domains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdNation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Domains", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Domains_Nations_IdNation",
                        column: x => x.IdNation,
                        principalTable: "Nations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Requirements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<int>(type: "int", nullable: false),
                    AdventureRank = table.Column<int>(type: "int", nullable: false),
                    RecommendedLevel = table.Column<int>(type: "int", nullable: false),
                    LeyLineDisorder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requirements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requirements_Domains_DomainsId",
                        column: x => x.DomainsId,
                        principalTable: "Domains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rewards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DomainsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rewards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rewards_Domains_DomainsId",
                        column: x => x.DomainsId,
                        principalTable: "Domains",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<int>(type: "int", nullable: false),
                    AdventureExperience = table.Column<int>(type: "int", nullable: false),
                    CompanionshipExperience = table.Column<int>(type: "int", nullable: false),
                    Mora = table.Column<int>(type: "int", nullable: false),
                    RewardsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Details_Rewards_RewardsId",
                        column: x => x.RewardsId,
                        principalTable: "Rewards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artifacts_EnemiesId",
                table: "Artifacts",
                column: "EnemiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_IdConstellation",
                table: "Characters",
                column: "IdConstellation");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_IdNation",
                table: "Characters",
                column: "IdNation");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_IdWeapon",
                table: "Characters",
                column: "IdWeapon");

            migrationBuilder.CreateIndex(
                name: "IX_Constellations_CharactersId",
                table: "Constellations",
                column: "CharactersId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_RewardsId",
                table: "Details",
                column: "RewardsId");

            migrationBuilder.CreateIndex(
                name: "IX_Domains_IdNation",
                table: "Domains",
                column: "IdNation");

            migrationBuilder.CreateIndex(
                name: "IX_Drops_DetailsId",
                table: "Drops",
                column: "DetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Elemental_IdKey",
                table: "Elemental",
                column: "IdKey");

            migrationBuilder.CreateIndex(
                name: "IX_ElementalDesciption_EnemiesId",
                table: "ElementalDesciption",
                column: "EnemiesId");

            migrationBuilder.CreateIndex(
                name: "IX_ElementalDesciption_IdElement",
                table: "ElementalDesciption",
                column: "IdElement");

            migrationBuilder.CreateIndex(
                name: "IX_Elements_DomainsId",
                table: "Elements",
                column: "DomainsId");

            migrationBuilder.CreateIndex(
                name: "IX_Elements_EnemiesId",
                table: "Elements",
                column: "EnemiesId");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_IdType",
                table: "Materials",
                column: "IdType");

            migrationBuilder.CreateIndex(
                name: "IX_Nations_IdElement",
                table: "Nations",
                column: "IdElement");

            migrationBuilder.CreateIndex(
                name: "IX_PassiveTalents_CharactersId",
                table: "PassiveTalents",
                column: "CharactersId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_ElementalId",
                table: "Reactions",
                column: "ElementalId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_IdElements",
                table: "Reactions",
                column: "IdElements");

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_ConsumablesFoodId",
                table: "Recipe",
                column: "ConsumablesFoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_ConsumablesPotionsId",
                table: "Recipe",
                column: "ConsumablesPotionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Requirements_DomainsId",
                table: "Requirements",
                column: "DomainsId");

            migrationBuilder.CreateIndex(
                name: "IX_Rewards_DomainsId",
                table: "Rewards",
                column: "DomainsId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillTalents_CharactersId",
                table: "SkillTalents",
                column: "CharactersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Constellations_Characters_CharactersId",
                table: "Constellations",
                column: "CharactersId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PassiveTalents_Characters_CharactersId",
                table: "PassiveTalents",
                column: "CharactersId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillTalents_Characters_CharactersId",
                table: "SkillTalents",
                column: "CharactersId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Nations_IdNation",
                table: "Characters",
                column: "IdNation",
                principalTable: "Nations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Drops_Details_DetailsId",
                table: "Drops",
                column: "DetailsId",
                principalTable: "Details",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Elements_Domains_DomainsId",
                table: "Elements",
                column: "DomainsId",
                principalTable: "Domains",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Elements_Enemies_EnemiesId",
                table: "Elements");

            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Constellations_IdConstellation",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Domains_Nations_IdNation",
                table: "Domains");

            migrationBuilder.DropTable(
                name: "Artifacts");

            migrationBuilder.DropTable(
                name: "Drops");

            migrationBuilder.DropTable(
                name: "ElementalDesciption");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "PassiveTalents");

            migrationBuilder.DropTable(
                name: "Reactions");

            migrationBuilder.DropTable(
                name: "Recipe");

            migrationBuilder.DropTable(
                name: "Requirements");

            migrationBuilder.DropTable(
                name: "SkillTalents");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Elemental");

            migrationBuilder.DropTable(
                name: "ConsumablesFood");

            migrationBuilder.DropTable(
                name: "ConsumablesPotions");

            migrationBuilder.DropTable(
                name: "Rewards");

            migrationBuilder.DropTable(
                name: "Enemies");

            migrationBuilder.DropTable(
                name: "Constellations");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "Nations");

            migrationBuilder.DropTable(
                name: "Elements");

            migrationBuilder.DropTable(
                name: "Domains");
        }
    }
}
