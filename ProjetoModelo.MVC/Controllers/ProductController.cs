using AutoMapper;
using ProjetoModel.Domain.Entities;
using ProjetoModelo.Application.Interface;
using ProjetoModelo.MVC.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoModelo.MVC.Controllers
{
    public class ProductController : Controller
    {

        private readonly IProductAppService _productApp;
        private readonly IClientAppService _clientApp;


        public ProductController(IProductAppService productApp, IClientAppService clientApp)
        {
            this._clientApp = clientApp;
            this._productApp = productApp;
        }
        public ActionResult Index()
        {
            var productViewModel = Mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(_productApp.GetAll());
            return View(productViewModel);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            var product = _productApp.GetByID(id);
            var productViewModel = Mapper.Map<Product, ProductViewModel>(product);
            return View(productViewModel);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ViewBag.ClientID = new SelectList(_clientApp.GetAll(), nameof(Client.ClientID), nameof(Client.Name));
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductViewModel product)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    var productDomain = Mapper.Map<ProductViewModel, Product>(product);
                    _productApp.Add(productDomain);
                    return RedirectToAction("Index");
                }
                return View(product);
            }
            catch
            {
                return View(product);
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {

            var product = _productApp.GetByID(id);
            var productViewModel = Mapper.Map<Product, ProductViewModel>(product);
            ViewBag.ClientID = new SelectList(_clientApp.GetAll(), nameof(Client.ClientID), nameof(Client.Name), product.ClientID);
            return View(productViewModel);

        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductViewModel product)
        {
            try
            {
                var productDomain = Mapper.Map<ProductViewModel, Product>(product);
                _productApp.Update(productDomain);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {

            var product = _productApp.GetByID(id);
            var productViewModel = Mapper.Map<Product, ProductViewModel>(product);
            return View(productViewModel);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var product = _productApp.GetByID(id);
                _productApp.Remove(product);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
