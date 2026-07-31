//Practical Exercise: Working with Int
// Part 1: Declaration & Assignment
//Create an integer variable that will represent the number of customers in the Web system you built.
//Set some initial value (a positive integer) inside this variable.

int totalCustomers = 10000;

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 2: Manipulations and Calculations
//Create a new variable that will calculate and store how many customers there will be in the system if we multiply the current number by 4.

int projectedCustomerCount = totalCustomers * 4;

//Now, take the original variable (from the first section) and update it so that it adds another 250 new customers.

totalCustomers += 250;

//(The existing variable should be updated based on itself, and not just overwritten with a new number).
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 3: Conversion (Types Don't Cross)
//Print the updated number of customers to the Console.

Console.WriteLine(totalCustomers);

//Perform an explicit conversion of the number to a String as we learned, in preparation for integrating this data into the Front End display.

Console.WriteLine(totalCustomers.ToString());
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 4: The Division Trap
//Divide your updated number of customers by 3, and print the result.

totalCustomers /= 3;
Console.WriteLine(totalCustomers);

//Add a comment to your code that briefly explains: Why should you be very careful when dividing Int variables?
//What happens to the result in this case?

//Since int doesn't know how to handle decimal remainders, it simply truncates them, so we need to be very careful when dividing Integers.
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 5: Behind the Scenes (Bits & Signed Int32)
//Add a comment to your code that explains in 2 sentences: Why do we use Int32 (which is Signed) by default in C#?

//Because it can hold about 2 billion in the positive direction and about 2 billion in the negative direction.
//And that's what we need in the vast majority of cases.

//What does the "32" mean in terms of Bits,

//32 bits, that's a huge amount of space to store ints.

//and what does Signed mean?

//The word signed means it has a plus or minus sign.
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 1: Int32 Limits
//1. Create a variable that represents the number of requests to the server (`serverRequests`) and set it to 2,000,000,000 (two billion - very close to the limit we learned about).

UInt32 serverRequests = 2000000000;

//2. A marketing campaign caused the traffic on the site to double.
//Create a new variable that will calculate the double traffic (by multiplying the first variable by 2).

UInt32 trafficMultiple = serverRequests * 2;

//3. In a comment in the poor code: Based on the theory we learned about `Int32` and the size of numbers it can hold, what do you think will happen when we try to put the result of the multiplication into the new variable?

Console.WriteLine(trafficMultiple);
//we get 4000000000

//What type of variable (that was explicitly mentioned in the lesson) should we have used here instead?

//UInt32
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Part 2: The Division Trap in Action
//1. Create a variable called `totalPixels` (representing the width of the screen in the Front End view) and set it to `1000`.

int totalPixels = 1000;

//2. We want to divide the width of the screen into 3 equal columns.
//Create a variable called `pixelsPerColumn` and divide the `totalPixels` by 3.

int pixelPerColumn = totalPixels / 3;
Console.WriteLine(pixelPerColumn);

//3. Now, create a third variable called `restoredTotal`.
//Take `pixelsPerColumn` and multiply it back by 3 (to check if we get back to the original width).

int restoredTotal = pixelPerColumn * 3;

//4. Convert `restoredTotal` to a String for display and print to the console.

Console.WriteLine(restoredTotal.ToString());

//5. In a comment in the poor code: Will the printed value return to exactly 1000?
//Explain precisely why, using the rules we learned about the behavior of Integers.

//No, we get 999 .

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Part 3: Binary Logic (Binary Multiplication)
//It was explained in class that 1 bit holds 2 numbers, 2 bits hold 4 numbers (00, 01, 10, 11), and 3 bits hold 8 numbers (0 to 7).
//1. In a comment in poor code: According to the "Law of Multiplication" that Tim Corey explains in the material (when adding another 0), how many numbers in total can 4 bits hold?

// 16 numbers. 
// Explanation: Every time we add a bit, we double the amount of numbers we can hold. If 3 bits hold 8 numbers, multiplying by 2 means 4 bits can hold 16 numbers.
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~





//Practical Exercise: Advanced Int Manipulations

//Part 1: From String to Int (The API Payload)
// In modern web applications, data often comes from the front-end as a **string**.
// We have a string representing the number of likes on a post:
//
//     ```csharp
//     **string likesFromFrontEnd = "8500";**
//
//     ```
//
// 1. **Parse this string** into a new **int** variable called 'parsedLikes'.
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//     Part 2: The Modulo Operator (%) - Handling Remainder
//     You saw that dividing **Int** truncates the decimal point.
//
//     But what if we need to know what is left over?
//
//     We have 100 background tasks and 3 servers to process them.
//
//     ```csharp
//     **int totalTasks = 100;
//
// int serverCount = 3;**
//     ```
//
// 2. Use the modulo operator (%) to calculate how many tasks are left after dividing them equally among the 3 servers.
//     Store the result in a variable called 'leftoverTasks' and print it.
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//     Part 3: Muscle Memory - Promotion and Decrement
// In 2026, we don't write
//
//     ```csharp
//     **variable = variable + 1
// or even for simple counting
// variable += 1
// int activeConnections = 50;**
//
//     ```
//
// 3. A new user just connected.
//
//     Increment 'activeConnections' by exactly 1 using the shortest and most professional syntax possible.
//
// 4. A user suddenly disconnected.
//
//     Decrement the variable by exactly 1 using the shortest syntax possible.
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//     Part 4: Casting - Forced Conversions
//     The AI ​​model analyzed our system and returned a confidence score as a 'double' .
//
//     ```csharp
//     **double aiConfidenceScore = 98.9;**
//     ```
//
// 5. We need to store this in our DB as a simple Int.
//     Do an Explicit Cast to force this 'double' into a new 'int' variable called 'finalScore'.
//
// 6. Add an explanatory note: What happens to the .9?
//
//     Does the Cast round the number up to 99, or truncate it to 98?



