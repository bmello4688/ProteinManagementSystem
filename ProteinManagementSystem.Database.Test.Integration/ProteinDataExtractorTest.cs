using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProteinManagementSystem.Database.Test.Integration
{
    [TestClass]
    public class ProteinDataExtractorTest
    {
        [TestMethod]
        public void GetListDataTest()
        {
            var list = ProteinDataExtractor.GetProteins();
            
            Assert.AreEqual(100, list.Count);
        }
    }
}
