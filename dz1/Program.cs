// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
System.Console.WriteLine("Введите первое число ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе  число ");
int number2 = Convert.ToInt32(Console.ReadLine());
int degree = number ;

   for (int count = 1; count < number2; count++ )
   {
    degree = degree * number;
   }
System.Console.WriteLine($"натуральная степень {degree}");