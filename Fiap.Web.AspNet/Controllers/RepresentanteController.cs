using Fiap.Web.AspNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.AspNet.Controllers
{
    public class RepresentanteController : Controller
    {

        private IList<RepresentanteModel> representantes;

        public RepresentanteController()
        {
            // De uma forma rudimentar, podemos dizer que esse bloco de código 
            // simula o retorno de uma consulta no banco de dados
            representantes = new List<RepresentanteModel>();
            representantes.Add(new RepresentanteModel(1, "444.143.658-05", "José Carlos Silva"));
            representantes.Add(new RepresentanteModel(2, "062.572.723-19", "Maria José Fernandes"));
            representantes.Add(new RepresentanteModel(2, "920.680.661-06", "Carlos Silva"));
        }

        public IActionResult Index()
        {
            // Retornando para View a lista de Representantes
            return View(representantes); // <-- Atenção
        }

        /// Anotação de uso do Verb HTTP Get
        [HttpGet]
        public IActionResult Cadastrar()
        {
            // Imprime a mensagem de execução
            Console.WriteLine("Executou a Action Cadastrar()");

            // Retorna para a View Cadastrar um 
            // objeto modelo com as propriedades em branco 
            return View(new RepresentanteModel());
        }

        // Anotação de uso do Verb HTTP Post
        [HttpPost]
        public IActionResult Cadastrar(RepresentanteModel representante)
        {
            // Imprime os valores do modelo
            Console.WriteLine("Descrição: " + representante.Cpf);
            Console.WriteLine("Comercializado: " + representante.NomeRepresentante);

            // Simila que os dados foram gravados.
            Console.WriteLine("Gravando o Representante");

            // Substituímos o return View()
            // pelo método de redirecionamento
            return RedirectToAction("Index", "Representante");
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            // Imprime a mensagem de execução
            Console.WriteLine("Consultando pelo Id = " + id);

            // Cria o modelo que SIMULA a consulta no banco de dados
            Models.RepresentanteModel Representante = new Models.RepresentanteModel(id, "191.191.191-91", "Almir Moura");


            // Retorna para a View o objeto modelo 
            // com as propriedades preenchidas com dados do banco de dados 
            return View(Representante);
        }

        [HttpPost]
        public IActionResult Editar(RepresentanteModel representante)
        {
            // Imprime os valores do modelo
            Console.WriteLine("CPF: " + representante.Cpf);
            Console.WriteLine("Id: " + representante.RepresentanteId);
            Console.WriteLine("Nome: " + representante.NomeRepresentante);

            // Simila que os dados foram gravados.
            Console.WriteLine("Gravando o Tipo Editado");

            // Substituímos o return View()
            // pelo método de redirecionamento
            return RedirectToAction("Index", "Representante");
        }

        [HttpGet]
        public IActionResult Consultar(int id)
        {
            // Imprime a mensagem de execução
            Console.WriteLine("Consultando pelo Id = " + id);

            // Cria o modelo que SIMULA a consulta no banco de dados
            Models.RepresentanteModel Representante = new Models.RepresentanteModel(id, "191.191.191-91", "Almir Moura");


            // Retorna para a View o objeto modelo 
            // com as propriedades preenchidas com dados do banco de dados 
            return View(Representante);
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            // Imprime a mensagem de execução
            Console.WriteLine("Excluir o Representante Id = " + id);

            // Substituímos o return View()
            // pelo método de redirecionamento
            return RedirectToAction("Index", "Representante");
        }
    }
}