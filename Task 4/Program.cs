// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter any nuimber from 1-7: ");

int num=Convert.ToInt32(Console.ReadLine());

switch(num)
{
    case 1:
    Console.WriteLine("Monday");
    break;
    case 2:
    Console.WriteLine("Tuesday");
    break;
    case 3:
    Console.WriteLine("Wednesday");
    break;
    case 4:
    Console.WriteLine("Thursday");
    break;
    case 5:
    Console.WriteLine("Friday");
    break;
    case 6:
    Console.WriteLine("Saturday");
    break;
    case 7:
    Console.WriteLine("Sunday");
    break;
    default:
    Console.WriteLine("Invalid Input");
    break;
}