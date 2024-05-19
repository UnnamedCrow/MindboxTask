using MindboxTask;
using System.ComponentModel;
namespace MindboxTask.Tests
{
    public class Tests
    {
  
        [Test]
        public void TestCircle()
        {
            double a = 1;
            double b = Worker.Suqare(a);
            Assert.True(b == Math.PI);
        }
        [Test]
        public void TestTriangle()
        {
            double a = 5;
            double b = 3;
            double c = 4;
            Assert.True(Worker.Square(a, b, c) == 6);
        }
        [Test]
        public void TestIsRectangular1()
        {
            double a = 5;
            double b = 3;
            double c = 4;
            Assert.True(Worker.IsRectangular(a, b, c));
        }
        [Test]
        public void TestIsRectangular2()
        {
            double a = 5;
            double b = 5;
            double c = 4;
            Assert.False(Worker.IsRectangular(a, b, c));
        }
    }
}