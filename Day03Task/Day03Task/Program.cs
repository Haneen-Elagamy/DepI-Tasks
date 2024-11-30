using System;
using System.ComponentModel;
using System.Text;

namespace Day03Task
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            #region problem_1  
            //Problem: Write a program to:
            //o Accept a string input from the user.
            //o Convert it to an integer using both int.Parse and Convert.ToInt32.
            //o Handle potential exceptions using a try-catch block.

            //Console.WriteLine("Enter a Number : ");
            //string UserInput = Console.ReadLine();


            //try
            //{
            //    int Input = int.Parse(UserInput);
            //    Console.WriteLine(Input);

            //    int Input1 = Convert.ToInt32(UserInput);
            //    Console.WriteLine(Input1);


            //}
            ////FormatException: Thrown for invalid formats (e.g., "abc").
            //catch (FormatException)
            //{
            //    Console.WriteLine("Error: Input is not in a valid numeric format.");
            //}
            ////OverflowException: Thrown if the number is too large or small for int.
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Error: The input number is too large or too small for an integer.");
            //}

            #endregion

            #region Problem_2  
            //Problem: Write a program that:
            //o Prompts the user to input a number.
            //o Uses int.TryParse to check if the input is a valid integer.
            //o If valid, print the number; otherwise, print an error message.

            //Console.WriteLine("Enter a number,please! ");
            //String Input=Console.ReadLine();

            //if (int.TryParse(Input, out int ParsedValue))
            //{
            //    Console.WriteLine($"You entered :{ParsedValue}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Input!");
            //} 
            #endregion

            #region Problem_3  

            //Problem: Implement a program to:
            //  o Declare an object variable.
            //  o Assign it different data types(e.g., int, string, double).
            //  o Print the GetHashCode() of each assignment.

            //object Var;
            //Var = 10; //int
            //Console.WriteLine(Var.GetHashCode());//10
            //Var = "Haneen"; //String
            //Console.WriteLine(Var.GetHashCode());//318053426
            //Var = 1254.251; //double
            //Console.WriteLine(Var.GetHashCode());//1186415662

            #endregion

            #region problem_4 
            //  Problem: Demonstrate how changing one reference affects another when both point to
            //the same object. Use the following steps:
            //o Create an object and assign it a value.
            //o Create a second reference to the same object.
            //o Modify the value of the object using one reference and print the value using the
            //other.

            //MyObject obj1 = new MyObject { Value = 5 };

            //MyObject obj2 = obj1;
            //obj2.Value = 10;

            //Console.WriteLine(obj1.Value); //10
            //Console.WriteLine(obj2.Value); //10 
            #endregion

            #region problem_5 
            // Problem: Write a program to:
            //o Declare a string and modify it by concatenating additional text “Hi Willy”.
            //o Print the GetHashCode() before and after modification.
            //String text = "Hi";
            //Console.WriteLine(text.GetHashCode()); //1752410405
            //text += " Willy";
            //Console.WriteLine(text.GetHashCode()); //1568405469 
            #endregion

            #region problem_6  
            //Problem: Create a program to:
            // o Use StringBuilder to append text to a string “Hi Willy”.
            // o Print the GetHashCode() of the StringBuilder instance before and after the
            //  modification.
            //StringBuilder SB;
            //SB = new StringBuilder("Hi");
            //Console.WriteLine(SB.GetHashCode());//58225482
            //SB.Append(" Willy");
            //Console.WriteLine(SB.GetHashCode());//58225482 
            #endregion

            #region Problem_7 
            //Problem: Create a program to:
            //  o Accept two integer inputs from the user.
            //  o Display the sum using all three methods “Sum is input1 + input2”:
            //   Concatenation(+ operator)
            //   Composite formatting(string.Format)
            //   String interpolation($)

            //Console.WriteLine("Enter Two intger numbers ,Please!");
            //String Input1 = Console.ReadLine();
            //String Input2 = Console.ReadLine(); 
            //bool Flag1 =int.TryParse(Input1, out int ParsedInput1);
            //bool Flag2 =int.TryParse(Input2, out int ParsedInput2);
            //if (Flag1 && Flag2)
            //{
            //    // Concatenation(+ operator)
            //    Console.WriteLine("Sum is " + ParsedInput1 + " + " + ParsedInput2 + " = " + (ParsedInput1 + ParsedInput2));
            //    // Composite formatting(string.Format)
            //    Console.WriteLine("Sum is {0} + {1} = {2}", ParsedInput1, ParsedInput2, (ParsedInput1 + ParsedInput2));
            //    // String interpolation($)
            //    Console.WriteLine($"Sum is {ParsedInput1} + {ParsedInput2} = {(ParsedInput1 + ParsedInput2)}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Please enter valid integer numbers.");
            //} 
            #endregion

            #region Problem_8 
            //Problem: Create a program using StringBuilder to:
            //  o Append text.
            //  o Replace a substring.
            //  o Insert a string at a specific position.
            //  o Remove a portion of text.

            //StringBuilder SB;
            //SB = new StringBuilder();
            //SB.Append("My name is Haneen");
            //Console.WriteLine(SB.ToString());
            //SB.Replace("Haneen", "Hanoona");
            //Console.WriteLine(SB.ToString());
            //SB.Insert(18, " Elagamy");
            //Console.WriteLine(SB.ToString());
            //SB.Remove(0, 11);
            //Console.WriteLine(SB.ToString()); 
            #endregion

            #region Self  
            // Self : SB built_in functions

            //StringBuilder sb = new StringBuilder("Hello, StringBuilder!");

            //// 1. Append
            //sb.Append(" It's powerful.");
            //Console.WriteLine(sb); // Output: Hello, StringBuilder! It's powerful.

            //// 2. Insert
            //sb.Insert(7, "amazing ");
            //Console.WriteLine(sb); // Output: Hello, amazing StringBuilder! It's powerful.

            //// 3. Replace
            //sb.Replace("powerful", "efficient");
            //Console.WriteLine(sb); // Output: Hello, amazing StringBuilder! It's efficient.

            //// 4. Remove
            //sb.Remove(7, 8); // Removes "amazing "
            //Console.WriteLine(sb); // Output: Hello, StringBuilder! It's efficient.

            //// 5. Clear
            //sb.Clear();
            //Console.WriteLine($"Cleared: {sb}"); // Output: Cleared: 
            #endregion







        }
    }
}
