using System; // Imports the System namespace

internal class NewBaseType // Declares a new class
{
    static void Main() // Main method
    {
        // Display a welcome message to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");

        // Prompt the user to enter the weight of the package
        Console.Write("Please enter the package weight: ");
        float weight = float.Parse(Console.ReadLine()); // Reads input from user and converts it to float

        // Check if the package weight exceeds the limit of 50
        if (weight > 50)
        {
            // Display a message if the weight is too heavy
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Ends the program if the weight is too heavy
        }

        // Prompt the user to enter the package's width
        Console.Write("Please enter the package width: ");
        float width = float.Parse(Console.ReadLine()); // Reads input and converts to float

        // Prompt the user to enter the package's height
        Console.Write("Please enter the package height: ");
        float height = float.Parse(Console.ReadLine()); // Reads input and converts to float

        // Prompt the user to enter the package's length
        Console.Write("Please enter the package length: ");
        float length = float.Parse(Console.ReadLine()); // Reads input and converts to float

        // Calculate the total dimensions of the package (sum of width, height, and length)
        float dimensionTotal = width + height + length;

        // Check if the total dimensions exceed the limit of 50
        if (dimensionTotal > 50)
        {
            // Display a message if the package is too large
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Ends the program if the package is too large
        }

        // Calculate the shipping quote based on package dimensions and weight
        float quote = (width * height * length * weight) / 100;

        // Display the shipping quote to the user with two decimal points
        Console.WriteLine($"\nYour estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
}

class Program : NewBaseType 
{

}
