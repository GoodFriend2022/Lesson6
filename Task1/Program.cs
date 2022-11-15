// Задача 5: * Найдите максимальное значение в матрице 
// по каждой строке, получите сумму этих максимумов. 
// Затем найдите минимальное значение по каждой колонке,
// получите сумму этих минимумов. Затем из первой суммы 
// (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

int Prompt(string message)
{
    System.Console.Write(message + " > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray(int str, int col)
{
    int[,] array = new int[str, col];
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write(array[i, 0]);
        for (int j = 1; j < array.GetLength(1); j++)
        {
            System.Console.Write($", {array[i, j]}");
        }
        System.Console.WriteLine();
    }
}

int SumMaxRows(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int max = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (max < array[i, j]) max = array[i, j];
        }
        sum += max;
    }
    System.Console.WriteLine(sum);
    return sum;
}

int SumMinColumns(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int min = array[0, i];
        for (int j = 0; j < array.GetLength(0); j++)
        {
            if (min > array[j, i]) min = array[j, i];
        }
        sum += min;
    }
    System.Console.WriteLine(sum);
    return sum;
}


int rows = Prompt("Введите количество строк");
int columns = Prompt("Введите количество столбцов");
int[,] numbers = CreateArray(rows, columns);
PrintArray(numbers);
int defference = SumMaxRows(numbers) - SumMinColumns(numbers);
System.Console.WriteLine($"Разность сумм максимумов в строках и минимумов в столбцах равна => {defference}");



