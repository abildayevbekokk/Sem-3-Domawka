// See https://aka.ms/new-console-template for more information
void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
} 
Console.WriteLine("Введите координаты первой точки: ");
int [] DotOne = new int[2];
FillArray(DotOne);
Console.WriteLine("Введите координаты второй точки: ");
int [] DotTwo = new int[2];
FillArray(DotTwo);
int KatetX = DotTwo[0] - DotOne[0];
int KatetY = DotTwo[1] - DotOne[1];
double result = Math.Sqrt(Math.Pow(KatetX, 2) + Math.Pow(KatetY, 2));
Console.WriteLine(result, 2);