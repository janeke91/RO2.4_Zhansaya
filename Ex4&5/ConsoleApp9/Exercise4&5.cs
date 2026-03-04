Console.Write("Enter your deposit amount:");
double d = Convert.ToDouble(Console.ReadLine());

double bonuses = 15;

double rate;

if (d < 100)
{
    rate = 0.05;
}
else if (d >= 100 && d <= 200)
{
    rate = 0.07;
}
else
{
    rate = 0.10;
}


double interest_rate = d + (d * rate) + bonuses;

Console.WriteLine($"Your interest rate depending on the deposit:{interest_rate}");