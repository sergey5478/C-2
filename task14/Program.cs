/*Напишите программу, которая принимает на вход число
 и проверяет, кратно ли оно одновременно 7 и 23.
 14 -> нет 
46 -> нет 
161 -> да
 */
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int divisionOnSeven = number % 7;
int divisionOn23 = number % 23;
if(divisionOnSeven == 0 && divisionOn23 == 0)
{
    Console.WriteLine($"Число {number} делится на 7 и на 23 без остатка");
}
else
{
    Console.WriteLine($"Число {number} НЕ делится на 7 и на 23 без остатка");
}