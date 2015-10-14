using portifolio.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace portifolio.LojaVirtual.Web1.Controllers
{
    public class ExpostoController : Controller
    {
        private ProdutoRepository _repository;

        public ActionResult ListaProdutos()
        {
            _repository = new ProdutoRepository();
            var produtos = _repository.Produtos.OrderBy(p => p.PodutoId).Take(5).Skip(2);
            return View();
        }
    }
}