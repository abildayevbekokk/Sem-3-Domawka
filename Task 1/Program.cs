// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите координаты первой точки: ");
int [] A = new int[2];
for (int i = 0; i < A.Length; i++)
    A[i] = Convert.ToInt32(Console.ReadLine());

if (A[0] != 0 && A[1] != 0)
{
if (A[0] > 0 && A[1] > 0)
Console.WriteLine("Сектор 1");
else if (A[0] > 0 && A[1] < 0)
Console.WriteLine("Сектор 2");
else if (A[0] < 0 && A[1] < 0)
Console.WriteLine("Сектор 3");
else
Console.WriteLine("Сектор 4");
} 
else
Console.WriteLine("Error");

