using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BhaskaraApp
{
    public class Bhaskara
    {
        // Coeficientes da equação de segundo grau
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        // Construtor com inicialização dos coeficientes
        public Bhaskara(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        // Calculando o valor de Delta
            public double CalcularDelta()
            {
                return B * B - (4 * A * C);
            }

            // Verificando se a equação possui raízes reais
            public bool TemRaizesReais()
            {
                double delta = CalcularDelta();
                return delta > 0;
            }

            // Método para calcular as raízes da equação
            public (double?, double?) CalcularRaizes()
            {
                if (!TemRaizesReais())
                {
                    // Se não tem raízes reais, retorna dois nulos
                    return (null, null);
                }

                double delta = CalcularDelta();
                double raizDelta = Math.Sqrt(delta);

                // Calculando as raízes usando o coeficiente A
                double x1 = (-B + raizDelta) / (2 * A);
                double x2 = (-B - raizDelta) / (2 * A);

                return (x1, x2);
            }
    }
}
