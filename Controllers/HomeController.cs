using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //---------modo 1 --------------------//
            //Usando os 2 modos normais
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "André Spilari",
                Tipo = "Administrador"
            };

            //Modo via ViewData
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;

            //Modo via ViewBag
            ViewBag.id = pessoa.PessoaId;
            ViewBag.nome = pessoa.Nome;
            ViewBag.tipo = pessoa.Tipo;

            //Quando é uma View tipada, nao precisa retornar o objeto no final
            /*return View();*/


            //---------modo 2 --------------------//
            //Usando a view tipada
            var pessoa2 = new Pessoa
            {
                PessoaId = 1,
                Nome = "André Spilari",
                Tipo = "Administrador"
            };

            return View(pessoa2);
        }

        public ActionResult Contatos()
        {
            return View();
        }

        //Quando houver uma requisicao atraves de form de envio do tipo POST precisa colocar a linha abaixo. Forma via parametros.
        [HttpPost]
        public ActionResult Lista(int PessoaId, string Nome, string Tipo)
        {
            ViewData["PessoaId"] = PessoaId;
            ViewData["Nome"] = Nome;
            ViewData["Tipo"] = Tipo;

            return View();
        }

        //Quando houver uma requisicao atraves de form de envio do tipo GET não precisa colocar [HttpPost]. Forma via parametros.
        public ActionResult ListaGet(int PessoaId, string Nome, string Tipo)
        {
            ViewData["PessoaId"] = PessoaId;
            ViewData["Nome"] = Nome;
            ViewData["Tipo"] = Tipo;

            return View();
        }

        //Quando houver uma requisicao atraves de form de envio do tipo POST precisa colocar a linha abaixo. Forma via FormCollection.
        [HttpPost]
        public ActionResult ListaViaFormCollection(FormCollection form123)
        {
            ViewData["PessoaId"] = form123["PessoaId-11"];
            ViewData["Nome"] = form123["Nome-22"];
            ViewData["Tipo"] = form123["Tipo-33"];

            return View();
        }

        //Quando houver uma requisicao atraves de form de envio do tipo POST precisa colocar a linha abaixo.
        [HttpPost]
        public ActionResult ListaViaViewTipada(Pessoa pessoa123)
        {
            ViewData["PessoaId"] = pessoa123.PessoaId;
            ViewData["Nome"] = pessoa123.Nome;
            ViewData["Tipo"] = pessoa123.Tipo;

            return View();
        }

        //Quando houver uma requisicao atraves de form de envio do tipo POST precisa colocar a linha abaixo. Forma via View tipada.
        [HttpPost]
        public ActionResult ListaViaHelperViewTipada(Pessoa pessoa77777)
        {
            return View(pessoa77777);
        }

        //Quando houver uma requisicao atraves de beginForm de envio do tipo POST precisa colocar a linha abaixo. Forma via View tipada.
        [HttpPost]
        public ActionResult ListaViaBeginForm(Pessoa pessoa232323)
        {
            return View(pessoa232323);
        }
    }
}