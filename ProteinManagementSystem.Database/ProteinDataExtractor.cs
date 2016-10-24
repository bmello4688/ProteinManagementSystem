using ProteinManagementSystem.Database.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProteinManagementSystem.Database
{
    internal static class ProteinDataExtractor
    {
        private const int ColumnDataLength = 7;

        internal static List<Protein> GetProteins()
        {
            char[] splitChars = new char[] { ',', '\n' };
            string[] commasSeperatedData = Resources.proteins.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);
            List<Protein> proteins = new List<Protein>();

            //skip the first row because it is header information
            //- 1 on length because there is an extra element at the of of the array
            for (int i = ColumnDataLength; i < commasSeperatedData.Length; i += ColumnDataLength)
            {
                //TODO: Should probably add some validation
                proteins.Add(new Protein(commasSeperatedData[i], commasSeperatedData[i + 1], commasSeperatedData[i + 4])
                {
                    IsoelectricPoint = Convert.ToDouble(commasSeperatedData[i + 2]),
                    MolecularWeight = Convert.ToInt32(commasSeperatedData[i + 3]),
                    DateDiscovered = new DateTime(Convert.ToInt32(commasSeperatedData[i + 5]), 1, 1),
                    DiscoveredBy = commasSeperatedData[i + 6].TrimEnd()//contains a carriage return
                });
            }

            return proteins;
        }
    }
}
