using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoApendizado.Models;

namespace ProjetoApendizado.Repository.Services
{

    public class UsuarioServices
    {
        private readonly ProjetoAprendizadoContext _db;

        public UsuarioServices()
        {
            _db = new ProjetoAprendizadoContext();
        }

        public bool Inserir(Usuario model)
        {
            try
            {
                //ADD -> INSERT INTO
                _db.Usuarios.Add(model);

                //Salvar alterações
                _db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }

        }

        public List<Usuario> BuscarUsuarioPorNome(string NomeUsuario)
        {
            try
            {
                if(string.IsNullOrEmpty(NomeUsuario))
                {
                    return _db.Usuarios.ToList();
                }
                else
                {
                    return _db.Usuarios.Where(x => x.Nome.Contains(NomeUsuario)).ToList();
                }

            }
            catch (Exception)
            {

                return new List<Usuario>();
            }
        }
    }
}