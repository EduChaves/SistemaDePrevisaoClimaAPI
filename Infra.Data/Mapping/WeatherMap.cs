using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Data.Mapping
{
    public class WeatherMap : IEntityTypeConfiguration<Weather>
    {
        public void Configure(EntityTypeBuilder<Weather> builder)
        {
            builder.Property(weather => weather.Id);
            builder.Property(weather => weather.Initials);
            builder.Property(weather => weather.Description);

            builder.HasData(
                new Weather { Id = 1, Initials = "ec", Description = "Encoberto com Chuvas Isoladas"},
                new Weather { Id = 2, Initials = "ci", Description = "Chuvas Isoladas" },
                new Weather { Id = 3, Initials = "c", Description = "Chuva" },
                new Weather { Id = 4, Initials = "in", Description = "Instável" },
                new Weather { Id = 5, Initials = "pp", Description = "Possibilidade de Pancadas de Chuva" },
                new Weather { Id = 6, Initials = "em", Description = "Chuva pela Manhã" },
                new Weather { Id = 7, Initials = "en", Description = "Chuva pela Noite" },
                new Weather { Id = 8, Initials = "pt", Description = "Pancadas de Chuva a Tarde" },
                new Weather { Id = 9, Initials = "pm", Description = "Pancadas de Chuva pela Manhã" },
                new Weather { Id = 10, Initials = "np", Description = "Nublado e Pancadas de Chuva" },
                new Weather { Id = 11, Initials = "pc", Description = "Pancadas de Chuva" },
                new Weather { Id = 12, Initials = "pn", Description = "Parcialmente Nublado" },
                new Weather { Id = 13, Initials = "cv", Description = "Chuvisco" },
                new Weather { Id = 14, Initials = "ch", Description = "Chuvoso" },
                new Weather { Id = 15, Initials = "t", Description = "Tempestade" },
                new Weather { Id = 16, Initials = "ps", Description = "Predomínio de Sol" },
                new Weather { Id = 17, Initials = "e", Description = "Encoberto" },
                new Weather { Id = 18, Initials = "n", Description = "Nublado" },
                new Weather { Id = 19, Initials = "cl", Description = "Céu Claro" },
                new Weather { Id = 20, Initials = "nv", Description = "Nevoeiro" },
                new Weather { Id = 21, Initials = "g", Description = "Geada" },
                new Weather { Id = 22, Initials = "ne", Description = "Neve" },
                new Weather { Id = 23, Initials = "pnt", Description = "Pancadas de Chuva a Noite" },
                new Weather { Id = 24, Initials = "psc", Description = "Possibilidade de Chuva" },
                new Weather { Id = 25, Initials = "pcm", Description = "Possibilidade de Chuva pela Manhã" },
                new Weather { Id = 26, Initials = "pct", Description = "Possibilidade de Chuva a Tarde" },
                new Weather { Id = 27, Initials = "pcn", Description = "Possibilidade de Chuva a Noite" },
                new Weather { Id = 28, Initials = "npt", Description = "Nublado com Pancadas a Tarde" },
                new Weather { Id = 29, Initials = "pcn", Description = "Nublado com Pacadas a Noite" },
                new Weather { Id = 30, Initials = "ncn", Description = "Nublado com Possibilidade de Chuva a Noite" },
                new Weather { Id = 31, Initials = "nct", Description = "Nublado com Possibilidade de Chuva a Tarde" },
                new Weather { Id = 32, Initials = "ncm", Description = "Nublado com Possibilidade de Chuva pela Manhã" },
                new Weather { Id = 33, Initials = "npm", Description = "Nublado com Pancadas pela Manhã" },
                new Weather { Id = 34, Initials = "npp", Description = "Nublado com Possibilidade de Chuva" },
                new Weather { Id = 35, Initials = "vn", Description = "Variação de Nebulosidade" },
                new Weather { Id = 36, Initials = "ct", Description = "Chuva a Tarde" },
                new Weather { Id = 37, Initials = "ppn", Description = "Possibilidade de Pancadas de Chuva a Noite" },
                new Weather { Id = 38, Initials = "ppt", Description = "Possibilidade de Pancadas de Chuva a Tarde" },
                new Weather { Id = 39, Initials = "ppm", Description = "Possibilidade de Pancadas de Chuva pela Manhã" },
                new Weather { Id = 40, Initials = "lt", Description = "Não Definido" }
            );

            builder.ToTable("Weather");
        }
    }
}
