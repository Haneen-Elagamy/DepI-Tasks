using System;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace TaskAnswer2
{
    public class Point
    {
        public int X { get; set; }
    }
    internal class Program
    {
        static void Main()
        {
            #region problem_1 
            /*Problem: Add both single-line and multi-line comments in the following code segment
                explaining its purpose:
               */
            //single line comments are used for brief explanations and are placed on the same line as the code.
            // Declaring an integer variable 'x' and initializing it with a value of 10
            //int x = 10;

            // Declaring an integer variable 'y' and initializing it with a value of 20
            //int y = 20;

            // Declaring a variable 'sum' that will store the result of adding 'x' and 'y'
            //int sum = x + y;

            // Output the value of 'sum' to the console, which should be 30 (10 + 20)
            /* Console.WriteLine(sum);*/  // This will display '30' 
            /*multi line comments f you wanted to explain multiple 
             lines of code or provide a detailed explanation*/
            #endregion

            #region problem_2 
            //Problem: Identify and fix the errors in this code snippet:
            //int x = "10"; 10 must be converted to intger or remove "" 
            //console.WriteLine(x + y); Console should be capitalized && y must be declared
            //The correct version
            //int x = 10;
            //int y = 20;
            //Console.WriteLine(x+y);
            ////or
            //int x = int.Parse("10");
            //int y = 20;
            //Console.WriteLine(x + y);  
            #endregion

            #region problem_3  
            //Problem: Declare variables using proper naming conventions to store:
            // Your full name.
            // Your age.
            // Your monthly salary.
            // Whether you are a student.
            //string FullName = "Haneen Ali Elagamy";
            //int Age = 20;
            //decimal MonthlySalary = 15000.55m;
            //bool IsStudent = true;  
            #endregion

            #region problem_4  
            //Problem: Write a program to demonstrate that changing the value of a reference type affects all
            //references pointing to that object.

            //Point P1 = new Point();
            //Point P2 = new Point();
            //P2 = P1;
            //Console.WriteLine(P1.X);//0
            //P1.X = 15;
            //Console.WriteLine(P1.X); //15
            //Console.WriteLine(P2.X); //15  
            #endregion

            #region problem_5 
            //Console.WriteLine("Enter Two numbers: ");
            //int x = 15;
            //int y = 4;
            //Console.WriteLine("Sum= {0}", x + y);
            //Console.WriteLine("Difference= {0}", x - y);
            //Console.WriteLine("Product= {0}", x * y);
            //Console.WriteLine("Division Result= {0}", x / y);
            //Console.WriteLine("Remainder= {0}", x % y); 
            #endregion

            #region problem_6 
            //int Num = 11;
            //Console.WriteLine(Num > 10 && Num%2 == 0); 
            #endregion

            #region problem_7  
            //// Problem: Implement a program that takes a double input from the user and casts it to an int.
            ////Use both implicit and explicit casting, then print the results.
            //Console.WriteLine("Enter a decimal number (double): ");

            //double UserInput=Convert.ToDouble(Console.ReadLine());
            ////implicit casting
            ////int result1 = UserInput; //error not valid
            ////Explicit casting
            //int result2;
            //checked
            //{
            //    result2= (int)UserInput;
            //}
            //Console.WriteLine(result2);

            #endregion

            #region problem_8  
            ////Problem: Write a program that: (G01 Bonus, G02 mandatory)
            ////o Prompts the user for their age as a string.
            ////o Converts the string to an integer using Parse
            ////o Checks if the age is valid(e.g., greater than 0).
            //Console.WriteLine("Please Enter Your Age! ");
            //String InputAge =Console.ReadLine();

            //try
            //{
            //    int Age = int.Parse(InputAge);

            //    if (Age > 0)
            //    {
            //        Console.WriteLine("Your Age is Valid: " + Age);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Age must be greater than 0");
            //    }

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input");
            //}




            #endregion

            #region problem_9  
            ////Problem: Write a program that demonstrates the difference between prefix and postfix
            ////increment operators using a variable x.
            //int x = 5;
            //Console.WriteLine(x++);//5
            //Console.WriteLine(++x);//7 
            #endregion

            //int x = 5;
            //int y = ++x + x++;
            //Console.WriteLine(y);
            //Console.WriteLine(x);


        }
    }
}
