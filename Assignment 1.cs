// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


class GradeCalculator
{
    static void Main()
    {
        Console.WriteLine("Grade Calculator");


        double mathMarks, scienceMarks, englishMarks;
        Console.Write("Enter marks for Mathematics: ");
        if (!double.TryParse(Console.ReadLine(), out mathMarks) || mathMarks < 0 || mathMarks > 100)
        {
            Console.WriteLine("Invalid input for Mathematics marks. Exiting program.");
            return;
        }

        Console.Write("Enter marks for Science: ");
        if (!double.TryParse(Console.ReadLine(), out scienceMarks) || scienceMarks < 0 || scienceMarks > 100)
        {
            Console.WriteLine("Invalid input for Science marks. Exiting program.");
            return;
        }

        Console.Write("Enter marks for English: ");
        if (!double.TryParse(Console.ReadLine(), out englishMarks) || englishMarks < 0 || englishMarks > 100)
        {
            Console.WriteLine("Invalid input for English marks. Exiting program.");
            return;
        }

        // Calculate average marks
        double averageMarks = (mathMarks + scienceMarks + englishMarks) / 3;

        // Determine final grade using switch case
        char finalGrade;
        switch ((int)averageMarks / 10)
        {
            case 10:
            case 9:
                finalGrade = 'A';
                break;
            case 8:
                finalGrade = 'B';
                break;
            case 7:
                finalGrade = 'C';
                break;
            case 6:
                finalGrade = 'D';
                break;
            default:
                finalGrade = 'F';
                break;
        }

        // Display average marks and final grade
        Console.WriteLine($"\nAverage marks: {averageMarks:F}\n");
        Console.WriteLine($"Final Grade: {finalGrade}");

    }
}


class TemperatureConverter
{
    static void Main()
    {
        Console.WriteLine("Temperature Converter");

        while (true)
        {
            // Choose temperature scale
            Console.WriteLine("\nChoose the temperature scale to convert from:");
            Console.WriteLine("1. Celsius\n2. Fahrenheit");
            Console.Write("Enter your choice: ");

            // Input choice
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Invalid choice. Exiting program.");
                return;
            }

            // Input temperature
            double temperature;
            string fromScale, toScale;

            if (choice == 1)
            {
                fromScale = "Celsius";
                toScale = "Fahrenheit";
                Console.Write($"\nEnter the temperature in {fromScale}: ");
            }
            else
            {
                fromScale = "Fahrenheit";
                toScale = "Celsius";
                Console.Write($"\nEnter the temperature in {fromScale}: ");
            }

            if (!double.TryParse(Console.ReadLine(), out temperature))
            {
                Console.WriteLine("Invalid input for temperature. Exiting program.");
                return;
            }

            // Convert temperature
            double convertedTemperature = (choice == 1) ? (temperature * 9 / 5) + 32 : (temperature - 32) * 5 / 9;

            // Display converted temperature
            Console.WriteLine($"\n{temperature}{fromScale} is equal to {convertedTemperature:F}{toScale}.");

            // Ask if user wants to convert another temperature
            Console.Write("\nDo you want to convert another temperature? (Y/N): ");
            char continueChoice = char.ToUpper(Console.ReadKey().KeyChar);
            if (continueChoice != 'Y')
            {
                Console.WriteLine("\n\nThank you for using the temperature converter!");
                break;
            }
        }
    }
}



