// See https://aka.ms/new-console-template for more information
string Number = Console.ReadLine();
int length = Number.Length;
long number = Convert.ToInt64(Number);
long [] Massive = new long[length];
int count=0;
for (int i = 0; i < length; i++)
    Massive[i] = (long)(number % Math.Pow(10, length - i))  / (long)Math.Pow(10, length - 1 - i);
        
for (int i = 0; i <= length/2; i++)
{   
    if (Massive[i] == Massive[length - 1 - i])
       count+=1;   
}
if (count==(length/2)+1)
Console.WriteLine("da");
else
Console.WriteLine("net");