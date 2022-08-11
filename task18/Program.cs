/*Задача 18: Напишите программу, которая
 по заданному номеру четверти, показывает 
 диапазон возможных координат точек в этой четверти (x и y).
*/
string getCoordinatesFromQuarter(int quarter)
{
    string awalibaleQuarter = "x > 0 and y > 0";
    if (quarter == 1)
    {
        awalibaleQuarter = "x > 0 and y > 0";
    }
    else if (quarter == 2)
    {
        awalibaleQuarter = "x < 0 and y > 0";
    }
    else if (quarter == 3)
    {
        awalibaleQuarter = "x < 0 and y < 0";
    }
    else if (quarter == 4)
    {
        awalibaleQuarter = "x > 0 and y < 0";
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Возможен подбор значений для одной из четырех четвертей {quarter} ");
        Console.ResetColor();
    }
    return awalibaleQuarter;
}

Console.WriteLine("Введите Четверть: ");
int quarter = Convert.ToInt32(Console.ReadLine());
string answer = getCoordinatesFromQuarter(quarter);
Console.WriteLine($"Возможные значения для четверти: {answer} ");
