using ProteinManagementSystem.Database;
using ProteinManagementSystem.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;

namespace ProteinManagementSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private ProteinContext contextDatabase = new ProteinContext();
        //Get
        public async Task<ActionResult> Index(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                searchTerm = null;

            var proteins = contextDatabase.Proteins
                .Where(p => searchTerm == null || p.Name.StartsWith(searchTerm) || p.AminoAcidSequence.StartsWith(searchTerm))
                .Take(20)
                .Select(protein => new ProteinViewModel()
                {
                    Name = protein.Name,
                    AminoAcidSequence = protein.AminoAcidSequence,
                    Description = protein.Description,
                    IsoelectricPoint = protein.IsoelectricPoint.ToString(),
                    MolecularWeight = protein.MolecularWeight.ToString(),
                    YearDiscovered = protein.DateDiscovered.Year.ToString(),
                    DiscoveredBy = protein.DiscoveredBy
                });

            if (Request.IsAjaxRequest())
                return PartialView("_Proteins", proteins);

            return View(await proteins.ToListAsync());
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProteinViewModel proteinViewModel)
        {
            if (ModelState.IsValid)
            {
                var protein = new Protein(proteinViewModel.Name, proteinViewModel.AminoAcidSequence, proteinViewModel.Description)
                {
                    DiscoveredBy = proteinViewModel.DiscoveredBy
                };

                if (proteinViewModel.IsoelectricPoint != null)
                    protein.IsoelectricPoint = Convert.ToDouble(proteinViewModel.IsoelectricPoint);
                if (proteinViewModel.MolecularWeight != null)
                    protein.MolecularWeight = Convert.ToInt32(proteinViewModel.MolecularWeight);
                if (proteinViewModel.YearDiscovered != null)
                    protein.DateDiscovered = new DateTime(Convert.ToInt32(proteinViewModel.YearDiscovered), 1, 1);

                contextDatabase.Proteins.Add(protein);
                contextDatabase.SaveChanges();

                return RedirectToAction("Index");
            }
            else
                return View(proteinViewModel);
        }

        // POST: Home/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProteinViewModel proteinViewModel)
        {
            if (ModelState.IsValid)
            {
                contextDatabase.Entry(proteinViewModel).State = EntityState.Modified;
                contextDatabase.SaveChanges();

                return RedirectToAction("Index");
            }
            else
                return View(proteinViewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "This application allows for the creation and modification of new and existing protein data entries. This application is referred to as the protein management system application or PMS for short. Let humor ensue. ;)";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                contextDatabase.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}