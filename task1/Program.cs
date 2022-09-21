//Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number1 = Prompt("Введите первое число:");
int number2 = Prompt("Введите второе число:");
 int result = 1;
//Square(number);

if (number2 > 0)
{
    if (number2 == 1)
    {
        System.Console.WriteLine($"Число {number1} в степени {number2} => {number1}");
    }
    else
    {
        for (int index = 1; index < number2+1; index++) 
        {
            result = result * number1;
        }
    System.Console.WriteLine($"Число {number1} в степени {number2} => {result}");
    }

}
else
{
    System.Console.WriteLine("Второе число должно быть натуральным");
}
