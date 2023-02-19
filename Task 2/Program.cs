// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите номер четверти: ");
string sector = Console.ReadLine();

switch (sector)
{
    case "1":
    Console.WriteLine("x > 0, y > 0");
    break;
    case "2":
    Console.WriteLine("x > 0, y < 0");
    break;
    case "3":
    Console.WriteLine("x < 0, y < 0");
    break;
    case "4":
    Console.WriteLine("x > 0, y < 0");
    break;
    default:
    Console.WriteLine("Error");
    break;



}

