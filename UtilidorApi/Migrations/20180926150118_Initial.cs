using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UtilidorApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Utilities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UtilityId = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    CompleteTime = table.Column<DateTime>(nullable: false),
                    Numerator = table.Column<int>(nullable: true),
                    Denominator = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instances_Utilities_UtilityId",
                        column: x => x.UtilityId,
                        principalTable: "Utilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InstanceId = table.Column<int>(nullable: false),
                    Timestamp = table.Column<DateTime>(nullable: false),
                    Level = table.Column<int>(nullable: false),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Logs_Instances_InstanceId",
                        column: x => x.InstanceId,
                        principalTable: "Instances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instances_UtilityId",
                table: "Instances",
                column: "UtilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Logs_InstanceId",
                table: "Logs",
                column: "InstanceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Logs");

            migrationBuilder.DropTable(
                name: "Instances");

            migrationBuilder.DropTable(
                name: "Utilities");
        }
    }
}
