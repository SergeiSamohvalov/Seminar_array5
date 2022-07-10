namespace Homework_5
{
    public class task_36
    // Задайте одномерный массив, заполненный случайными числами.
    // Найдите сумму элементов, стоящих на нечётных позициях.

    {
        static void Main(string[] args)
        {
            void FillArrayRandom(int[] number)
            {
                int length = number.Length;
                int index = 0;
                while (index < length)
                {
                    number[index] = new Random().Next(1, 10);
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

            void PrintSumNotEven(int[] coll)
            {
                int count = coll.Length;
                int i = 0;
                int Sum = 0;
                while (i < count)
                {
                    if (i % 2 != 0)
                    {
                        Sum = Sum + coll[i];
                    }
                    i++;
                }
                Console.Write("Сумма элементов массива стоящих на нечётных позициях: " + Sum);
            }


            int[] array = new int[10];
            Console.Clear();
            FillArrayRandom(array);
            PrintArray(array);
            Console.WriteLine();
            PrintSumNotEven(array);

        }
    }
}
