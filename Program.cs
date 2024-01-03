namespace JCD1._4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso dos métodos
            Console.WriteLine(Somar(5, 3));
            Console.WriteLine(Subtrair(10, 4));
            Console.WriteLine(Multiplicar(6, 7));
            Console.WriteLine(Dividir(20, 2));
            Console.WriteLine(VerificarParidade(9));
        }

        // Método para somar dois números
        static int Somar(int a, int b)
        {
            return a + b;
        }

        // Método para subtrair dois números
        static int Subtrair(int a, int b)
        {
            return a - b;
        }

        // Método para multiplicar dois números
        static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        // Método para dividir dois números
        static double Dividir(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Não é possível dividir por zero.");
                return 0;
            }
        }

        // Método para verificar a paridade de um número
        static string VerificarParidade(int num)
        {
            return num % 2 == 0 ? "Par" : "Ímpar";
        }

    }
}
            