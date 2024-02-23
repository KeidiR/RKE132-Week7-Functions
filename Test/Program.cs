Console.WriteLine("Do you want to convert into Celsius or Fahrenheit? (C/F)");
char userChoice = Char.Parse(Console.ReadLine());


if (userChoice == 'C')
{
    Console.WriteLine("Enter Fahrenheit:");
    int userInput = Int32.Parse(Console.ReadLine());
    ConverToCelsius(userInput);
}
else
{
    Console.WriteLine("Enter Celsius:");
    int userInput = Int32.Parse(Console.ReadLine());
    ConvertToFahrenheit(userInput);
}

static void ConverToCelsius(int userInput) 
{
    Console.WriteLine($"Converted {userInput} Fahrenheit to {(userInput - 32) * 5 / 9} Celsius.");
    
}
static void ConvertToFahrenheit(int userInput) 
{
    Console.WriteLine($"Converted {userInput} Celsius to {(userInput * 9) / 5 + 32} Fahrenheit."); 
}