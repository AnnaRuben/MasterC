// HOMEWORK
//
//     Create an array of 3 names. 
//
//     Ask the user which number to select. 
//
//     When the user gives you a number, 
//
// return that name. 
//
//     Make sure to check
//
// for invalid numbers.
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// string[] firstNames = new string[] {"Anna", "Tim", "Victoria"};
//
// Console.Write("Hello User! Please select a number from 1 to 3: ");
// string numberText = Console.ReadLine();
//
// bool isValidNumber = int.TryParse(numberText, out int number);
//
// if (isValidNumber == false)
// {
//     Console.WriteLine("Invalid input!");
// }
// else if (number < 1)
// {
//     Console.WriteLine("Invalid input!");
// }
// else if (number > firstNames.Length)
// {
//     Console.WriteLine("Invalid input!");
// }
// else
// {
//     Console.WriteLine(firstNames[number - 1]);
// }