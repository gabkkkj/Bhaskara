using BhaskaraApp;

internal class Program
{
    private static void Main(string[] args)
    {
        // Exemplo de uso da classe Bhaskara
        var bhaskara = new Bhaskara(1, 2, 1);

        if (bhaskara.TemRaizesReais())
        {
            var (raiz1, raiz2) = bhaskara.CalcularRaizes();
            Console.WriteLine($"Raiz 1: {raiz1}");
            Console.WriteLine($"Raiz 2: {raiz2}");
        }
        else
        {
            Console.WriteLine("A equação não possui raízes reais.");
        }
    }
}