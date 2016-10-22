using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProteinManagementSystem.Web.Models
{
    public class ProteinViewModel
    {
        [Required(ErrorMessage="Name is required")]
        [MaxLength(128)]
        public string Name { get; set; }

        [Display(Name="Amino acid sequence")]
        [Required(ErrorMessage = "Amino acid sequence is required")]
        [ProteinAminoAcidValidation]
        public string AminoAcidSequence { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Display(Name = "Isoelectric Point")]
        [RegularExpression(@"[-+]?([0-9]*\.[0-9]+|[0-9]+)", ErrorMessage = "Isoelectric Point is not in a decimal format.")]
        public string IsoelectricPoint { get; set; }

        [Display(Name = "Molecular Weight")]
        [RegularExpression(@"(^\d+$)", ErrorMessage = "Molecular Weight is not an integer.")]
        public string MolecularWeight { get; set; }

        [Display(Name = "Year Discovered")]
        [RegularExpression(@"([0-9]{4})", ErrorMessage = "Year discovered is not four digits long.")]
        public string YearDiscovered { get; set; }

        [Display(Name = "Discovered By")]
        public string DiscoveredBy { get; set; }
    }
}