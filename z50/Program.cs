
// 
/*Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, 
что такого элемента нет.Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/

namespace Tasks;

public static class Program
{
    public static void Main()
    {
        // 
        Task0.Execute();
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

public static class Task0
{
    public static void Execute()
    {
        // создаем массив
        var arraysCount = Random.Shared.Next(3, 4);
        var arrays = new int[arraysCount][];

        var lineCount = Random.Shared.Next(3, 4);
        for (var q = 0; q < arraysCount; q++)
        {
            arrays[q] = new int[lineCount];
            for (var j = 0; j < lineCount; j++)
                arrays[q][j] = Random.Shared.Next(2, 10);
        }

        // считываем число для поиска индекса
        Console.WriteLine("Vvedite chislo");
        var value = Convert.ToInt32(Console.ReadLine());

        // вывод массива
        Program.PrintArray(arrays);

        // получаем все индексы
        var allIndexOf = GetAllIndexOf(arrays, value);
        // если кол-во индексов равно 0, то выводим Такого числа нет в массиве
        if (allIndexOf.Count == 0)
            Console.WriteLine("Такого числа нет в массиве");
        // иначе
        else 
            // перебираю и вывожу все индексы
            foreach (var index in allIndexOf)
                Console.WriteLine(index);
    }

    /// <summary>
    /// Находит все индексы значения в форме (X, Y)
    /// </summary>
    /// <param name="arrays">двумерный массив, в котором надо искать value - значение</param>
    /// <param name="value">то, что надо найти</param>
    /// <returns>Список индексов, если не найдены, то длина списка будет равна 0</returns>
    private static List<(int x, int y)> GetAllIndexOf(int[][] arrays, int value)
    {
        // новый лист, кол-во которого по умолчанию равно 0
        var list = new List<(int x, int y)>();

        var y = 0;
        foreach (var array in arrays)
        {
            var x = 0;
            foreach (var item in array)
            {
                if (item == value)
                    list.Add((x, y));
                x++;
            }

            y++;
        }

        return list;
    }
}