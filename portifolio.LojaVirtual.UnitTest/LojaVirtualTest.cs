using Microsoft.VisualStudio.TestTools.UnitTesting;
using portifolio.LojaVirtual.Web1.Models;
using portifolio.LojaVirtual.Web1.HtmlHelpers;
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
            MvcHtmlString resultado = html.PageLink(paginacao, PaginaURL);

            //assert
            Assert.AreEqual(


                @"<a class=""btn btn-defaoult"" href=""Pagina1"">1</a>"
               + @"<a class=""btn btn-default btn-primary selected"" href""Pagina2"">2</a>"
               + @"<a class=""btn btn-default"" href=""Pagina3""</a>", resultado.ToString()
              
               );
        }
    }
}
