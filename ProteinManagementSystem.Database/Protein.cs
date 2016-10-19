using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProteinManagementSystem.Database
{
    public class Protein
    {
        //TODO: Find out constraints
        [Required]
        public string Name { get; private set; }

        [Required]
        public string AminoAcidSequence { get; private set; }

        public double IsoelectricPoint { get; set; }

        public uint MolecularWeight { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime DateDiscovered { get; set; }

        public string DiscoveredBy { get; set; }

        //TODO:Find out what information is required. For now all will be.
        public Protein(string name, string aminoAcidSequence, string description)
        {
            Name = name;
            AminoAcidSequence = aminoAcidSequence;
            Description = description;
        }
    }
}
