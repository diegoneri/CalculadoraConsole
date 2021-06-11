using System;

namespace CalculadoraConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, resultado = 0;
            int operacao;
            bool numeroValido, operacaoValida, numero2Valido;

            Program.ExibeDesenhoCalculadora();
            Program.ApresentaCalculadora();




            Console.Write("\nDigite o Primeiro número: ");
            numeroValido = Double.TryParse(Console.ReadLine(), out numero1);

            //Valida Primeiro Número  
            if (!numeroValido)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDigite um Número Válido.\n");
                Console.ResetColor();
                Environment.Exit(1);
            }




            Console.Write("\nDigite a Operação desejada: ");
            operacaoValida = Int32.TryParse(Console.ReadLine(), out operacao);

            //Valida Operação
            if (!operacaoValida)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDigite uma Operação Válida.\n");
                Console.ResetColor();
                Environment.Exit(1);
            }



            // Operação Exponenciação
            if (operacao == 5)
            {
                resultado = Math.Pow(numero1, 2);
                Console.WriteLine($"\n{numero1}² = {resultado}");
            }

            // Operação Radiação
            else if (operacao == 6)
            {
                resultado = Math.Sqrt(numero1);
                Console.WriteLine($"\nA Raiz Quadrada de {numero1} = {resultado}");
            }

            // Operações Simples
            else
            {
                Console.Write("\nDigite o Segundo número: ");
                numero2Valido = Double.TryParse(Console.ReadLine(), out numero2);

                //Valida Numero 2
                if (!numero2Valido)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDigite um Número Válido.\n");
                    Console.ResetColor();
                    Environment.Exit(1);
                }

                switch (operacao)
                {
                    case 1:
                        resultado = numero1 + numero2;
                        Console.WriteLine($"\n{numero1} + {numero2} = {resultado}");
                        break;

                    case 2:
                        resultado = numero1 - numero2;
                        Console.WriteLine($"\n{numero1} - {numero2} = {resultado}");
                        break;

                    case 3:
                        resultado = numero1 * numero2;
                        Console.WriteLine($"\n{numero1} x {numero2} = {resultado}");
                        break;

                    case 4:
                        resultado = numero1 / numero2;
                        Console.WriteLine($"\n{numero1} ÷ {numero2} = {resultado}");
                        break;


                }


            }


        }
        static void ExibeDesenhoCalculadora()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo a nossa Calculadora");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("╔═══════════════╗");
            Console.WriteLine("╠══Calculadora══╣");
            Console.WriteLine("║ MC| MR| M-| M+║");
            Console.WriteLine("║ 1 | 2 | 3 | ÷ ║");
            Console.WriteLine("║ 4 | 5 | 6 | X ║");
            Console.WriteLine("║ 7 | 8 | 9 | - ║");
            Console.WriteLine("║   0   | = | + ║");
            Console.WriteLine("╚═══════════════╝");
            Console.ResetColor();
            Console.WriteLine("Pressione uma tecla para continuar");
            Console.ReadKey();
        }
        static void ApresentaCalculadora()
        {
            Console.WriteLine("▼▼▼ Segue instruções para Operação abaixo ▼▼▼");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("'1' Para soma (+)");
            Console.WriteLine("'2' Para Subtração (-)");
            Console.WriteLine("'3' Para Multiplicação (x)");
            Console.WriteLine("'4' Para Divisão (÷)");
            Console.WriteLine("'5' Para Exponenciação (x²)");
            Console.WriteLine("'6' Para Radiação (√)");
            Console.ResetColor();

        }
    }
}
