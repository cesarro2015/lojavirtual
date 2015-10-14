using portifolio.LojaVirtual.Web1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace portifolio.LojaVirtual.Web1.HtmlHelpers
{
    public static class PaginacaoHelpers
    {
        public static MvcHtmlString PageLink(this HtmlHelper html, Paginacao paginacao, Func<int,string> PaginaURL)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 1; i < paginacao.PaginaTotal; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", PaginaURL(i));
                tag.InnerHtml = i.ToString();

                if (i == paginacao.PaginaAtual)
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                result.Append(tag);
            }
            return MvcHtmlString.Create(result.ToString());
        }
    }
}
