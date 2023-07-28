//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа

/*
int SecondDigit(int num)
{
    int tens = (num / 10) % 10;
    return tens;

}
 Console.Write("Input the three-digit number : ");
 int num = Convert.ToInt32(Console.ReadLine());

 int result = SecondDigit(num);
 Console.WriteLine($"The middle digit is: {result}");

 */

//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа ( или -1, если третьей цифры нет).

/*

int GetThirdDigit(int number)
{
    
// Этот метод позволяет не беспокоиться о разрядности и знаке числа, вводимого 
// в программу. Определив размер числа, программа делит его на 10 в степени
// на 3 меньше, чем размер числа. Далее вычисляем остаток делением на % 10 
//и третья цифра у нас в кармане :)


    int numLength = (int)Math.Log10(Math.Abs(number)) + 1;
    if (numLength >=3)
    {
        number = number / (int)Math.Pow(10, numLength - 3);
        int thirdDigit = Math.Abs(number) % 10;
        return thirdDigit;

    }
    else  return -1;
}
    
Console.Write("Enter any Number: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit = GetThirdDigit(number);
if(thirdDigit != -1)
    Console.WriteLine($"Третья цифра числа (number) равна: {thirdDigit}");

else
    Console.WriteLine($"Третьей цифры в числе {number} нет, результат: -1");
 */


 // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
 // и проверяет, является ли этот день выходным.
 
/*
 bool IsWeekend(int dayNumber)
 {
    return dayNumber == 5 || dayNumber == 6;

 }
 Console.Write("Введите цифру дня недели (0 - пн, 1 - вт, 2 - ср, 3 - чт, 4 - пт, 5 - сб, 6 - вс): ");
 int dayNumber = Convert.ToInt32(Console.ReadLine());

 if(dayNumber>=0 && dayNumber <=6)
 {
     if (IsWeekend(dayNumber))
     Console.WriteLine("Это выходной день. ");
    
     else Console.WriteLine("Это рабочий день. ");
 }
 else Console.WriteLine("Некорректный ввод. Введите число от 0 до 6. ");
 */