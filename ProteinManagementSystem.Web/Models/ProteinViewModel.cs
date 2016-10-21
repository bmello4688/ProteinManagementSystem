using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProteinManagementSystem.Web.Models
{
    public class ProteinViewModel
    {
        public string Name { get; set; }

        public string AminoAcidSequence { get; set; }

        public double IsoelectricPoint { get; set; }

        public int MolecularWeight { get; set; }

        public string Description { get; set; }

        public int YearDiscovered { get; set; }

        public string DiscoveredBy { get; set; }
    }
}