using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoApendizado.Models.ViewModels;

namespace ProjetoApendizado.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Incluir(UsuarioViewModel viewModel)
        {
            try
            {

                string teste = null;
                teste.Replace('.', ',');

                var retornoValidacao = ValidacaoViewModel(viewModel);
                if (retornoValidacao.Count() > 0)
                {
                    return Json(new { status = 404, erros = retornoValidacao.ToList() });
                }

                //CONVERTER_View_Model_PARA_MODEL

                //EXECUTAR_INSERT

                //RETORNAR_ALGUMA_SATISFACAO

                //Status
                return Json(new { status = 200, mensagem = "Usuário incluido com sucesso!" });


            }
            catch (Exception ex)
            {
                return Json(new { status = 500, mensagem = "Sistema temporariamente indisponivel, favor tente novamente mais tarde." });

            }
            //Validacao_basica_DO _View_Model

        }

        //METODOS_VALIDACAO

        private List<string> ValidacaoViewModel(UsuarioViewModel viewModel)
        {
            //Instanciar
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(viewModel.Nome))
            {
                erros.Add("Favor, preencha o nome do cliente");
            }

            if (viewModel.Idade == 0)
            {
                erros.Add("Favor, preencha a idade do cliente");
            }

            if (string.IsNullOrEmpty(viewModel.Cpf))
            {
                erros.Add("Favor, preencha  o Cpf do cliente");
            }

            if (viewModel.DatadeNascimeto == null || viewModel.DatadeNascimeto == DateTime.MinValue)
            {
                erros.Add("Favor, preencha  o Cpf do cliente");
            }

            return erros;
        }

        /*private UsuarioController ConverterViewModelToModel(UsuarioViewModel viewModel)
        {

        }*/


    }
}

/*
 * e criar o post ajax
 * 
 * Passar o error alert para o Spam
 */