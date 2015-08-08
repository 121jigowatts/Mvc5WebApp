using Mvc5WebApp.Contracts;
using Mvc5WebApp.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc5WebApp.UI.Controllers
{
    public class PeopleController : Controller
    {
        private readonly IPeopleService _service;
        private readonly IObjectMapper _mapper;
        public PeopleController(IPeopleService service, IObjectMapper mapper) 
        {
            this._service = service;
            this._mapper = mapper;
        }


        // GET: People
        public ActionResult Index()
        {
            var model = _service.Get();            
            return View(model);
        }

        // GET: People/Details/5
        public ActionResult Details(int id)
        {
            //PeopleDetailViewModel model = _mapper.Map<PeopleDetailViewModel>(_service.GetById(id));
            return View();
        }

        // GET: People/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: People/Create
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

        // GET: People/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: People/Edit/5
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

        // GET: People/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: People/Delete/5
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
