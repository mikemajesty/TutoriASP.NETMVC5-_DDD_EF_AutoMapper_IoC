using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoModel.Domain;
using ProjetoModelo.Infra.Data.Repository;
using AutoMapper;
using ProjetoModel.Domain.Entities;
using ProjetoModelo.MVC.ViewModel;

namespace ProjetoModelo.MVC.Controllers
{
    public class ClientController : Controller
    {
        private readonly ClientRepository
            _clientRepository = new ClientRepository();
        // GET: Client
        public ActionResult Index()
        {
            
            var clientViewModel = Mapper.Map<IEnumerable<Client>, IEnumerable<ClientViewModel>>(_clientRepository.GetAll());
            return View(clientViewModel);
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Client/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Client/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

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
            return View();
        }

        // POST: Client/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
