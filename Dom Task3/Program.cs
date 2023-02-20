// See https://aka.ms/new-console-template for more information
void FillArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
} 
Console.WriteLine("Введите координаты первой точки: ");
int [] DotOne = new int[3];
FillArray(DotOne);
Console.WriteLine("Введите координаты второй точки: ");
int [] DotTwo = new int[3];
FillArray(DotTwo);
int SideX = DotTwo[0] - DotOne[0];
int SideY = DotTwo[1] - DotOne[1];
int SideZ = DotTwo[2] - DotOne[2];
double result = Math.Sqrt(Math.Pow(SideX, 2) + Math.Pow(SideY, 2) + Math.Pow(SideZ, 2));
Console.WriteLine($"Расстояние между точками = {Math.Round(result, 2)}");
