bool exit = false;
List<double> memory = new List<double>();

while (!exit)
{
    Console.WriteLine("Calculator APP");
    Console.WriteLine("---------------");
    Console.WriteLine("Choose an operation:");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Memory Recall");
    Console.WriteLine("6. Memory Clear");
    Console.WriteLine("0. Exit");

    Console.Write("Enter your choice (0 - 6): ");

    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 0)
    {
        exit = true;
        Console.WriteLine("Exiting the program...");
        break;
    }

    double result = 0;

    switch (choice)
    {
        case 1:
            result = FonkAddition();
            break;

        case 2:
            result = FonkSubtraction();
            break;

        case 3:
            result = FonkMultiplication();
            break;

        case 4:
            result = FonkDivision();
            break;

        case 5:
            result = MemoryRecall(memory);
            continue;

        case 6:
            memory.Clear();
            Console.WriteLine("Memory cleared.");
            continue;

        default:
            Console.WriteLine("Invalid choice.");
            continue;
    }

    memory.Add(result);
    Console.WriteLine("The result is: " + result);
    Console.WriteLine();
}

Console.ReadLine();

static double FonkAddition()
{
    Console.Write("Enter the first number: ");
    double num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second number: ");
    double num2 = Convert.ToInt32(Console.ReadLine());

    return num1 + num2;
}

static double FonkSubtraction()
{
    Console.Write("Enter the first number: ");
    double num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second number: ");
    double num2 = Convert.ToInt32(Console.ReadLine());

    return num1 - num2;
}

static double FonkMultiplication()
{
    Console.Write("Enter the first number: ");
    double num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second number: ");
    double num2 = Convert.ToInt32(Console.ReadLine());

    return num1 * num2;
}

static double FonkDivision()
{
    Console.Write("Enter the first number: ");
    double num1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the second number: ");
    double num2 = Convert.ToInt32(Console.ReadLine());

    if (num2 != 0)
    {
        return num1 / num2;
    }
    else
    {
        Console.WriteLine("You caannot divide by zero!");
        return 0;
    }

}

static double MemoryRecall(List<double> memory)
{
    if (memory.Count == 0)
    {
        Console.WriteLine("Memory is empty.");
        return 0;
    }

    Console.WriteLine("Memory values:");
    for (int i = 0; i < memory.Count; i++)
    {
        Console.WriteLine(i + 1 + ". " + memory[i]);
    }

    Console.Write("Enter the memory index to recall: ");
    int index = Convert.ToInt32(Console.ReadLine());

    if (index >= 1 && index <= memory.Count)
    {
        return memory[index - 1];
    }
    else
    {
        Console.WriteLine("Incalid memory index.");
        return 0;
    }

}

