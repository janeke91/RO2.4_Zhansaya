Console.Write("Enter operation number(1 or 2 or 3):");
double op = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter a number:");
double n1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter another number:");
double n2 = Convert.ToDouble(Console.ReadLine());

switch (op)
{
    case 1:
        Console.WriteLine("Chosen operation is Addition");
        double answer_ad;
        answer_ad = n1 / n2;
        Console.WriteLine($"Answer: {answer_ad}");
        break;

    case 2:
        Console.WriteLine("Chosen operation is Substraction");
        double answer_sub;
        answer_sub = n1 - n2;
        Console.WriteLine($"Answer: {answer_sub}");
        break;
            
    case 3:
        Console.WriteLine("Chosen operation is Multiplication");
        double answer_mul;
        answer_mul = n1 * n2;
        Console.WriteLine($"Answer: {answer_mul}");
        break;
    
    default:
        Console.WriteLine("Operation is undefined");
        break;
}
