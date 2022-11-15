// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

double Prompt(string message)
{
    System.Console.Write(message + " > ");
    return Convert.ToDouble(Console.ReadLine());
}

double[] UserArray(int userAmount)
{
    double[] array = new double[userAmount];
    array[0] = Prompt("Начните вводить любые числа");
    for (int i = 1; i < userAmount; i++)
    {
        array[i] = Prompt("и ещё");
    }
    return array;
}

void PrintArray(double[] array)
{
    int length = array.Length;
    System.Console.Write(array[0]);
    for (int i = 1; i < length; i++)
    {
        System.Console.Write($"; {array[i]}");
    }
}

int AmountPositiveNumbers(double[] array)
{
    int amountNumbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) amountNumbers++;
    }
    return amountNumbers;
}

int amount = Convert.ToInt32(Prompt("Укажите количество чисел, на ввод которых Вы готовы потратить время"));
double[] numbers = UserArray(amount);
System.Console.WriteLine("И так, подытожим, Вы ввели следующие значения:");
PrintArray(numbers);
System.Console.WriteLine();
System.Console.WriteLine($"из них {AmountPositiveNumbers(numbers)} положительных");



