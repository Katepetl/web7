
// 
/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

namespace Tasks;

public static class Program
{
    public static void Main()
    {
        // 
        Task52.Execute();
    }

    public static void PrintArray(int[][] arrays)
    {
        foreach (var array in arrays)
        {
            foreach (var item in array)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}

public static class Task52
{
    public static void Execute()
    {
        // случайное кол-во массивов
        var arraysCount = Random.Shared.Next(2, 5);
        // создаю массив массивов
        var arrays = new int[arraysCount][];

        // случайное кол-во длины массива
        var arrayCount = Random.Shared.Next(1, 5);
        // заполняю массивы
        for (var i = 0; i < arraysCount; i++)
        {
            arrays[i] = new int[arrayCount];
            for (var j = 0; j < arrayCount; j++)
                arrays[i][j] = Random.Shared.Next(1, 100);
        }
 
        // вывожу массивы
        Program.PrintArray(arrays);

        // создаю новый массив, что будет хранить значения из столбиков
        var tempArray = new int[arrays.Length];

        // вывожу все среднии арифметическии стобцов
        for (var index = 0; index < arraysCount; index++)
        {
            var x = 0;
            // выставляю в tempArray значения из столбцов
            foreach (var array in arrays)
            {
                tempArray[x] = array[index];
                x++;
            }

            // считаю и вывожу среднее
            var average = tempArray.Average();
            Console.WriteLine($"Среднее арифметическое столбца №{index}: {average}");
        }
    }
}