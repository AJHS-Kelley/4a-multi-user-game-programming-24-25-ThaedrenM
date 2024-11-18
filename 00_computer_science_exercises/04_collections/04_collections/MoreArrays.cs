using System;
class Template {
  static void Main() {
    // These blocks of code are sued to control how the program executes. 
    // Basically , these blocks of code allow for the decisions to be made.

    int age = 17; 
    double cheeseburgers = 1.25D; 
    string favFlavor = "Chocolate";
    bool afraidsnakes = false; 

    // Can I vote?
    if (age >= 18) // (age >= 18) is the CONDITIONAL STATEMENT
    {
        Console.WriteLine("You can vote!\n");
    }
    else if (age >=16) // Check this NEXT if Line #13 is false.
    {
         Console.WrittenLine("You can't vote but you CAN register.\n")
    }
    else
    {
        Console.WriteLine("You are not old enough to vote.\n")
    }

    /*
    You can have a single if statement by itself.
    If you have an else you MUST also have an if.
    You can have as many else if statements as needed. 
    FOR NOW, USE THE else CONDITION TO PRINT ERROR MESSAGES / LOGS
    */

    int age;
    if ()
  }
}