using Alura.ListaLeitura.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alura.ListaLeitura.Persistencia
{
    internal class LivroConfiguration : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder
                .Property(l => l.Titulo)
                .HasColumnType("nvarchar(50)")
                .IsRequired();

            builder
                .Property(l => l.Subtitulo)
                .HasColumnType("nvarchar(75)");

            builder
                .Property(l => l.Resumo)
                .HasColumnType("nvarchar(500)");

            builder
                .Property(l => l.Autor)
                .HasColumnType("nvarchar(75)");

            builder
                .Property(l => l.ImagemCapa);

            builder
                .Property(l => l.Lista)
                .HasColumnType("nvarchar(10)")
                .IsRequired()
                .HasConversion<string>(
                    tipo => tipo.ParaString(),
                    texto => texto.ParaTipo()
                );
        }
    }
}