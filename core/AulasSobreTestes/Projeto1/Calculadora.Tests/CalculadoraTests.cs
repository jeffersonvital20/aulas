using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {
        [TestFixture]
        public class CalculadoraSimplesTests
        {
            [Test]
            public void DeveAdicionarDoisNumeros()
            {
                var sut = new CalculadoraSimples();
                var resultado = sut.Adicionar(5, 5);
                Assert.That(resultado, Is.EqualTo(10));
            }
            [Test]
            public void DeveMultiplicarDoisNumeros()
            {
                var sut = new CalculadoraSimples();
                var resultado = sut.Multiplicar(5 , 3);
                Assert.That(resultado, Is.EqualTo(15));
            }
            [Test]
            public void DeveDiminuirDoisNumeros()
            {
                var sut = new CalculadoraSimples();
                var resultado = sut.Dimunuir(30, 5);
                Assert.That(resultado, Is.EqualTo(25));
            }
            [Test]
            public void DeveDividirDoisNumeros()
            {
                var sut = new CalculadoraSimples();
                var resultado = sut.Dividir(25, 5);
                Assert.That(resultado, Is.EqualTo(5));
            }
        }
    }
}
