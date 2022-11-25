using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Killar.Migrations
{
    public partial class CreateKillarDataBase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 60, nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    LoginWr = table.Column<string>(maxLength: 40, nullable: true),
                    LoginName = table.Column<string>(maxLength: 40, nullable: true),
                    Password = table.Column<string>(maxLength: 100, nullable: true),
                    CheckedPassword = table.Column<string>(maxLength: 100, nullable: true),
                    Lane = table.Column<string>(maxLength: 40, nullable: true),
                    Elo = table.Column<string>(maxLength: 40, nullable: true),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Author = table.Column<string>(maxLength: 60, nullable: true),
                    Content = table.Column<string>(nullable: true),
                    PostDate = table.Column<DateTime>(nullable: false),
                    UsersId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posters_Usuarios_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Author = table.Column<string>(maxLength: 100, nullable: true),
                    Content = table.Column<string>(maxLength: 500, nullable: true),
                    CommentDate = table.Column<DateTime>(nullable: false),
                    PostsId = table.Column<int>(nullable: false),
                    UsersId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comentarios_Posters_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comentarios_Usuarios_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_PostsId",
                table: "Comentarios",
                column: "PostsId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_UsersId",
                table: "Comentarios",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Posters_UsersId",
                table: "Posters",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "Posters");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
