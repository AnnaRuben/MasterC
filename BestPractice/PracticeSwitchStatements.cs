//C# — Switch Statements Practice
//Exercise 1 — Traffic Light
//Create a variable named:
//`trafficLight`

//The variable contains one of the values:
//`red`
//`yellow`
//`green`

//The program should print:
//For `red` → `Stop`
//For `yellow` → `Get ready`
//For `green` → `Go`

//For any other value → `Unknown traffic light`

//The system should accept the words whether the user has typed upper or lower case letters.


// Console.Write("Please choose one of the following options for traffic light; red, yellow, or green: ");
// string? trafficLight = Console.ReadLine();
//
// switch (trafficLight.ToLower())
// {
//     case "red":
//         Console.WriteLine("Stop");
//         break;
//     case "yello" :
//         Console.WriteLine("Get ready");
//         break;
//     case "green":
//         Console.WriteLine("go");
//         break;
//     default:
//         Console.WriteLine("Unknown traffic light");
//         break;
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 2 — User Role
//Create a variable named:
//`role`

//Possible values:
//`admin`
//`manager`
//`employee`
//`guest`

//Print:
//`admin` → `Full access`
//`manager` → `Management access`
//`employee` → `Employee access`
//`guest` → `Guest access`
//Any other value → `Unknown role`

//Case is irrelevant.


// Console.Write("Please enter your role; admin, manager, employee, or guest: ");
// string role = Console.ReadLine();
//
// switch (role.ToLower())
// {
//     case "admin":
//         Console.WriteLine("Full access");
//         break;
//     case "manager":
//         Console.WriteLine("Management access");
//         break;
//     case "employee":
//         Console.WriteLine("Employee access");
//         break;
//     case "guest":
//         Console.WriteLine("Guest access");
//         break;
//     default:
//         Console.WriteLine("Unknown role");
//         break;
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 3 — School Grade
//Create an `int` variable named:
//`grade`

//The grade can be between `0` and `100`.
//Print:
//`0–54` → `Failed`
//`55–69` → `Passed`
//`70–84` → `Good`
//`85–94` → `Very good`
//`95–100` → `Excellent`

//If the number is not a possible grade:
//`Invalid grade`


// int grade = 65;
//
// switch (grade)
// {
//     case >= 0 and < 55:
//         Console.WriteLine("Failed");
//         break;
//     case >= 55 and < 70:
//         Console.WriteLine("Passed");
//         break;
//     case >= 70 and < 85:
//         Console.WriteLine("Good");
//         break;
//     case >= 85 and < 95:
//         Console.WriteLine("Very good");
//         break;
//     case >= 95 and < 101:
//         Console.WriteLine("Excellent");
//         break;
//     default:
//         Console.WriteLine("Invalid grade");
//         break;
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 4 — Day Type
//Create a variable named:
//`day`

//The possible values ​​are the names of the days in English:
//`monday`
//`tuesday`
//`wednesday`
//`thursday`
//`friday`
//`saturday`
//`sunday`

//The program should print:
//Monday to Thursday → `Regular work day`
//Friday → `Short day`
//Saturday → `Weekend`
//Sunday → `Start of the week`

//Any other value → `Invalid day`

//The case is irrelevant.


// Console.Write("Please choose a day of the week; monday, tuesday, wednesday, thursday, friday, saturday, or sunday: ");
// string? day = Console.ReadLine();
//
// switch (day.ToLower())
// {
//     case "monday" or "tuesday" or "wednesday" or "thursday":
//         Console.WriteLine("Regular work day");
//         break;
//     case "friday":
//         Console.WriteLine("Short day");
//         break;
//     case "saturday":
//         Console.WriteLine("Weekend");
//         break;
//     case "sunday":
//         Console.WriteLine("Start of the week");
//         break;
//     default:
//         Console.WriteLine("Invalid day");
//         break;
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 5 — Ticket Price Category
//Create an `int` variable named:
//`age`

//Print:
//Age `0–5` → `Free ticket`
//Age `6–12` → `Child ticket`
//Age `13–17` → `Teen ticket`
//Age `18–64` → `Adult ticket`
//Age `65` and above → `Senior ticket`

