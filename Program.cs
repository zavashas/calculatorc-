namespace calculatorc_
{
   
            class Calculator
        {
            static void Main(string[] args)
            {
                int operation = 0;
                int a, b;

                while (operation != 9)
                {
                    Console.WriteLine("Выберите операцию:");
                    Console.WriteLine("1. Сложить 2 числа");
                    Console.WriteLine("2. Вычесть первое из второго");
                    Console.WriteLine("3. Перемножить два числа");
                    Console.WriteLine("4. Разделить первое на второе");
                    Console.WriteLine("5. Возвести в степень N первое число");
                    Console.WriteLine("6. Найти квадратный корень из числа");
                    Console.WriteLine("7. Найти 1 процент от числа");
                    Console.WriteLine("8. Найти факториал из числа");
                    Console.WriteLine("9. Выйти из программы");

                    operation = Convert.ToInt32(Console.ReadLine());

                    switch (operation)
                    {
                        case 1:
                            Console.WriteLine("Введите первое число:");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число:");
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {a + b}");
                            break;
                        case 2:
                            Console.WriteLine("Введите первое число:");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число:");
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {a - b}");
                            break;
                        case 3:
                            Console.WriteLine("Введите первое число:");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число:");
                            b = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {a * b}");
                            break;
                        case 4:
                            Console.WriteLine("Введите первое число:");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите второе число:");
                            b = Convert.ToInt32(Console.ReadLine());
                            
                        if (b != 0)
                        {
                            double division = a / b;
                            Console.WriteLine("Результат: " + division);
                        }
                        else
                        {
                            Console.WriteLine("Ошибка: деление на ноль");
                        }
                        break;
                        case 5:
                            Console.WriteLine("Введите число:");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Введите степень:");
                            int power = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {Math.Pow(a, power)}");
                            break;
                        case 6:
                            Console.WriteLine("Введите число:");
                            a = Convert.ToInt32(Console.ReadLine());
                            
                        if(a >= 0)
                    {
                            double sqrt = Math.Sqrt(a);
                            Console.WriteLine("Результат: " + sqrt);
                        }
                    else
                        {
                            Console.WriteLine("Ошибка: отрицательное число под корнем");
                        }
                        break;
                        case 7:
                            Console.WriteLine("Введите число:");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine($"Результат: {a * 0.01}");
                            break;
                        case 8:
                            Console.WriteLine("Введите число:");
                            a = Convert.ToInt32(Console.ReadLine());
                            int factorial = 1;
                            for (int i = 1; i <= a; i++)
                            {
                                factorial *= i;
                            }
                            Console.WriteLine($"Результат: {factorial}");
                            break;
                        case 9:
                            Console.WriteLine("Программа завершена.");
                            break;
                        default:
                            Console.WriteLine("Некорректный выбор операции. Попробуйте еще раз.");
                            break;
                    }
                }
            }
        }
    }
    
