using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleDeIncidente.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Incidentes",
                columns: table => new
                {
                    IdIncidente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(maxLength: 40, nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    Prazo = table.Column<DateTime>(nullable: false),
                    Situacao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidentes", x => x.IdIncidente);
                });

            migrationBuilder.CreateTable(
                name: "Interacoes",
                columns: table => new
                {
                    IdInteracao = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(nullable: false),
                    DataInteracao = table.Column<DateTime>(nullable: false),
                    IncidenteIdIncidente = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interacoes", x => x.IdInteracao);
                    table.ForeignKey(
                        name: "FK_Interacoes_Incidentes_IncidenteIdIncidente",
                        column: x => x.IncidenteIdIncidente,
                        principalTable: "Incidentes",
                        principalColumn: "IdIncidente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interacoes_IncidenteIdIncidente",
                table: "Interacoes",
                column: "IncidenteIdIncidente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interacoes");

            migrationBuilder.DropTable(
                name: "Incidentes");
        }
    }
}
