double num1 = 0; 
double num2 = 0;

Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("--------------------------");

Console.WriteLine("Type a number, and then press Enter");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Type a number, and then press Enter");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Add");
Console.WriteLine("\ts - Subtract");
Console.WriteLine("\tm - Multiply");
Console.WriteLine("\td - Divide");
Console.Write("Your option? ");
string choice = Console.ReadLine();
//double choice = Convert.ToIn32(Console.ReadLine());

switch (choice)
{
	//case 1:
		//break;
	case "a":
		Console.WriteLine($"Your result: {num1} + {num2} = " + ((num1 + num2)));
		break; 
	case "s":
        Console.WriteLine($"Your result: {num1} - {num2} = " + ((num1 - num2)));
        break; 
	case "m":
        Console.WriteLine($"Your result: {num1} * {num2} = " + ((num1 * num2)));
        break; 
	case "d":
        Console.WriteLine($"Your result: {num1} / {num2} = " + ((num1 / num2)));
        break;
	default:
		break;
}
