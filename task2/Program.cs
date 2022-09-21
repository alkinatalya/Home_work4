// Задача 2: Напишите программу, которая принимает на вход число и 
//выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int SumNumbers(int number)
{
    int number1 = 0;
    int sum = 0;
    number = Math.Abs(number); 
    while (number > 0)
    {
        number1 = number % 10;
        sum = sum + number1;
        number = number / 10;
    }
        return sum ;
}
int number = Prompt("Введите число ->");
System.Console.WriteLine(SumNumbers(number));
