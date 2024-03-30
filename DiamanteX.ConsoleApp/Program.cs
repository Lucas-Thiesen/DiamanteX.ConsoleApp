namespace DiamanteX.ConsoleApp
{
    internal class Program
    {
        //Dado um número ímpar, exiba um diamante desenhado com a letra ‘x’.
        //No diamante acima, o número é 21, pois há 21 colunas e 21 ‘x’ na linha central.
        static void Main(string[] args)
        {
            inicio:

            //numero de colunas - impar 
            Console.WriteLine("Insira as colunas do seu DIAMANTE! ");
            int colunas = Convert.ToInt32(Console.ReadLine());
            if (colunas % 2 != 0)
            {
                int espacos = colunas / 2;
                for (int i = 0; i < espacos; i++)
                {
                    for (int j = 0; j < espacos - i; j++)
                    {
                        Console.Write(" ");
                    }

                    int contador = (2 * i) + 1;
                    for (int j = 0; j < contador; j++)
                    {
                        Console.Write("x");

                    }
                    Console.WriteLine();
                }
                // contador invertido para a parte de baixo do diamante
                for (int i = espacos; i >= 0; i--)
                {
                    for (int j = 0; j < espacos - i; j++)
                    {
                        Console.Write(" ");
                    }
                    int contador = (2 * i) + 1;
                    for (int j = 0; j < contador; j++)
                    {
                        Console.Write("x");

                    }
                    Console.WriteLine();
                }

            }
            else
            {
                Console.WriteLine("O número não é impar! Repita o processo");
                goto inicio;
            }
            Console.ReadKey();
        }
    }
}
