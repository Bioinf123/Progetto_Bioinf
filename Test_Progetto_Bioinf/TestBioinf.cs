using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Progetto_Bioinf
{
    [TestClass]
    public class TestBioinf
    {
        [TestMethod]
        public void TestResistente()
        {

            long lenght = 3901;
            long lunghezza = Progetto_Bioinf.MetodiBioinf.Resistente();
            Assert.AreEqual(lenght, lunghezza);
        }
        [TestMethod]
        public void TestSensibile()
        {

            long lenght = 3901;
            long lunghezza = Progetto_Bioinf.MetodiBioinf.ReadSens();
            Assert.AreEqual(lenght, lunghezza);
        }
    }
}