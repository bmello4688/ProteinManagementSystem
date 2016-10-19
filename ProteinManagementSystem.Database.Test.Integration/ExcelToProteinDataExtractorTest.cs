using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProteinManagementSystem.Database.Test.Integration
{
    [TestClass]
    public class ExcelToProteinDataExtractorTest
    {
        [TestMethod]
        public void GetListDataTest()
        {
            var list = ExcelToProteinDataExtractor.GetProteins();
            
            Assert.AreEqual(100, list.Count);
        }
    }
}
