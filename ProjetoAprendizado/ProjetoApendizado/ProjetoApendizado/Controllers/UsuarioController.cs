using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoApendizado.Models;
using ProjetoApendizado.Models.ViewModels;
using ProjetoApendizado.Repository.Services;

namespace ProjetoApendizado.Controllers
{
    public class UsuarioController : Controller
    {

        // url (americanas.com.br/Usuario(CONTROLLER)/Incluir(METODO))
        private readonly UsuarioServices _service;
        //

        public UsuarioController()
        {
            _service = new UsuarioServices();
        }



        [HttpGet]
        public ActionResult Index()
        {
            return View();

        }

        //tipo(public, private), retorno(bool, string..) e Nome (IncluirUsuario)
        #region METODO_INCLUIR
        [HttpGet]
        public ActionResult Incluir()
        {
            //List<SexoViewModels> viewModel = new List<SexoViewModels>();

            //var todosSexos = new SexoService().BuscarTodosSexos();

            //foreach (var item in todosSexos)
            //{
            //    viewModel.Add(new SexoViewModels
            //    {
            //        Descricao = item.Descricao,
            //        Id = item.Id
            //    )};

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

                var usuario = ConverterViewModelToModel(viewModel);

                //EXECUTAR_INSERT_NO_BANCO


                bool valida = _service.Inserir(usuario);

                if (valida)
                {
                    return Json(new { status = 200, mensagem = "Usuário Incluído com sucesso!" });

                }
                else
                {
                    return Json(new { status = 500, mensagem = "Erro interno" });

                }

                //RETORNAR_ALGUMA_SATISFAÇÃO OU RETORNAR_UMA_NEGAÇÃO

                // Status, Valor (N valores , N tipos), Mensagem (Opcional)
            }
            catch (Exception ex)
            {
                return Json(new { status = 500, mensagem = "Sistema temporariamente indisponível, favor tente novamente mais tarde!" });
            }
        }
        #endregion

        #region METODOS_BUSCAS
        [HttpGet]
        public ActionResult Buscar()
        {


            return View();
        }

        [HttpPost]
        public ActionResult Buscar(string NomeUsuario)
        {
            List<UsuarioViewModel> viewModel = new List<UsuarioViewModel>();

            try
            {

                //BUsca_de_users
                var listaUsuarios = _service.BuscarUsuarioPorNome(NomeUsuario);

                //Converter_viewmodel_to_model

                foreach (var item in listaUsuarios)
                {
                    viewModel.Add(new UsuarioViewModel
                    {
                        Nome = item.Nome,
                        Cpf = item.Cpf,
                        Idade = item.Idade,
                        Id = item.Id
                    }); 


                }
                //Msg de reorno
                return Json(new { status = 200, objeto = listaUsuarios });

            }
            catch (Exception)
            {

                return Json(new { status = 500, mensagem = "Sistema temporiamente indicponivel!!" });
            }
        }

        #endregion

        //Criar novo metodo deletar em usuario service e deletar pelo campo ID

        //Verificar se voutou true e fazer o tratamentp

        [HttpPost]
        public ActionResult Deletar(int Id)
        {
            //CRIAR NOVO MÉTODO DELETAR EM USUARIOSERVICE (BOLEANO) E DELETAR PELO CAMPO ID.
            try
            {

                //COMVERTER_VIEWMODEL_PARA_MODEL

                var item = ConverterViewModelToMOdel(Id);

                //EXECUTAR_DELETE_NO_BANCO


                bool valida = _service.Inativar(Id);

                if (valida)
                {
                    return Json(new { status = 200, mensagem = "Usuário excluido com sucesso!" });

                }
                else
                {
                    return Json(new { status = 500, mensagem = "Erro interno" });

                }

                //RETORNAR_ALGUMA_SATISFAÇÃO OU RETORNAR_UMA_NEGAÇÃO

                // Status, Valor (N valores , N tipos), Mensagem (Opcional)
            }
            catch (Exception)
            {
                return Json(new { status = 500, mensagem = "Sistema temporariamente indisponível, favor tente novamente mais tarde!" });
                throw;
            }
            //VERIFICAR SE RETORNOU TRUE E FAZER O TRATAMENTO DO RETORNO NO JQUERY.
        }

        //public boll 

        //METODOS_VALIDAÇÃO
        #region Editar
        [HttpGet]
        public ActionResult Editar(int Id)
        {
            UsuarioViewModel viewModel = new UsuarioViewModel();
            var item = _service.BuscarUsuarioPorId(Id);


            
            var usuario = ConverterViewModelToModel(viewModel);

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Editar(Usuario model)
        {
            try
            {
                return Json(new { status = 200, mensagem = "GG" });

            }
            catch (Exception)
            {
                return Json(new { status = 500, mensagem = "Sistema temporiamente indicponivel!!" });

                throw;
            }

        }

        #endregion


        #region METODOS_PRIVADOS
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
        //private List<string> ValidacaoViewModel(string NomeUsuario)
        //{
        //    List<string> erros = new List<string>();

        //    if (string.IsNullOrEmpty(NomeUsuario))
        //    {
        //        erros.Add("Preencha o nome do usuario");
        //    }

        //    return erros;

        //}

        private Usuario ConverterViewModelToModel(UsuarioViewModel viewModel)
        {
            Usuario model = new Usuario();

            model.Cpf = viewModel.Cpf;
            model.DatadeNascimeto = viewModel.DatadeNascimeto;
            model.Idade = viewModel.Idade;
            model.Nome = viewModel.Nome;
            model.DataInclusao = DateTime.Now;
            model.Ativo = true;
            model.IdSexo = viewModel.IdSexo;

            return model;
        }
        private Usuario ConverterViewModelToMOdel(string NomeUsuario)
        {
            Usuario model = new Usuario();
            model.Nome = NomeUsuario;

            return model;
        }
        
        private Usuario ConverterViewModelToMOdel(int Id)
        {
            Usuario model = new Usuario
            {
                Id = Id
            };

            return model;
        }

        private Usuario ConverterViewModelToModel(int Id)
        {
            Usuario model = new Usuario();

            model.Cpf = model.Cpf;
            model.DatadeNascimeto = model.DatadeNascimeto;
            model.Idade = model.Idade;
            model.Nome = model.Nome;
            model.DataInclusao = DateTime.Now;
            model.Ativo = true;
            model.IdSexo = model.IdSexo;

            return model;
        }
        #endregion


    }
}