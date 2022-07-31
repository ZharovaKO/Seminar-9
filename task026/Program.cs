// Задача 66: Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Enter the number please: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number please: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int Sum (int a, int b)
{
    if (b == 1) return 1;
    return b + Sum(a, b - 1);
}
Console.WriteLine(Sum(firstNumber, secondNumber));