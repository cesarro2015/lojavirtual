using Microsoft.VisualStudio.TestTools.UnitTesting;
using portifolio.LojaVirtual.Web1.Models;
using System;
using System.Web.Mvc;

namespace portifolio.LojaVirtual.UnitTest
{
    class LojaVirtualTest
    {
        [TestMethod]
        public void TesteGeracaodePaginacao()
        {
            HtmlHelper html = null;

            Paginacao paginacao = new Paginacao
            {
                PaginaAtual = 2,
                IntensPorPagina = 10,
                IntensTotal = 28,
            };
            Func<int, string> PaginaURL = i => "Pagina" + i;


            //act
            //MvcHtmlString resultado = html.pageLinks(paginacao, PaginaURL);

            //assert

        }
    }
}
