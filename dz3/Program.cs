// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

System.Console.WriteLine("Введите количество элементов");
int n = Convert.ToInt32(Console.ReadLine());


int[]Fillarray(int metod)
{
    int[]arr= new int[metod];
    for (int i = 0; i < metod; i++)
    {
        arr[i]= new Random().Next(1, 8);
    }
    return arr;
}
int[] massiv= Fillarray(n);
for (int i = 0; i < n; i++)
{
    System.Console.Write($"{massiv[i]},");
}
System.Console.Write($"{massiv[n-1]}");


