using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoApendizado.Models;

namespace ProjetoApendizado.Repository.Services
{
    public class SexoService
    {
        private readonly ProjetoAprendizadoContext _db;

        public SexoService()
        {
            _db = new ProjetoAprendizadoContext();
        }

        public List<Sexo> BuscarTodosSexos()
        {

            try
            {
                var sexo = _db.Sexos.ToList();

                return sexo;
            }
            catch
            {
                throw;
            }
        }
    }
}