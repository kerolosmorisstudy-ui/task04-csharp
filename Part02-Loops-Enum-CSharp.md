# Loops in C#

Loops are an important part of programming. They help us repeat a block of code many times without writing it again and again.

In C#, there are several types of loops that we use a lot:

- for loop:  
Use this when you know exactly how many times you want to repeat something. For example, repeating an action 10 times.

- foreach loop:  
This loop is useful for going through all items in a collection, like an array or a list. It is simple and safe because it doesn't need to manage indexes.

- while loop:  
It repeats the code as long as a condition is true. This is good when you don’t know how many times the loop will run.

- do-while loop:  
This is like the while loop, but it runs the code at least once before checking the condition.

Choosing the right loop makes the code cleaner and easier to read. It also helps the program run better.

In short, knowing how to use loops well is an important skill for any programmer.
using System;


                                                program
enum DayOfWeek
{
    Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
}

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1-7) to get the day of the week: ");
        string input = Console.ReadLine();

        try
        {
            int dayNumber = int.Parse(input);
            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayNumber.ToString());
            Console.WriteLine($"Day is: {day}");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid number. Please enter a number between 1 and 7.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Input is not a valid number.");
        }
    }
}
