using portifolio.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portifolio.LojaVirtual.Dominio.Repositorio
{
    public class ProdutoRepository
    {
        private readonly LJDbcontext _context = new LJDbcontext();

        public IEnumerable<Produto> Produtos
        {
            get {return _context.Produtos; }
        }
    }
}
