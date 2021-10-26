using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alura.ListaLeitura.Seguranca
{
    internal class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasData(new Usuario {
                UserName = "admin",
                Email = "admin@example.org",
                PasswordHash = "AQAAAAEAACcQAAAAED0tb8N23CW0B1uLCmdSzL1kfJKD1NqSU6VxzkJ/ATsHW8awVv+bBSmNiACpNR9Iqw==",
            });
        }
    }
}