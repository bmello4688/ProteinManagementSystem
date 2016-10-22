using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProteinManagementSystem.Database
{
    public class Protein
    {
        //TODO: Find out constraints
        [Key]
        [Required]
        public string Name { get; set; }

        [Required]
        public string AminoAcidSequence { get; set; }

        public double? IsoelectricPoint { get; set; }

        public int? MolecularWeight { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime? DateDiscovered { get; set; }

        public string DiscoveredBy { get; set; }


        public Protein()
        {

        }

        public Protein(string name, string aminoAcidSequence, string description)
        {
            Name = name;
            AminoAcidSequence = aminoAcidSequence;
            Description = description;
        }
    }
}
