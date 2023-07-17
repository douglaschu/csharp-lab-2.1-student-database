



using System;

string[] names = { "Justin Jones", "Zach Buth", "Omar Abdulla", "Ethan Thomas", "Joe Heath", "Forrest Verellen", "Doug Chu", "Maya Araquil", "Shane Chastain", "Timothy Montague", "Maria Ragone" };
string[] towns = { "Columbus", "Grand Rapids", "Dearborn", "Rolla", "Howell", "Traverse City, MI", "Poughkeepsie", "West bloomfield", "Rochester Hills", "Clio", "Farmington Hills" };
string[] foods = { "Baja Blast", "Pizza", "Cheese Pizza", "Hot Wings", "Tacos", "Spaghetti", "Sushi", "Sinigang", "Pizza", "Mole", "Lasagna" };

bool runProgram = true;
while (runProgram)
{



    while (true) {
        Console.WriteLine("Please select option 1 or 2 from our menu items.\n" +
            "1. Learn about a student\n" +
            "2. View list of all students"
            );
        int menuSelect = Convert.ToInt32(Console.ReadLine());

        if (menuSelect == 1 || menuSelect == 2 )
        {
            switch (menuSelect)
            {
                case 1:
                    {
                        while (true)
                        {
                            Console.WriteLine("Please enter a number to learn about a student.");
                            int num = 0;
                            while (true)
                            {
                                num = Convert.ToInt32(Console.ReadLine());
                                //Validate user number entry
                                //Use if conditional to check if num > array.Length()

                                //if valid entry, print student name and CONTINUE to next part.
                                if (num <= names.Length && num > 0)
                                {
                                    Console.WriteLine(names[num - 1]);
                                    break;

                                }
                                else
                                {
                                    Console.WriteLine($"Please enter a number that is between 0 and {names.Length}.");
                                }
                            }

                            //get user input and run method to return student facts
                            Console.WriteLine("Please enter a category to display: Hometown or Favorite Food (h/f)");
                            string category = Console.ReadLine().ToLower().Trim();
                            Console.WriteLine(GetStudentInfo(num, category, towns, foods));
                            break;
                        }
                    }
                    break;


                //print list of students
                case 2:
                    for (int i = 0; i < names.Length; i++)
                    {
                        Console.WriteLine($"\n{i + 1}. {names[i]}");
                    }
                    break;
            } break;

        } else
        {
            Console.WriteLine("Please enter either 1 or 2 to select a menu option.\n");
        }
    } 

    //ask if user wants to choose from menu again
    while (true)
    {
        Console.WriteLine("Would you like to return to the main menu? (y/n)");
        string choice = Console.ReadLine().ToLower().Trim();
        if (choice == "n")
        {
            Console.WriteLine("See ya!");
            runProgram = false;
            break;
        }
        else if (choice == "y")
        {

            runProgram = true;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }

}


static string GetStudentInfo(int num, string category, string[] towns, string[] foods)
{

    if (category == "h" || category == "hometown")
    {
        return towns[num - 1];
        //Console.WriteLine(towns[num - 1]);
    }
    else if (category == "f" || category == "favorite food" || category == "food")
    {
        return foods[num - 1];
        //Console.WriteLine(foods[num - 1]);
    }
    else
    {
        return "Invalid input";
    }
}

//ask if user wants to look up another student
//bool lookup = true;
//while (lookup)
//while (true)
//{
//    Console.WriteLine("Would you like to learn about another student? (y/n)");
//    string choice = Console.ReadLine().ToLower().Trim();
//    if (choice == "n")
//    {
//        //lookup = false;
//        return;
//    }
//    else if (choice == "y")
//    {
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Invalid input.");
//    }
//    break;
//} 

//print list of students
//foreach (string student in names)
//{
//    Console.WriteLine(student);
//}





//More complex validation to throw error message if letters/punctuation entered.
//Use try... catch to do so
//else if (num > names.Length || num < 0)
//{
//    Console.WriteLine($"Please enter a number that is between 0 and {names.Length}.");

//}
//else {
//{

//    Console.WriteLine("Invalid input.");

//}
//    }
//}


//Console.WriteLine("Please enter a category to display: Hometown or Favorite Food (h/f)");
//string category = Console.ReadLine().ToLower().Trim();

//Console.WriteLine(GetStudentInfo(num, category, towns, foods));
//Console.WriteLine("Please enter a category to display: Hometown or Favorite Food (h/f)");
//string category = Console.ReadLine().ToLower().Trim();
//if (category == "h" || category == "hometown")
//{
//    Console.WriteLine(towns[num - 1]);
//}
//else if (category == "f" || category == "favorite food" || category == "food")
//{
//    Console.WriteLine(foods[num - 1]);
//}
//else
//{
//    Console.WriteLine("Invalid input");
//}




//static string GetStudentName(int num, string[] names) {}


//for keeping terminal window up while testing on Visual Studio Mac
Console.ReadLine();