//Negative age should print:
//`Invalid age`


// int age = 35;
//
// switch (age)
// {
//     case 0 >= and < 6:
//         Console.WriteLine("Free ticket");
//         break;
//     case >= 6 and < 13:
//         Console.WriteLine("Child ticket");
//         break;
//     case 13 >= and < 18:
//         Console.WriteLine("Teen ticket");
//         break;
//     case >= 18 and < 65:
//         Console.WriteLine("Adult ticket");
//         break;
//     case >= 65:
//         Console.WriteLine("Senior ticket");
//         break;
//     default:
//         Console.WriteLine("Invalid age");
//         break;
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 6 — Department
//Create a variable named:
//`department`

//Values:
//`development`
//`qa`
//`automation`
//`support`
//`sales`

//Requirements:
//`development` and `automation` should print:
//`Technical department`

//`qa` should print:
//`Quality department`

//`support` should print:
//`Support department`

//`sales` should print:
//`Sales department`

//Any other value:
//`Unknown department`

//Case is not important.


// Console.Write("Which department are you in ? development, qa, automation, support or sales: ");
// string? department = Console.ReadLine();
//
// switch (department.ToLower())
// {
//     case "development": 
//     case "automation":
//         Console.WriteLine("Technical department");
//         break;
//     case "qa":
//         Console.WriteLine("Quality department");
//         break;
//     case "support":
//         Console.WriteLine("Support department");
//         break;
//     case "sales":
//         Console.WriteLine("Sales department");
//         break;
//     default:
//         Console.WriteLine("Unknown department");
//         break;
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Exercise 7 — Temperature
//Create a variable of type `int` named:
//`temperature`

//Print:
//Less than `0` → `Freezing`
//`0–14` → `Cold`
//`15–24` → `Comfortable`
//`25–34` → `Hot`
//`35` and above → `Very hot`


// int temperature = 30;
//
// switch (temperature)
// {
// 	case >= 0 and < 15:
//         Console.WriteLine("Cold");
// 		break;
// 	case >= 15 and < 25:
//         Console.WriteLine("Comfortable");
// 		break;
// 	case >= 25 and < 35:
//         Console.WriteLine("Hot");
// 		break;
// 	case >= 35: 
// 		Console.WriteLine("Very hot");
// 		break;
// 	default:
//         Console.WriteLine("Freezing");
// 		break;
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// ## Exercise 8 — Product Code
// Create a variable named:
// `productCode`
// Possible values:
// * `phone`
// * `tablet`
// * `laptop`
// * `desktop`
// * `tv`
// Print:
// * `phone` or `tablet` → `Mobile device`
// * `laptop` or `desktop` → `Computer`
// * `tv` → `Television`
// * Any other value → `Unknown product`
// Case is not important.
// # Exercise 9 — Customer Age Group
// Create an `int` variable named:
// `customerAge`
// Print:
// * `0–12` → `Child`
// * `13–17` → `Teenager`
// * `18–29` → `Young adult`
// * `30–49` → `Adult`
// * `50–64` → `Older adult`
// * `65` and above → `Senior`
// Negative number:
// `Invalid age`
// ⚠️ Note: **I didn't give any hint here on how to construct the conditions** — the boundaries are part of the problem you have to solve yourself.
// # Exercise 10 — Support Request
// Create a variable named:
// `requestType`
// Possible values:
// * `password`
// * `login`
// * `technical`
// * `billing`
// * `payment`
// * `other`
// Print:
// * `password` and `login` → `Account support`
// * `technical` → `Technical support`
// * `billing` and `payment` → `Billing support`
// * `other` → `General support`
// Any unrecognized value:
// `Invalid request type`
// The system should work regardless of the case.
// # 🏆 Final Challenge — Employee Classification
// Create an `int` variable named:
// `yearsOfExperience`
// Based on the number of years of experience, print:
// * `0` → `New employee`
// * `1–2` → `Junior employee`
// * `3–5` → `Experienced employee`
// * `6–10` → `Senior employee`
// * `11–20` → `Highly experienced employee`
// * More than `20` → `Veteran employee`
// If the number is negative:
// `Invalid experience`