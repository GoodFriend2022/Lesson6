// Задача 2: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt(string message)
{
    System.Console.Write(message + " > ");
    return Convert.ToDouble(Console.ReadLine());
}

(double, double) FindIntersection(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}

double userK1 = Prompt($"Введите значение k для первой прямой");
double userB1 = Prompt($"Введите значение b для первой прямой");
double userK2 = Prompt($"Введите значение k для второй прямой");
double userB2 = Prompt($"Введите значение b для второй прямой");

System.Console.WriteLine($"Заданные прямые пересекуться в точке => {FindIntersection(userK1, userB1, userK2, userB2)}");
