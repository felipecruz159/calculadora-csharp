namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string confirm;
            do
            {
                Console.WriteLine("Digite a operação desejada:");
                Console.WriteLine("(Digite o número da operação matemática)");
                Console.WriteLine("1- Adição\n2- Subtração\n3- Multiplicação\n4- Divisão\n");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Adição selecionada!\n");
                        Addition();
                        break;

                    case 2:
                        Console.WriteLine("Subtração selecionada!\n");
                        Subtraction();
                        break;

                    case 3:
                        Console.WriteLine("Multiplicação selecionada!\n");
                        Multiplication();
                        break;

                    case 4:
                        Console.WriteLine("Divisão selecionada!\n");
                        Division();
                        break;

                    default:
                        Console.WriteLine("Nenhuma operação foi selecionada!");
                        Console.WriteLine("Tente novamente!");
                        Environment.Exit(0);
                        break;
                }

                Console.WriteLine("Deseja refazer a operação? <S/N>");
                confirm = Console.ReadLine();

                Console.Clear();

            } while (confirm.ToUpper() == "S");

            Console.WriteLine("Fim do programa!");
            Console.ReadKey();
        }
        static void Addition()
        {
            Console.WriteLine("Digite a quantidade de números que deseja na operação:");
            int quantity = int.Parse(Console.ReadLine());

            Console.Clear();

            double[] operation = new double[quantity];

            double sum = 0;
            for (int i = 0; i < quantity; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número da operação: ");
                operation[i] = double.Parse(Console.ReadLine());
            }

            Console.Clear();

            foreach (double i in operation)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }

            Console.WriteLine();
            Console.WriteLine($"A soma dos {quantity} números é de: {sum}!");
        }

        static void Subtraction()
        {
            Console.WriteLine("Digite a quantidade de números que deseja na operação:");
            int quantity = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Digite o 1º número da operação");
            double number1 = double.Parse(Console.ReadLine());

            double[] operation = new double[quantity]; 

            double subtraction = 0;
            for (int i = 0; i < quantity - 1; i++) 
            { 
                Console.WriteLine($"Digite o {i + 2}º número da operação: ");
                operation[i] = double.Parse(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine(number1);

            subtraction = number1;
            foreach (double i in operation)
            {
                if (i != 0)
                {
                    Console.WriteLine(i);
                    subtraction = subtraction - i;
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"A subtração dos {quantity} números é de: {subtraction}!");
        }

        static void Multiplication()
        {
            Console.WriteLine("Digite a quantidade de números que deseja na operação:");
            int quantity = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Digite o 1º número da operação");
            double number1 = double.Parse(Console.ReadLine());

            double[] operation = new double[quantity];

            double multiplication = 0;
            for (int i = 0; i < quantity - 1; i++)
            {
                Console.WriteLine($"Digite o {i + 2}º número da operação: ");
                operation[i] = double.Parse(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine(number1);

            multiplication = number1;
            foreach (double i in operation)
            {
                if (i != 0)
                {
                    Console.WriteLine(i);
                    multiplication = multiplication * i;
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"A multiplicação dos {quantity} números é de: {multiplication}!");
        }
        
        static void Division()
        {
            Console.WriteLine("Digite a quantidade de números que deseja na operação:");
            int quantity = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Digite o 1º número da operação");
            double number1 = double.Parse(Console.ReadLine());

            double[] operation = new double[quantity];

            double division = 0;
            for (int i = 0; i < quantity - 1; i++)
            {
                Console.WriteLine($"Digite o {i + 2}º número da operação: ");
                operation[i] = double.Parse(Console.ReadLine());
            }
            Console.Clear();

            Console.WriteLine(number1);

            division = number1;
            foreach (double i in operation)
            {
                if (i != 0)
                {
                    Console.WriteLine(i);
                    division = division / i;
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"A multiplicação dos {quantity} números é de: {division}!");
        }
    }
}