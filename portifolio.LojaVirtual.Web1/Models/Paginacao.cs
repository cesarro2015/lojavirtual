using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace portifolio.LojaVirtual.Web1.Models
{
    public class Paginacao
    {
        //total de intens do banco
        public int IntensTotal { get; set; }

        //total de intens por paginação
        public int IntensPorPagina { get; set; }

        //pagina exibida no momento
        public int PaginaAtual { get; set; }

        public int PaginaTotal
        {
            get { return (int)Math.Ceiling((decimal)IntensTotal / IntensPorPagina); }
        }
        

    }
}
