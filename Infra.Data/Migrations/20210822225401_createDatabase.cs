using Microsoft.EntityFrameworkCore.Migrations;

namespace Infra.Data.Migrations
{
    public partial class createDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Initials = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "Id", "Description", "Initials" },
                values: new object[,]
                {
                    { 1, "Encoberto com Chuvas Isoladas", "ec" },
                    { 23, "Pancadas de Chuva a Noite", "pnt" },
                    { 24, "Possibilidade de Chuva", "psc" },
                    { 25, "Possibilidade de Chuva pela Manhã", "pcm" },
                    { 26, "Possibilidade de Chuva a Tarde", "pct" },
                    { 27, "Possibilidade de Chuva a Noite", "pcn" },
                    { 28, "Nublado com Pancadas a Tarde", "npt" },
                    { 29, "Nublado com Pacadas a Noite", "pcn" },
                    { 22, "Neve", "ne" },
                    { 30, "Nublado com Possibilidade de Chuva a Noite", "ncn" },
                    { 32, "Nublado com Possibilidade de Chuva pela Manhã", "ncm" },
                    { 33, "Nublado com Pancadas pela Manhã", "npm" },
                    { 34, "Nublado com Possibilidade de Chuva", "npp" },
                    { 35, "Variação de Nebulosidade", "vn" },
                    { 36, "Chuva a Tarde", "ct" },
                    { 37, "Possibilidade de Pancadas de Chuva a Noite", "ppn" },
                    { 38, "Possibilidade de Pancadas de Chuva a Tarde", "ppt" },
                    { 31, "Nublado com Possibilidade de Chuva a Tarde", "nct" },
                    { 21, "Geada", "g" },
                    { 20, "Nevoeiro", "nv" },
                    { 19, "Céu Claro", "cl" },
                    { 2, "Chuvas Isoladas", "ci" },
                    { 3, "Chuva", "c" },
                    { 4, "Instável", "in" },
                    { 5, "Possibilidade de Pancadas de Chuva", "pp" },
                    { 6, "Chuva pela Manhã", "em" },
                    { 7, "Chuva pela Noite", "en" },
                    { 8, "Pancadas de Chuva a Tarde", "pt" },
                    { 9, "Pancadas de Chuva pela Manhã", "pm" },
                    { 10, "Nublado e Pancadas de Chuva", "np" },
                    { 11, "Pancadas de Chuva", "pc" },
                    { 12, "Parcialmente Nublado", "pn" },
                    { 13, "Chuvisco", "cv" },
                    { 14, "Chuvoso", "ch" },
                    { 15, "Tempestade", "t" },
                    { 16, "Predomínio de Sol", "ps" },
                    { 17, "Encoberto", "e" },
                    { 18, "Nublado", "n" },
                    { 39, "Possibilidade de Pancadas de Chuva pela Manhã", "ppm" },
                    { 40, "Não Definido", "lt" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weather");
        }
    }
}
