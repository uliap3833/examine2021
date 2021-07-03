using System;
using System.IO;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            int k = 1;
            int[,] a;
            int[,] b;
            int[,] sum;
            Console.WriteLine("Выберите способ ввода начальных данных 1-ручной 2-из файла");
            char choise = Char.Parse(Console.ReadLine());
            switch (choise)
            {
                case '1':
                    Console.WriteLine("Введите размер массивов a и b");

                    n = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Введите массив a");

                    a = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        int l = 1;
                        for (int j = 0; j < n; j++)
                        {
                            Console.WriteLine("Введите " + k + ", " + l + " число");
                            a[i, j] = Int32.Parse(Console.ReadLine());
                            l++;
                        }
                        k++;
                    }
                    k = 1;
                    Console.WriteLine("Введите массив b");
                    b = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        int l = 1;
                        for (int j = 0; j < n; j++)
                        {
                            Console.WriteLine("Введите " + k + ", " + l + " число");
                            b[i, j] = Int32.Parse(Console.ReadLine());
                            l++;
                        }
                        k++;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Массив а");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(a[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("Массив b");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(b[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("Сложение массивов");
                    sum = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            sum[i, j] = a[i, j] + b[i, j];
                        }
                    }

                    Console.WriteLine("Массив сумм");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(sum[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    break;
                case '2':
                    Console.WriteLine("Введите путь к файлу");
                    string filename = Console.ReadLine();
                    string[] file = File.ReadAllLines(filename);
                    string[] data = file[0].Split(';');
                    n = Int32.Parse(data[0]);
                    string[] arrA = data[1].Split(','); 
                    a = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            a[i, j] = Int32.Parse(arrA[i+j]);
                        }
                    }
                    string[] arrB = data[2].Split(',');
                    b = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            b[i, j] = Int32.Parse(arrB[i + j]);
                        }
                    }

                    Console.WriteLine();
                    Console.WriteLine("Массив а");

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(a[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("Массив b");
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(b[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }


                    Console.WriteLine("Сложение массивов");
                    StreamWriter f = new StreamWriter("result.txt");
                    string result = "";
                    sum = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            sum[i, j] = a[i, j] + b[i, j];
                            result += sum[i, j] + "\t";
                            
                        }
                        f.WriteLine(result);
                        result = "";
                    }
                    f.Close();
                    Console.WriteLine("Массив сумм");


                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(sum[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
