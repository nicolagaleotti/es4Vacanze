using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcLibrary;
using System.Data;

namespace TempLibrary.Test
{
    [TestClass]
    public class TempTest
    {
        [TestMethod]
        public void TestMediaTemperature()
        {
            double[] temperature = new double[] { 13, 20, 18 };
            double resp = Temp.MediaTemperature(temperature);
            double asp = 17;
            Assert.AreEqual(asp, resp);
        }

        [DataTestMethod]
        [DataRow(new double[]{13, 20, 18}, 17)]
        [DataRow(new double[]{12, 15, 18}, 15)]
        public void DataTestMediaTemperature(double[] temperature, double asp)
        {
            double resp = Temp.MediaTemperature(temperature);
            Assert.AreEqual(asp, resp);
        }
    }
}
