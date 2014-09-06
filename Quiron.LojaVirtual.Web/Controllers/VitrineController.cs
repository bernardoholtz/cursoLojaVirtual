using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        // GET: Vitrine
        private ProdutoRepositorio _repositorio;
        public int ProdutosPorPagina = 3;
        public ActionResult Index(int pagina = 1)
        {
            _repositorio = new ProdutoRepositorio();
            var produtos = _repositorio.Produtos
            .OrderBy(p => p.Descricao)
            .Skip((pagina - 1) * ProdutosPorPagina)
            .Take(ProdutosPorPagina);

            return View(produtos);

        }
    }
}