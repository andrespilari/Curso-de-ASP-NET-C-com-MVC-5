using Introducao.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Usuario()
        {
            var usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario22)
        {
            //Validações dos campos do formulário abaixo, mas aqui não é o lugar ideal, seria dentro da propria classe.
            //if (string.IsNullOrEmpty(usuario22.Nome))
            //{
            //    ModelState.AddModelError("Nome", "O campo nome é obrigatório ser preenchido!");
            //}

            //if (usuario22.Senha != usuario22.ConfirmarSenha)
            //{
            //    ModelState.AddModelError("", "As senhas precisam ser iguais!");
            //}

            if (ModelState.IsValid)
            {
                return View("Resultado", usuario22);
            }
            return View(usuario22);
        }
        
        public ActionResult Resultado(Usuario usuario33)
        {
            return View(usuario33);
        }

        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "Hugo",
                "Freitas",
                "Paula"
            };

            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}