using ProteinManagementSystem.Database;
using ProteinManagementSystem.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProteinManagementSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private ProteinContext context = new ProteinContext();
        //Get
        public ActionResult Index()
        {
            List<ProteinViewModel> proteins = context.Proteins.Take(20)
                .Select(protein => new ProteinViewModel()
                {
                    Name = protein.Name,
                    AminoAcidSequence = protein.AminoAcidSequence,
                    Description = protein.Description,
                    IsoelectricPoint = protein.IsoelectricPoint,
                    MolecularWeight = protein.MolecularWeight,
                    YearDiscovered = protein.DateDiscovered.Year,
                    DiscoveredBy = protein.DiscoveredBy
                }).ToList();

            return View(proteins);
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
    }
}