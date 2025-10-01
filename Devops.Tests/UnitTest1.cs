using Devops.Models;

namespace Devops.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Calculadora calculadora = new Calculadora();

            calculadora.A = 3;
            calculadora.B = 2;

            var result = Calculadora.Soma(calculadora.A, calculadora.B);
            Assert.Equal(5, result);
        }
    }
}