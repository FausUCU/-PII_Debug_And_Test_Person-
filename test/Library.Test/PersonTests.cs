using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        
        //[SetUp]
        //public void Setup()
        //{
            // Insertá tu código de inicialización aquí
        //}

        [Test]
        public void Test1() // Cambiá el nombre para indicar qué estás probando
        {
             Person p = new Person("Faustino Harriague", "1.234.567-8",1992,9,16);
             string expected="Faustino Harriague";
            // Insertá tu código  de pruebaaquí
            Assert.AreEqual(expected,p.Name);
        }
        [Test]
        
        public void TestID() 
        {
            Person p = new Person ("Faustino Harriague", "1.234.567-8",1992,9,16);
            string expected="ID Falsa";
            Assert.AreEqual(expected, p.ID);
        }
    }
}