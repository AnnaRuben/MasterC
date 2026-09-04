// for (int i = 0; i < 10; i ++)
// {
//     Console.WriteLine($"The value of i is {i} ");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// string data = "Tim, Sue, Bob, Jane, Frank" ;
// List<string> firstNames = data.Split(',').ToList();
//
// for (int i = 0; i < firstNames.Count; i ++)
// {
//     Console.WriteLine($"{firstNames[i]} is in attendance");
// }
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// List<decimal> charges = new();
//
// charges.Add(23.78M);
// charges.Add(15.89M);
// charges.Add(125M);
//
// decimal total = 0;
//
// for (int i = 0; i < charges.Count; i++)
// {
//     total += charges[i];
// }
//
// Console.WriteLine($"Our Total charges: {total}");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//there is a  snippet ,we tap for f-o-r and hit TAB twice, and this creates a structure for us.
//for loop ,special type of loop, designed to loop throw a set number of times.
//we have 3 different sections inside the ()
//purple                                                                                             1 section:
// we set up variable for counting, that is the initialization that we are going to start our counter :
//~ int i = 0;

//purple                    remember that they use a 0 based counting, they start at position 0 and count up:
//~                                                                                                          Arrays
//~                                                                                                   Dictionaries
//~                                                                                                             Lists

//purple                                                                                             2 section:
//~ i < length;

//this is the evaluation portion, for example 10, this code will run as long as i will be less than 10:
//~                                          for (int i = 0; i < 10; i ++)
//~                                         {
     
//~                                          }

//purple                                                                                           3 section:
//means :
//add 1 to i
//~  i ++

//after the first loop , i becomes 1 instead of 0 .
//~                                          for (int i = 0; i < 10; i ++)
//~                                         {
     
//~                                          }

//is 1 < 10 ?
//yes, therefor run this code.
//back up i ++, check i < 10; ,run it... and so on. 

//basic rule, name variables with descriptive names.
//here there is an exception rule:
//~  i
//i - is a standard for a for loop.

//purple                                                                                         lets run this :
//~                                                                                         for (int i = 0; i < 10; i ++)
//~                                                                                        {
//~                                                                                                Console.WriteLine($"The value of i is {i} ");
//~                                                                                        }

//purple                                                           and this is what we get from the compiler:
// The value of i is 0 
// The value of i is 1 
// The value of i is 2 
// The value of i is 3 
// The value of i is 4 
// The value of i is 5 
// The value of i is 6 
// The value of i is 7 
// The value of i is 8 
// The value of i is 9

//once we hit 10 ,it says 10 is not < 10, therefor exit out of the loop !

//purple                                                                 print string array of first names :
//~                                                                   string data = "Tim, Sue, Bob, Jane, Frank";
//~                                                                  List<string> firstNames = data.Split(',').ToList();

//~                                                                       for (int i = 0; i < firstNames.Count; i ++)
//~                                                                      {
//~                                                                            Console.WriteLine(firstNames[i]);
//~                                                                       }

//because remember < means it's never going equal the count, always be one less than. 
//~                                                                            Console.WriteLine(firstNames[i]);
//purple                                                                                             means :
//we have 5 first names , so it will print the names at the positions 0, 1, 2, 3, 4 and stop.
//and it will adjust based up on a size of our list. 
// Tim
// Sue
// Bob
// Jane
// Frank

//purple                                                                                             if we say :
//~                                                                Console.WriteLine($"{firstNames[i]} is in attendance");

//purple                                                                                        we will get :
// Tim is in attendance
// Sue is in attendance
// Bob is in attendance
// Jane is in attendance
// Frank is in attendance

//purple                                                                    a shortcut for new list of decimal :
//~                                                                                   List<decimal> charges = new();

//~                                                                                          charges.Add(23.78M);
//~                                                                                          charges.Add(15.89M);
//~                                                                                          charges.Add(125M);

//~                                                                                             decimal total = 0;

//~                                                                               for (int i = 0; i < charges.Count; i++)
//~                                                                               {
//~                                                                                      total += charges[i];
//~                                                                               }

//~                                                                              Console.WriteLine($"Our Total charges: {total}");

//purple                                                                                        we will get :
//Our Total charges: 164.67
     