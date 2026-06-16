

while (true)
{
    Console.Write("Enter first number: ");
    string input = Console.ReadLine();

    if (input.ToLower() == "exit")
        break;

    double num1 = Convert.ToDouble(input);

    Console.Write("Enter second number: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter operator: ");
    string operatorr = Console.ReadLine();

    double result = 0;

    if (operatorr == "+")
    {
        result = num1 + num2;
    }
    else if (operatorr == "-")
    {
        result = num1 - num2;
    }
    else if (operatorr == "*")
    {
        result = num1 * num2;
    }
    else if (operatorr == "/")
    {
        result = num1 / num2;
    }
    else
    {
        Console.WriteLine("Invalid operator");
        continue;
    }

    Console.WriteLine("Result: " + result);
    Console.WriteLine();
}
//Console.WriteLine("Program ends");





