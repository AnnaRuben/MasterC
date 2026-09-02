//HEADER:                                                                                 string, string:  
// Dictionary<string, string> lookup = new Dictionary<string, string>();
//
// lookup["animal"] = "Not a human";
// lookup["fish"] = "Not a human that swims";
// lookup["human"] = "Us";
//
// Console.WriteLine($"The definition of fish is {lookup["fish"]}");
//
//
//HEADER:                                                                                 int, string: 
// Dictionary<int, string> employee = new Dictionary<int, string>();
//
// employee[95] = "Tim Corey";
// employee[28] = "Sue Storm";
//
// Console.WriteLine($"The employee with ID number 28 is {employee[28]}");


//HEADER:                                                                                 string, int : 
// Dictionary<string, int> dayOfWeek = new Dictionary<string, int>();
//
// dayOfWeek["Wednesday"] = 4;
// dayOfWeek["Thursday"] = 5;
// dayOfWeek["Friday"] = 6;
//
// Console.WriteLine($"Wednesday is day number  {dayOfWeek["Wednesday"]}");



//                                                                                                 we say ,create:
//HEADER:                                                                new Dictionary<int, string>();
//                                                                                         and put it in to this value:
//HEADER:                                                                                       lookup
//HEADER:                            Dictionary<int, string> lookup = new Dictionary<int, string>();
//in this Dictionary we have 2 types, key type (int) and value type (string)

//a Dictionary is like a real paper dictionary
//we look up a word and get information about that word

//HEADER:                      Dictionary<string, string> lookup = new Dictionary<string, string>();

//HEADER:                                                                          create a dictionary:

//HEADER:                                                        lookup["animal"] = "Not a human";
//HEADER:                                                              lookup["fish"] = "Not a human that swims";
//HEADER:                                                       lookup["human"] = "Us";

//now we can look up an animal and get this definition : "Not a human"
//or
//look up fish and get this definition : "Not a human that swims" 

//now if we run this ,we will get :
//HEADER:                                 Console.WriteLine($"The definition of fish is {lookup["fish"]}"); 
//"The definition of fish is Not a human that swims" 


//HEADER:                                                                                   important: 
//important thing to remember when it comes to keys is that we can only have 1 ,they must be unique.
//we can't have 2 different values like this :
//HEADER:                                                        dayOfWeek["Wednesday"] = 4;
//HEADER:                                                       dayOfWeek["Thursday"] = 5;
//HEADER:                                                       dayOfWeek["Friday"] = 6;  
//HEADER:                                                       dayOfWeek["Friday"] = 7;

//and if we will run this and say:
//HEADER:                     Console.WriteLine($"Wednesday is day number  {dayOfWeek["Friday"]}"); 
//we will see that we have over written it ,and haven created a new one, because we will get 7.

//dictionary is very useful for storing a set of data that we need to convert overall.   