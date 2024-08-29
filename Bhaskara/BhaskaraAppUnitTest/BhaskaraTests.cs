using Microsoft.VisualStudio.TestTools.UnitTesting;
using BhaskaraApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhaskaraApp.Tests
{
    [TestClass()]
    public class BhaskaraTests
    {
        [TestMethod()]
        [DataRow(1, -5, 6, 3, 2)]     // Delta = 1, Raízes: 3 e 2
        [DataRow(1, -7, 10, 5, 2)]    // Delta = 9, Raízes: 5 e 2
        [DataRow(2, -8, 6, 3, 1)]     // Delta = 4, Raízes: 3 e 1
        public void TestarCalculoRaizes(double coefA, double coefB, double coefC, double esperado1, double esperado2)
        {
            var equacao = new Bhaskara(coefA, coefB, coefC);

            var (raiz1, raiz2) = equacao.CalcularRaizes();

            raiz1 = raiz1.HasValue ? raiz1.Value : double.NaN;
            raiz2 = raiz2.HasValue ? raiz2.Value : double.NaN;

            string esperado = $"{esperado1}-{esperado2}";
            string obtido = $"{raiz1}-{raiz2}";

            Assert.AreEqual(esperado, obtido);
        }

        [TestMethod()]
        [DataRow(1, -6, 9, false)]     
        [DataRow(1, -3, 2, true)]     
        [DataRow(1, 2, 5, false)]    
        [DataRow(2, 4, 6, false)]    
        [DataRow(3, 5, 7, false)]    
        public void TestarExistenciaRaizesReais(double coefA, double coefB, double coefC, bool temRaizesReais)
        {
            var equacao = new Bhaskara(coefA, coefB, coefC);

            bool resultado = equacao.TemRaizesReais();

            Assert.AreEqual(temRaizesReais, resultado);
        }

        [TestMethod()]
        [DataRow(1, -2, 1, 0)]     // Delta = 0
        [DataRow(1, -5, 6, 1)]     // Delta = 1
        [DataRow(1, -7, 10, 9)]    // Delta = 9
        [DataRow(3, -6, 2, 12)]    // Delta = 12
        public void TestarCalculoDelta(double coefA, double coefB, double coefC, double esperadoDelta)
        {
            var equacao = new Bhaskara(coefA, coefB, coefC);

            double deltaCalculado = equacao.CalcularDelta();

            Assert.AreEqual(esperadoDelta, deltaCalculado);
        }
    }
}
