using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Alura.ListaLeitura.Seguranca
{
    public class AuthDbContext : IdentityDbContext<Usuario>
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options)
            : base(options)
        {
            //irá criar o banco e a estrutura de tabelas necessárias
            this.Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration<Usuario>(new UsuarioConfiguration());
        }
    }
}
