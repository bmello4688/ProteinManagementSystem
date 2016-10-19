using System;
using System.Collections.Generic;
using System.Text;

namespace ProteinManagementSystem.Database
{
    public class Protein
    {
        //TODO: Find out constraints
        public string Name { get; set; }

        public string Sequence { get; set; }

        public double IsoelectricPoint { get; set; }

        public uint MolecularWeight { get; set; }

        public string Description { get; set; }

        public DateTime DateDiscovered { get; set; }

        public string DiscoveredBy { get; set; }

        //TODO:Find out what information is required. For now all will be.
        public Protein(string name, string sequence, double isoelectricPoint, uint molecularWeight, string description, DateTime dateDiscovered, string discoveredBy)
        {
            Name = name;
            Sequence = sequence;
            IsoelectricPoint = isoelectricPoint;
            MolecularWeight = molecularWeight;
            Description = description;
            DateDiscovered = dateDiscovered;
            DiscoveredBy = discoveredBy;
        }
    }
}
