using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoModel.Domain.Entities;
using ProjetoModelo.MVC.ViewModel;
using ProjetoModelo.Application.Interface;

namespace ProjetoModelo.MVC.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientAppService _clientApp;

        public ClientController(IClientAppService clientApp)
        {
            this._clientApp = clientApp;
        }

        // GET: Client
        public ActionResult Index()
        {

            var clientViewModel = Mapper.Map<IEnumerable<Client>, IEnumerable<ClientViewModel>>(_clientApp.GetAll());
            return View(clientViewModel);
        }
        public ActionResult Special()
        {

            var clientViewModel = Mapper.Map<IEnumerable<Client>, IEnumerable<ClientViewModel>>(_clientApp.GetSpecialClient());
            return View(clientViewModel);
        }
        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            var client = _clientApp.GetByID(id);
            var clientViewModel = Mapper.Map<Client, ClientViewModel>(client);
            return View(clientViewModel);
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClientViewModel clientViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var clientDomain = Mapper.Map<ClientViewModel, Client>(clientViewModel);
                    _clientApp.Add(clientDomain);
                    return RedirectToAction("Index");
                }

                return View(clientViewModel);
            }
            catch
            {
                return View(clientViewModel);
            }
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            var client = _clientApp.GetByID(id);
            var clientViewModel = Mapper.Map<Client, ClientViewModel>(client);
            return View(clientViewModel);
        }

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ClientViewModel client)
        {
            try
            {

                if (ModelState.IsValid)
                {
                    var clientDomain = Mapper.Map<ClientViewModel, Client>(client);
                    _clientApp.Update(clientDomain);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            var client = _clientApp.GetByID(id);
            var clientViewModel = Mapper.Map<Client, ClientViewModel>(client);
            return View(clientViewModel);
        }

        // POST: Client/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                var client = _clientApp.GetByID(id);
                _clientApp.Remove(client);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
