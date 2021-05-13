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
                if (string.IsNullOrEmpty(NomeUsuario))
                {
                    return _db.Usuarios.Where(x => x.Ativo == true).ToList();
                }
                else
                {
                    return _db.Usuarios.Where(x => x.Nome.Contains(NomeUsuario) && x.Ativo == true).ToList();
                }

            }
            catch (Exception)
            {

                return new List<Usuario>();
            }
        }

        public bool Deletar(int Id)
        {
            try
            {
                var result = false;
                var item = _db.Usuarios.Find(Id);

                if (item != null)
                {
                    _db.Usuarios.Remove(item);
                    _db.SaveChanges();

                    result = true;
                }
                //Salvar alterações

                return result;
            }
            catch
            {
                return false;
            }

        }
        public bool Inativar(int Id)
        {
            try
            {
                var item = _db.Usuarios.Find(Id);


                item.Ativo = false;

                _db.SaveChanges();


                //Salvar alterações

                return true;
            }
            catch
            {
                return false;
            }

        }
        public Usuario BuscarUsuarioPorId(int Id)
        {
            try
            {
                var item = _db.Usuarios.Find(Id);

                return item;



                //Salvar alterações

            }
            catch
            {
                return new Usuario();
            }

        }

        public bool  Alterar(Usuario model)
        {
            try
            {
               // var usuario = _db.Usuarios.Where();
                //ADD -> INSERT INTO
                //_db.Entry(usuario).CurrentValues.SetValues(model);

                //Salvar alterações
                _db.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }

        }
        //public bool Editar(int Id)
        //{
        //    try
        //    {
        //        var result = false;
        //        var item = _db.Usuarios.Find(Id);

        //        if (item != null)
        //        {
        //            _db.Usuarios.Find(item);
        //            _db.SaveChanges();

        //            result = true;
        //        }

        //        //Salvar alterações

        //        return result;
        //    }
        //    catch
        //    {
        //        return false;
        //    }

        //}
    }
}