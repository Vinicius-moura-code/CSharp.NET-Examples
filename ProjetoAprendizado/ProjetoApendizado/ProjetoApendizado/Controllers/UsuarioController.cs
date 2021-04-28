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

        // url (americanas.com.br/Usuario(CONTROLLER)/Incluir(METODO))
        //
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //tipo(public, private), retorno(bool, string..) e Nome (IncluirUsuario)

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

                //var teste = "Rafael Nascimento."
                //replace('.',',') -> Rafael Nascimento,

                //VALIDAÇÃO_BASICA_DO_VIEW_MODEL
                var retornoValidacao = ValidacaoViewModel(viewModel);

                if (retornoValidacao.Count() > 0)
                    return Json(new { status = 404, erros = retornoValidacao.ToList() });

                //COMVERTER_VIEWMODEL_PARA_MODEL

                //EXECUTAR_INSERT_NO_BANCO

                //RETORNAR_ALGUMA_SATISFAÇÃO OU RETORNAR_UMA_NEGAÇÃO

                // Status, Valor (N valores , N tipos), Mensagem (Opcional)
                return Json(new { status = 200, mensagem = "Usuário Incluído com sucesso!" });
            }
            catch (Exception ex)
            {
                return Json(new { status = 500, mensagem = "Sistema temporariamente indisponível, favor tente novamente mais tarde!" });
            }
        }


        //METODOS_VALIDAÇÃO

        private List<string> ValidacaoViewModel(UsuarioViewModel viewModel)
        {
            //List<string> erros;
            //Não instanciou, então valor = null;

            //Após instanciar ele vai receber o proprio valor inicial = Count = 0;
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(viewModel.Nome))
            {
                erros.Add("Favor preencha o Nome do cliente.");
            }

            if (viewModel.Idade == 0)
            {
                erros.Add("Favor preencha a Idade do cliente");
            }

            if (string.IsNullOrEmpty(viewModel.Cpf))
            {
                erros.Add("Favor preencha o Cpf do cliente");
            }

            //{01/01/0001}
            if (viewModel.DatadeNascimeto == null || viewModel.DatadeNascimeto == DateTime.MinValue)
            {
                erros.Add("Favor preencha a Data de Nascimento do cliente");
            }
            return erros;
        }

        //private Usuario ConverterViewModelToModel(UsuarioViewModel viewModel)
        //{

        //}
    }
}