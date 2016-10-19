using System;
using System.Collections.Generic;
using System.Text;

namespace ProteinManagementSystem.Database
{
    public class Protein
    {
        public string Name { get; set; }

        public string Sequence { get; set; }

        public double IsoelectricPoint { get; set; }

        public uint MolecularWeight { get; set; }

        public string Description { get; set; }

        public DateTime DateDiscovered { get; set; }

        public string DiscoveredBy { get; set; }
    }
}
