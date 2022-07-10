namespace Homework_5
{
    public class task_38

    // Задайте массив вещественных чисел.
    // Найдите разницу между максимальным и минимальным элементов массива.
    {
        static void Main(string[] args)
        {
            void FillArrayRandom(int[] number)
            {
                int length = number.Length;
                int index = 0;
                while (index < length)
                {
                    number[index] = new Random().Next(1, 100);
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

            void PrintDiffMaxMin(int[] diff)
            {
                int count = diff.Length;
                int i = 0;
                int max = 0;
                int min = diff[i];
                int Diff = 0;
                while (i < count)
                {
                     if (diff[i] > max) max = diff[i]; 
                else if (diff[i] < min) min = diff[i];
                i++;
                }
                                  
                Diff = max - min;

                Console.Write("Разница между max и min элементами массива = " + Diff);
            }

            int[] array = new int[10];
            Console.Clear();
            FillArrayRandom(array);
            PrintArray(array);
            Console.WriteLine();
            PrintDiffMaxMin(array);
        }
    }
}
