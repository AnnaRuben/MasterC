//1
//Setting up the base data:
//Create three integer variables (`int`) that represent server response times in milliseconds (ms).
//Give them the values: `43`, `21`, and `62`.

int serverResponseTimesInMillisecondsOne = 43;

int serverResponseTimesInMillisecondsTwo = 21;

int serverResponseTimesInMillisecondsThree = 62;

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//2
//Calculating the exact average:
//Create a variable named `averageResponseTime` of type `double`.
//Calculate the average of the three `int` variables you created in step 1, and place the result inside `averageResponseTime`.
//Required: You must make sure that the result of the calculation includes the decimal point and that no "integer division" is performed that will lose us data.
//Apply the trick we learned in the code you pasted to signal to the compiler that you want a decimal result.

//Hard coded:
//double averageResponseTime = (43.0 + 21 + 62) / 3;

double averageResponseTime = (serverResponseTimesInMillisecondsOne + serverResponseTimesInMillisecondsTwo + serverResponseTimesInMillisecondsThree) / 3.0;

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//3
//Printing:
//Print the average you calculated to the console.

Console.WriteLine(averageResponseTime);

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//4
//Implicit Conversion:
//Prove that an integer can be inserted into a `double` variable without any problem (because we are going from a less specific type to a more specific one).
//Create an `int` variable named `basePing` with the value `100`.
//Immediately after wards, create a `double` variable named `exactBasePing` and place the `basePing` variable directly into it.

int basePing = 100;

double exactBasePing = basePing;
    
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//5
//Using the Math library:
//Use the .NET `Math` library to perform a mathematical operation on the `averageResponseTime` (for example, take its square root using `Math.Sqrt` or round it).
//Prove that this library works natively with `double` types.

double sqrAverage = Math.Sqrt(averageResponseTime);

Console.WriteLine(sqrAverage);

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//6
//Comprehension question (write the answer as a `//` comment in your code):
//Suppose your system now needs to calculate the financial cost of maintaining these servers.
//Would you use the `double` type to store the amounts of money? Briefly explain why or why not.

//I will not use the double variable type, I will use decimal because in everything related to money, you need to be ultra precise, and the most suitable for this level of precision and dealing with money is decimal.

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 1: The Average Trap
//You have three ages of users in the system.
//The ages are integers: 43, 21, and 62.

int ageOne = 43;

int ageTwo = 21;

int ageThree = 62;

//1. Write code that calculates the average of these three ages.

double averageOfThreeAges = (ageOne + ageTwo + ageThree) / 3.0;

//2. Store the result in a `double` variable.
//3. Important note:You must make sure that the final result includes the exact decimal point (so that we don't lose information due to calculating Integers, just like we learned).
//4. Print the result to the console.

Console.WriteLine(averageOfThreeAges);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 2: Conversion Directions
//Here we practice understanding the transition from a less specific type to a more specific one.
//1. Create a variable of type `int` and give it a value of an integer (e.g. 100).

int basePingTwo = 100;

//2. Create a variable of type `double` and call it a logical name.
//3. Write a line of code that inserts the value of the `int` directly into the `double`.

double newBasePingTwo = basePingTwo;

//4. In a comment in the code (`//`), write a short sentence that explains why this conversion works smoothly, and why the system does not agree with us doing the opposite operation (inserting `double` into `int`) naturally.

//The reason it goes smoothly is that you can go from less precise to more precise, but you can't go the other way around because the system doesn't agree to lose data.

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//Exercise 3: Math Gym
//The `double` type is the king of math in .NET.
//1. Create a `double` variable with the value `64.0`.

double averageResponseTimeTwo = 64.0;

//2. Use the `.Math` library to perform one mathematical operation of your choice (such as square root or any other operation that pops up for you in the autocomplete).

double newMath = Math.Sqrt(averageResponseTimeTwo);

//3. Print the final result.

Console.WriteLine(newMath);