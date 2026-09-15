using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.NechaevYA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.NechaevYA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckMessageValid()
        {
            var name = "Ярик";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Ярик", res);
        }
    }
}
