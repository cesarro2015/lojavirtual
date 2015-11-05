using portifolio.LojaVirtual.Dominio.Repositorio;
using portifolio.LojaVirtual.Web1.Models;
using System.Linq;
using System.Web.Mvc;

namespace portifolio.LojaVirtual.Web1.Controllers
{
    public class ExpostoController : Controller
    {
        private ProdutoRepository _repository;

        public ActionResult ListaProdutos()
        {
            _repository = new ProdutoRepository();

            ProdutosViewModel model = new ProdutosViewModel
            {
                Paginacao = new Paginacao
                {
                    PaginaAtual = pagina,
                    IntensPorPagina = ProdutosPorPagina,
                    IntensTotal = _repository.Produtos.Count()
                }
            }


            var produtos = _repository.Produtos.OrderBy(p => p.PodutoId).Take(5).Skip(2);
            return View();
        }
    }
}