using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ProjetoApendizado.Models;

namespace ProjetoApendizado.Repository
{
    public class ProjetoAprendizadoContext : DbContext
    {
        //COMANDOS MIGRATION

        //Enable-Migrations -> Habilitar o migration para utilização e irá criar um arquivo chamado Configuration
        //Add-Migration Initial(Nome qqr)... Estrutura de classe migration Initial_20042021.cs
        //Update_Database -> Respondavel por execultar o migration, == criar as tabelas.
        public ProjetoAprendizadoContext() : base("ProjetoAprendizadoSqlServer")
        {
            //Initial
            Database.SetInitializer<ProjetoAprendizadoContext>(null);
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Sexo> Sexos { get; set; }
    }
}