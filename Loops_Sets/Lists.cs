//HEADER:                                                     string[] firstNames = new string[5];
List<string> firstNames = new List<string>();

firstNames.Add("Tim");
firstNames.Add("Sue");
firstNames.Add("Bob");
firstNames.Add("Jane");

Console.WriteLine(firstNames[firstNames.Count - 1]);

List<int> ages = new List<int>();
ages.Add(1);
ages.Add(2);
ages.Add(3);
ages.Add(4);

//HEADER:                                                                                       List<T> - generic
string data = "Corey, Smith, Jones";







































//HEADER:                                                                          List is like an Array.
//but it got some nice additions/improvements.
//this is the more modern way of storing data, because we can just add to a list without reallocate the entire structure all over again.        
//we aren't declaring the numbers .
//we can just add to it  continuously.
//list are a lot more versatile. 
//a lot easier to work with.
//they adjust to our needs .
//they don't allocate too much space or too little space, they allocate just enough .
//and they can grow over time 
//so if we are going to have a set of date ,and we get a chance or choice, we use a list, a list is an easy way to set things up.    

//HEADER:                                                                                       List<T> - generic
//called a list of T for a generic ,because of the fact that we get to choose, when we create the list ,what that T is going to be ,  we able to choose any type we want ,in this case we will give it a type of string :
//HEADER:                                             List<string> firstNames = new List<string>();
//it can be a list of DateTime
//a list of bool
//a list of string
//a list of int
//a list of double
//a list of char

//HEADER:                                                                          List of last names:
//HEADER:                                                      string data = "Corey, Smith, Jones";
//and we want to split this apart











//                                                              we can do the same thing with other type, int:
//HEADER:                                                          List<int> ages = new List<int>();
//HEADER:                                                                                ages.Add(1);
//HEADER:                                                                                ages.Add(2);
//HEADER:                                                                                ages.Add(3);
//HEADER:                                                                                ages.Add(4);


//this means that the list will contains strings.
//HEADER:                                                                           very similar to :
//HEADER:                                                  string[] firstNames = new string[5]; 

//this list is going to be a set of strings that we are going to call firstNames.
//and we have initialised it, meaning set up that list.  
//HEADER:                                                  List<string> firstNames = new List<string>();

//                                                  This is like a command that says create the list and put it in firstNames :
//HEADER:                                                                      new List<string>();

//                                                             so now when we had this created ,we can say:
//HEADER:                                                                 firstNames.Add("Tim");
//notice that we didn't give it a number, like an array position , it doesn't matter because we called it "Tim".

//                                                                         we have now added 4 elements to this array :
//HEADER:                                                                     firstNames.Add("Tim");
//HEADER:                                                                     firstNames.Add("Sue");
//HEADER:                                                                     firstNames.Add("Bob");
//HEADER:                                                                     firstNames.Add("Jane");

//well it's not an array, it's a list.
//and the difference is ,we didn't have to declare how big this list is.
//unlike we would with an array.
//which means that this is working like an array ,except of the fact that we can add to it as many as we want .


//                                                   and we can still find it by a position, 0 = "Tim" and 3 = "Jane": 
//HEADER:                                                        Console.WriteLine(firstNames[0]);
//HEADER:                                                        Console.WriteLine(firstNames[3]);

//if we want to get the last position inside the array, Count - 1 (because it's still 0 based) instead of Length like when it's an array :
//HEADER:                                   Console.WriteLine(firstNames[firstNames.Count - 1]);

//                                                                            and if we add another one "Frank":
//HEADER:                                                                     firstNames.Add("Tim");
//HEADER:                                                                     firstNames.Add("Sue");
//HEADER:                                                                     firstNames.Add("Bob");
//HEADER:                                                                     firstNames.Add("Jane");
//HEADER:                                                                     firstNames.Add("Frank");

//                                                                                            we will get "Frank": 
//HEADER:                                   Console.WriteLine(firstNames[firstNames.Count - 1]);

