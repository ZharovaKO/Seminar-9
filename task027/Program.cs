// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

Console.Write("Enter the number please: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number please: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int AkkermanFunction(int a, int b)
{
    if (a == 0) return b + 1;
    else if (b == 0) return AkkermanFunction(a - 1, 1);
    else return AkkermanFunction(a - 1, AkkermanFunction(a, b - 1));
}
Console.WriteLine(AkkermanFunction(firstNumber, secondNumber));