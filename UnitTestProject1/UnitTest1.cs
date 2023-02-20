using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        VIN_LIB.VIN vin = new VIN_LIB.VIN();
        [TestMethod]
        public void Proverka_vin_JHMCM56557C404453()
        {
            Assert.AreEqual(vin.CheckVIN("FGFBFD8789FDBFDB89"), false);
        }
        [TestMethod]
        public void Proverka_vin_IHMCM56557C404453()
        {
            Assert.AreEqual(vin.CheckVIN("IHMCM56557C404453"), false);
        }
        [TestMethod]
        public void Proverka_vin_XTA210990Y2766389()
        {
            Assert.AreEqual(vin.CheckVIN("XTA210990Y2766389"), true);
        }
        [TestMethod]
        public void Proverka_vin_XOA210990Y27663898()
        {
            Assert.AreEqual(vin.CheckVIN("XOA210990Y27663898"), false);
        }
        [TestMethod]
        public void Proverka_vin_Z8NAJL00050366148()
        {
            Assert.AreEqual(vin.CheckVIN("Z8NAJL00050366148"), true);
        }
        [TestMethod]
        public void Proverka_vin_Z8NQJL00050366()
        {
            Assert.AreEqual(vin.CheckVIN("Z8NAJL00050366"), false);
        }
        [TestMethod]
        public void Proverka_vin_()
        {
            Assert.AreEqual(vin.CheckVIN(""), false);
        }
        [TestMethod]
        public void Proverka_vin_123()
        {
            Assert.AreEqual(vin.CheckVIN("123"), false);
        }
        [TestMethod]
        public void Country_JHMCM56557C404453()
        {
            Assert.AreEqual(vin.GetVINCountry("JHMCM56557C404453"), "Северная Америка");
        }
        [TestMethod]
        public void Country_XTA210990Y2766389()
        {
            Assert.AreEqual(vin.GetVINCountry("XTA210990Y2766389"), "Океания");
        }
        [TestMethod]
        public void Country_Z8NAJL00050A66148()
        {
            Assert.AreEqual(vin.GetVINCountry("Z8NAJL00050A66148"), "Африка");
        }
        [TestMethod]
        public void Country_Z8NAJL00050J66152()
        {
            Assert.AreEqual(vin.GetVINCountry("Z8NAJL00050J66152"), "Азия");
        }
        [TestMethod]
        public void Country_JHMCM56557CY04453()
        {
            Assert.AreEqual(vin.GetVINCountry("JHMCM56557CY04453"), "Европа");
        }
        [TestMethod]
        public void Country_()
        {
            Assert.AreEqual(vin.GetVINCountry(""), "");
        }
        [TestMethod]
        public void Country_0000000()
        {
            Assert.AreEqual(vin.GetVINCountry("0000000"), "");
        }
    }
}
