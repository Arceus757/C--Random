internal class Program
{
    private static void Main(string[] args)
    {
        // // Uppgift 1
        // Random random = new Random();

        // for (int i = 0; i < 100; i++)
        // {
        //     int randomNumber = random.Next(1, 101);
        //     Console.WriteLine(randomNumber);
        // }

        // // Uppgift 2
        // Random random = new Random();
        // int targetNumber = random.Next(1, 101);
        // int guess = 0;
        // int attempts = 0;

        // Console.WriteLine("Guess the secret number between 1-100:");

        // while (guess != targetNumber)
        // {
        //     string input = Console.ReadLine();
        //     if (int.TryParse(input, out guess))
        //     {
        //         attempts++;
        //         if (guess < targetNumber)
        //         {
        //             Console.WriteLine("Guess higher.");
        //         }
        //         else if (guess > targetNumber)
        //         {
        //             Console.WriteLine("Guess lower.");
        //         }
        //         else
        //         {
        //             Console.WriteLine($"Correct! It took you {attempts} tries to guess right.");
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine("Wrong input, try again.");
        //     }
        // }

        // Uppgift 3
    //     Console.WriteLine("Enter the number of dice rolls (e.g., 2T6 for two 6-sided dice):");
    //     string input = Console.ReadLine();
    //     RollDice(input);
    // }

    // private static void RollDice(string input)
    // {
    //     string[] parts = input.Split('T');
    //     if (parts.Length != 2 || !int.TryParse(parts[0], out int numberOfRolls) || !int.TryParse(parts[1], out int numberOfSides))
    //     {
    //         Console.WriteLine("Invalid input. Please enter in the format '2T6' for two 6-sided dice.");
    //         return;
    //     }

    //     Random random = new Random();
    //     for (int i = 0; i < numberOfRolls; i++)
    //     {
    //         int roll = random.Next(1, numberOfSides + 1);
    //         Console.WriteLine($"Roll {i + 1}: {roll}");
    //     }

        // Uppgift 4
        Console.WriteLine("Enter the number of dice rolls (e.g., 6T12 for six 12-sided dice):");
        string input = Console.ReadLine();
        RollDice(input);
    }

    private static void RollDice(string input)
    {
        // Split the input by 'T' to handle the format '6T12'
        string[] parts = input.Split('T');
        if (parts.Length != 2 || !int.TryParse(parts[0], out int numberOfRolls) || !int.TryParse(parts[1], out int numberOfSides))
        {
            Console.WriteLine("Invalid input. Please enter in the format '6T12' for six 12-sided dice.");
            return;
        }

        Random random = new Random();
        Console.WriteLine($"Rolling {numberOfRolls} dice with {numberOfSides} sides each:");
        for (int i = 0; i < numberOfRolls; i++)
        {
            int roll = random.Next(1, numberOfSides + 1);
            Console.WriteLine($"Roll {i + 1}: {roll}");
        }

    }
}