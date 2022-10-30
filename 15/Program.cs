// Напишите программу, которая на вход принимает цифру, обозначающую день недели, и проверяет, является ли этот день выходным
//6->да
//7->да
//1->нет

Console.WriteLine ("Введите цифру дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber)
{
    if (dayNumber ==6 || dayNumber == 7)
    { 
        Console.WriteLine ("день недели - выходной");
    }
    else if (dayNumber <1 || dayNumber >7)
    {
        Console.WriteLine ("цифра не равна дню недели");
    }
    else Console.WriteLine ("день недели не выходной");
}

CheckingTheDayOfTheWeek(dayNumber);