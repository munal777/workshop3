// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter a nummber: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i<=num; i++)
{
     sum+=i;
}
Console.WriteLine("The sum of first "+num+" natural numbers is: "+sum);
int num1 = 1;

while (num1 <= 20)
{
    if (num1 % 4 == 0)
    {
        num1++;
        continue;
    }

    if (num1 == 15)
    {
        break;
    }

    Console.WriteLine("Current number: " + num1);
    num1++;
}



int[] num2 = { 10, 20, 30, 40, 50 };
int sum2 = 0;
foreach (int n in num2)
{
    sum2 += n;
}
Console.WriteLine("The sum of array elements is: " + sum2);