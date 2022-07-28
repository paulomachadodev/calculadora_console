using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLogica02.Controllers
{
    public class CalculadoraController
    {
        public decimal Num1 { get; set; }
        public decimal Num2 { get; set; }

        public static void Somar()
        {
            var calculadoraController = new CalculadoraController();

            Console.Write("\nDigite o primeiro número.........: ");
            calculadoraController.Num1 = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número..........: ");
            calculadoraController.Num2 = decimal.Parse(Console.ReadLine());

            var resultado = calculadoraController.Num1 + calculadoraController.Num2;

            Console.Write($"\nO resultado da soma é............: {resultado}\n" +
                $"");

        }

        public static void Subtrair()
        {
            var calculadoraController = new CalculadoraController();

            Console.Write("\nDigite o primeiro número.........: ");
            calculadoraController.Num1 = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número..........: ");
            calculadoraController.Num2 = decimal.Parse(Console.ReadLine());

            var resultado = calculadoraController.Num1 - calculadoraController.Num2;

            Console.Write($"\nO resultado da multiplicação é...: {resultado}\n");

        }

        public static void Multiplicar()
        {
            var calculadoraController = new CalculadoraController();

            Console.Write("\nDigite o primeiro número.........: ");
            calculadoraController.Num1 = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número..........: ");
            calculadoraController.Num2 = decimal.Parse(Console.ReadLine());

            var resultado = calculadoraController.Num1 * calculadoraController.Num2;

            Console.Write($"\nO resultado da subtracao é.......: {resultado}\n");

        }

        public static void Dividir()
        {
            var calculadoraController = new CalculadoraController();

            Console.Write("\nDigite o primeiro número.........: ");
            calculadoraController.Num1 = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número..........: ");
            calculadoraController.Num2 = decimal.Parse(Console.ReadLine());

            if (calculadoraController.Num2 != 0m)
            {

                var resultado = calculadoraController.Num1 / calculadoraController.Num2;
                Console.Write($"\nO resultado da divisão é.....: {resultado}\n");
            }
            else
            {
                var resultado = 0m;
                Console.Write($"\nImpossível dividir por 0, o resultado é.....: {resultado}\n");

            }          
        }
    }
}
