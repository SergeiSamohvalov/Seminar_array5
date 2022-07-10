namespace Homework_5
{
       public class task_34

    // Задайте массив заполненный случайными положительными трёхзначными числами.
    //  Напишите программу, которая покажет количество чётных чисел в массиве. 
    {
        static void Main(string[] args)
        {
            void FillArray(int[] number)
            {
                int length = number.Length;
                int index = 0;
                while (index < length)
                {
                    number[index] = new Random().Next(0, 999);
                    index++;
                }
            }

            void PrintArray(int[] mass)
            {
                int count = mass.Length;
                int index = 0;
                while (index < count)
                {
                    Console.Write($"{mass[index].ToString()} ");
                    index++;
                }
            }

            void PrintAmt(int[] coll)
            {
                int count = coll.Length;
                int i = 0;
                int Sum =0;
                while (i < count)
                {
                    if (coll[i] % 2 == 0)
                    {
                        Sum = Sum + 1;
                    }
                    i++;
                }
                Console.Write("Колличество четных чисел в массиве: " + Sum);
            }

            int[] array = new int[10];
            Console.Clear();
            FillArray(array);
            PrintArray(array);
            Console.WriteLine();
            PrintAmt(array);

        }
    }
}