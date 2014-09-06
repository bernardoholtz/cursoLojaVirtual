using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Quiron.LojaVirtual.Dominio.Repositorio;


namespace Quiron.LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: Produtos
        private ProdutoRepositorio _repositorio;
        public ActionResult Index()
        {
            _repositorio = new ProdutoRepositorio();
            var produtos = _repositorio.Produtos.Take(10);

            return View(produtos);

        }
    }
}