using Ahram_Clinic.Models;
using Ahram_Clinic.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ahram_Clinic.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly ClinicRepository<Doctors> doctorsRepository;

        public DoctorsController(ClinicRepository<Doctors> doctorsRepository)
        {
            this.doctorsRepository = doctorsRepository;
        }


        // GET: DoctorsController
        public ActionResult Index()
        {
            var Doc = doctorsRepository.List();
            return View(Doc);
        }

        // GET: DoctorsController/Details/5
        public ActionResult Details(int id)
        {
            var Doc = doctorsRepository.Find(id);
            return View(Doc);
        }

        // GET: DoctorsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DoctorsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Doctors doctor)
        {
            try
            {
                doctorsRepository.Add(doctor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorsController/Edit/5
        public ActionResult Edit(int id)
        {
            var doctor = doctorsRepository.Find(id);

            return View(doctor);
        }

        // POST: DoctorsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Doctors doctor)
        {
            try
            {
                doctorsRepository.Update(id, doctor);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            var doctor = doctorsRepository.Find(id);

            return View(doctor);
        }

        // POST: DoctorsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Doctors doctor)
        {
            try
            {
                doctorsRepository.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
