namespace testing_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool reset = false;
            do
            {
                try
                {
                    
                    calc calc = new calc();
                    double mathInput1 = 0;
                    double mathInput2 = 0;
                    Console.Clear();
                    Console.WriteLine("Please choose a number");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");
                    Console.WriteLine("9. Exit");
                    int menuNum = int.Parse(Console.ReadLine());

                    switch (menuNum)
                    {
                        case 1:
                            Console.WriteLine("enter one number at a time");
                            mathInput1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("+");
                            mathInput2 = double.Parse(Console.ReadLine());
                            calc.Addition(mathInput1, mathInput2);
                            Console.WriteLine("{0} + {1} = {2}", mathInput1, mathInput2, calc.sum);
                            break;
                        case 2:
                            Console.WriteLine("enter one number at a time");
                            mathInput1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("-");
                            mathInput2 = double.Parse(Console.ReadLine());
                            calc.Subtraction(mathInput1, mathInput2);
                            Console.WriteLine("{0} - {1} = {2}", mathInput1, mathInput2, calc.sum);
                            break;
                        case 3:
                            Console.WriteLine("enter one number at a time");
                            mathInput1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("*");
                            mathInput2 = double.Parse(Console.ReadLine());
                            calc.Multiplication(mathInput1, mathInput2);
                            Console.WriteLine("{0} * {1} = {2}", mathInput1, mathInput2, calc.sum);
                            break;
                        case 4:
                            Console.WriteLine("enter one number at a time");
                            mathInput1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("/");
                            mathInput2 = double.Parse(Console.ReadLine());
                            calc.Division(mathInput1, mathInput2);
                            Console.WriteLine("{0} / {1} = {2}", mathInput1, mathInput2, calc.sum);
                            break;
                        case 9:
                            Environment.Exit(1);
                            break;
                        default:
                            Console.WriteLine("please enter a valid number");
                            break;
                    }

                }
                catch (Exception ex)
                { 
                    Console.WriteLine("Error: {0}",ex);
                }
                Console.WriteLine("press any key to continue");
                Console.ReadKey();
            } while (reset == false);
        }
    }
}