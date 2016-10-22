using Bio;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web;

namespace ProteinManagementSystem.Web.Models
{
    public class ProteinAminoAcidValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ProteinAlphabet proteinAlphabet = ProteinAlphabet.Instance;

            byte[] potentialProteinSymbols = Encoding.UTF8.GetBytes(Convert.ToString(value));

            if (!proteinAlphabet.ValidateSequence(potentialProteinSymbols, 0, potentialProteinSymbols.Length))
                return new ValidationResult(string.Format("{0} only accepts characters {1}", validationContext.DisplayName, proteinAlphabet.ToString()));
            else
                return null;
        }
    }
}