// Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.
// Примеры
// a = 256  => 26
// a = 891  => 81

using System.Globalization;

Console.WriteLine("Введите целое трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int ferstDigit = num / 100;//256/10=2.26=2
    int thirDigit = num % 10;//256%10=250+6=6

    int result = ferstDigit * 10 + thirDigit;

    Console.WriteLine(result);

}
else
{
    Console.WriteLine("Некорректный ввод!");
}