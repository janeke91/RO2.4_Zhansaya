Console.WriteLine("Enter the first number:");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the second number:");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine("First entered number is larger than the second");
}
else if (n2 > n1)
{
    Console.WriteLine("Second entered number is larger than the first");
}
else
{
    Console.WriteLine("Two entered numbers are equal :)");
}
