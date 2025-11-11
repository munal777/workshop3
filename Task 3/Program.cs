Console.WriteLine("Enter your age:");
int age = Convert.ToInt32(Console.ReadLine());

if (age <= 13)
{
    Console.WriteLine("You are Child.");
}
else if (age >13 && age <= 19)
{
    Console.WriteLine("You are Teenager.");
}
else
{
       Console.WriteLine("You are Adult.");
}