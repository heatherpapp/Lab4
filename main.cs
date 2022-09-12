using System;
/*
Class: CSE 1321L
Section: W1 C#
Term: Fall 2022	
Instructor: Jaskirat Singh Sohal
Name: Heather Papp
Lab#: Lab4B 
*/
class Program {
  public static void Main (string[] args) {

    Console.Write("Enter the day: ");
    string day = Console.ReadLine();
    
    if (day == "Monday" | day == "monday" | day == "Wednesday" | day == "wednesday") 
    {
    Console.WriteLine("I have class today!");
    }

    else if (day == "Friday" | day == "friday") 
    {
    Console.WriteLine("It's Friday! Friday! Gotta get down on Friday!");
    }
    else
    Console.WriteLine("I should use this time to do my homework.");
    return;
  }
}