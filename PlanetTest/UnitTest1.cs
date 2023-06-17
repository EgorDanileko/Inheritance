using Assignment_2;
using System.Numerics;

namespace Assignment_2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_correct_output()
        {
            Planet mars = new Planet();
            mars.AddPlant("Wobler", "wom", 7);
            string str = mars.printPlants();
            Assert.AreEqual("Wobler 7 alive ", str);
        }

        [Test]
        public void Test_correct_radiation()
        {
            Planet mars = new Planet();
            mars.AddPlant("Wobler", "wom", 7);
            mars.ModifyAllPlants();
            string str = mars.printPlants();
            Assert.AreEqual("Wobler 6 alive ", str);
        }

        [Test]
        public void Test_correct_curr_rad()
        {
            Planet mars = new Planet();
            mars.AddPlant("Wobler", "wom", 7);
            mars.ModifyAllPlants();
            Radiation rad = mars.GetCurR();
            string str = mars.printPlants();
            Assert.AreEqual(typeof(NoRad), rad.GetType());
        }

        [Test]
        public void Test_correct_next_rad()
        {
            Planet mars = new Planet();
            mars.AddPlant("Wobler", "wom", 7);
            mars.ModifyAllPlants();
            Radiation rad = mars.nextRad();
            string str = mars.printPlants();
            Assert.AreEqual(typeof(Alpha), rad.GetType());
        }

    }
}