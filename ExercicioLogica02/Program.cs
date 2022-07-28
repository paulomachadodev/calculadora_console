

using ExercicioLogica02.Controllers;

namespace ExercicioLogica02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\n *** CLCULADORA DO PAULO ***\n");

                Console.WriteLine("\n *** MENU *** \n");

                Console.WriteLine("(1) SOMA");
                Console.WriteLine("(2) SUBTRAÇÃO");
                Console.WriteLine("(3) MULTIPLICAÇÃO");
                Console.WriteLine("(4) DIVISÃO\n");

                Console.Write("Qual operação você deseja efetuar?..: ");
                var escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:

                        CalculadoraController.Somar();
                        break;

                    case 2:

                        CalculadoraController.Subtrair();
                        break;

                    case 3:

                        CalculadoraController.Multiplicar();
                        break;

                    case 4:

                        CalculadoraController.Dividir();
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida!");
                        break;
                }

                Console.Write("\nDeseja fazer mais alguma operação? (S/N)..: ");
                var opcao = Console.ReadLine();

                if((opcao == "S") || (opcao == "s"))
                {
                    Console.Clear();
                    Main(args);
                }
                else
                {
                    Console.WriteLine("\nOBRIGADO POR TER UTILIZADO A CALCULADORA!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"\nErro ao executar o programa: {e.Message}!");
            }

            Console.ReadKey();
        }

    }
}
