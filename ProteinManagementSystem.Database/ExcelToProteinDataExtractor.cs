using ProteinManagementSystem.Database.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProteinManagementSystem.Database
{
    internal static class ExcelToProteinDataExtractor
    {
        private const int ColumnDataLength = 7;

        internal static List<Protein> GetProteins()
        {
            string[] commasSeperatedData = Resources.proteins.Split(',', '\n');
            List<Protein> proteins = new List<Protein>();

            //skip the first row because it is header information
            //- 1 on length because there is an extra element at the of of the array
            for (int i = ColumnDataLength; i < commasSeperatedData.Length - 1; i+=ColumnDataLength)
            {
                //TODO: Should probably add some validation
                proteins.Add(new Protein(commasSeperatedData[i], commasSeperatedData[i + 1], Convert.ToDouble(commasSeperatedData[i + 2]), Convert.ToUInt32(commasSeperatedData[i + 3]), commasSeperatedData[i + 4], new DateTime(Convert.ToInt32(commasSeperatedData[i + 5]),1,1), commasSeperatedData[i + 6].TrimEnd()));
            }

            return proteins;
        }
    }
}
