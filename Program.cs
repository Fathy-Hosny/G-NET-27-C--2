namespace Assignmen_C__01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1: Regions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 2: REGIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the purpose of #region and #endregion directives in C#? 
            //    How do they help in code organization?
            //
            // ══════════════════════════════════════════════════════════════════════
            //
            //Nested Region Example:

            /*#region Question 1: Nested Region Example

            //#region is used to organize code 

            //int x = 5;
                    
                  
            //        var y = 10;
            #endregion
            */




            #endregion


            #region Question 2: Variable Declaration - Explicit vs Implicit
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 3: VARIABLE DECLARATION - EXPLICIT VS IMPLICIT
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between explicit and implicit variable 
            //    declaration in C#? Provide examples of both.
            //
            // ══════════════════════════════════════════════════════════════════════

            /*
            // EXPLICIT DECLARATION 
            int number = 10;
            string name = "Fathy";

            // IMPLICIT DECLARATION 
            var age = 24;        // int
            var city = "Giza";    // string
            */
            #endregion
            #region Question 3: Constants
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CONSTANTS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write the syntax for declaring a constant in C#. Why would you use 
            //    a constant instead of a regular variable?
            //
            // ══════════════════════════════════════════════════════════════════════



            // Constant examples

            // Syntax: const dataType name = value;
            const double PI = 3.14159;
            const int MaxUsers = 100;
            //because anyone cant change const  value 

            #endregion

            #region Question 4: Class-level vs Method-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 4: CLASS-LEVEL VS METHOD-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the difference between class-level scope and method-level 
            //    scope with examples.
            //
            // ══════════════════════════════════════════════════════════════════════

            /* class-level
                  class Program
             {
                 static int classNumber = 50;

                 method-level
                 static void ExampleMethod()
                 {
                     int methodNumber = 20;
                     Console.WriteLine(classNumber);
                     Console.WriteLine(methodNumber);
                 }

                  i can get classNumber anywhere in the class but
                 i cant get methodNumber in the class i cant get it in method only
                 
        }
             */

            #endregion

            #region Question 5: Block-level Scope
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 5: BLOCK-LEVEL SCOPE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is block-level scope? Give an example showing a variable that 
            //    is only accessible within a specific block.
            //
            // ══════════════════════════════════════════════════════════════════════

            //if (true)
            //{
            //    int blockVar = 10;
            //    Console.WriteLine(blockVar);
            //}
            // Console.WriteLine(blockVar); // ERROR


            #endregion

            #region Question 6: Variable Lifetime - Local vs Static
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 6: VARIABLE LIFETIME - LOCAL VS STATIC
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable lifetime? Explain the lifetime of local variables 
            //    vs static variables.
            //
            // ══════════════════════════════════════════════════════════════════════
            /*
             Class lifetime{

            Static lives for entire app life
            Static int number=10;

            instance as long as objet exists
            Privat stringe name= "fathy";


            public void method{
            local live untel method end
            int temp=30;


            for(int i=0; i<5; i++){
            block live untel block ends
            int x=40;
            
            }

            }


            }



             */


            #endregion

            #region Question 7: Garbage Collector
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 7: GARBAGE COLLECTOR
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the Garbage Collector in C#? How does it affect the 
            //    lifetime of objects?
            //
            // ══════════════════════════════════════════════════════════════════════


            // Garbage Collector automatically frees memory for unused objects
            // It manages object lifetime in Heap memory


            #endregion

            #region Question 8: Variable Shadowing
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 8: VARIABLE SHADOWING
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is variable shadowing in C#? Does C# allow shadowing in 
            //    nested blocks within the same method?
            //
            // ══════════════════════════════════════════════════════════════════════


            /* int x = 5;
             if (true)
             {
                 int x = 10; // Shadowing not allowed  in same scope you will get error just in block
             }
            */
            #endregion

            #region Question 9: C# Naming Rules
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 9: C# NAMING RULES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List five rules that must be followed when naming variables in C#.
            //
            // ══════════════════════════════════════════════════════════════════════


            /*
             
            1) Names must start with letter or _ underscor
            2)can contain letters,  digits and underscor no spaces
            3)C# is case-sensitive(name!=Name)
            4)Avoid KeyWords or use @ before when it nacessry
            5)The names should have meaning
             
             */
            #endregion

            #region Question 10: Naming Conventions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 10: NAMING CONVENTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What naming conventions are recommended for: (a) local variables, 
            //    (b) class names, (c) constants?
            //
            // ══════════════════════════════════════════════════════════════════════

            /*
            // Local variable
                 int studentCount;

            // Class name
                class StudentInfo { }

        // Constant
                 const int MAX_USERS = 100;
            */
            #endregion

            #region Question 11: Error Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 11: ERROR TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Compare and contrast syntax errors, runtime errors, and logical 
            //    errors. Provide an example of each.
            //
            // ══════════════════════════════════════════════════════════════════════
            /*
            syntax errors 
             int x = "fathy"; 

            // Runtime Error
            int a = 10;
            int b = 0;
            // Console.WriteLine(a / b); // DivideByZeroException

            // Logical Error
            int sum = 10 + 20 + 30; 
            int avg =sum / 2; //should be /3
            */
            #endregion

            #region Question 12: Exception Handling Importance
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 12: EXCEPTION HANDLING IMPORTANCE
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is exception handling important in C#? What would happen if 
            //    you don't handle exceptions?
            //
            // ══════════════════════════════════════════════════════════════════════
            // Without exception handling, the program crashes on errors



            #endregion

            #region Question 13: try-catch-finally
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 13: TRY-CATCH-FINALLY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example demonstrating try-catch-finally. Explain when 
            //    the finally block executes.
            //
            // ══════════════════════════════════════════════════════════════════════
            /*
            try
            {
                int x = 10;
                int y = 0;
                Console.WriteLine(x / y);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("This will always execute");
            }
            */
            #endregion

            #region Question 14: Common Built-in Exceptions
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 14: COMMON BUILT-IN EXCEPTIONS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: List and explain five common built-in exceptions in C# with 
            //    scenarios when each would occur.
            //
            // ══════════════════════════════════════════════════════════════════════
            /*
             1)DivideByZeroException
            
                        int a = 10, b = 0;
            int sum = a / b; // Throws DivideByZeroException
             ===============================================
             2) NullReferenceException
                
                            string str = null;
                int len = str.Length; // Throws NullReferenceException
              === ======================================      
            
              3)IndexOutOfRangeException
                        int[] arr = { 1, 2, 3 };
            int x = arr[5]; // Throws IndexOutOfRangeException
            =================================
            4)ArgumentException
            File.Open("", ...); 
            =====================================
            5) FileNotFoundException
            File.ReadAllText("x.txt"); 

             */

            #endregion

            #region Question 15: Multiple catch Blocks
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 15: MULTIPLE CATCH BLOCKS
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is the order of catch blocks important when handling multiple 
            //    exceptions? Write code showing correct ordering.
            //
            // ══════════════════════════════════════════════════════════════════════
            /* try
             {
                 int x = 10;
                 int y = 0;
                 Console.WriteLine(x / y);
             }
             catch (DivideByZeroException)
             {
                 Console.WriteLine("Cannot divide by zero");
             }


             catch (Exception)
             {
                 Console.WriteLine("General error");
             }
            */


            #endregion

            #region Question 16: throw Keyword
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 16: THROW KEYWORD
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: What is the difference between 'throw' and 'throw ex' when 
            //    re-throwing an exception? Which one preserves the stack trace?
            //
            // ══════════════════════════════════════════════════════════════════════
            #endregion

            #region Question 17: Stack and Heap Memory
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 17: STACK AND HEAP MEMORY
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Explain the differences between Stack and Heap memory in C#. 
            //    What types of data are stored in each?
            //
            // ══════════════════════════════════════════════════════════════════════
            /* int x = 10; // Stack (Value type)
             string name = "Fathy"; // Heap (Reference type)
            */

            #endregion

            #region Question 18: Value Types vs Reference Types
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 18: VALUE TYPES VS REFERENCE TYPES
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Write a code example showing how value types and reference types 
            //    behave differently when assigned to another variable.
            //
            // ══════════════════════════════════════════════════════════════════════

            #endregion

            #region Question 19: Object in C#
            // ══════════════════════════════════════════════════════════════════════
            // QUESTION 19: OBJECT IN C#
            // ══════════════════════════════════════════════════════════════════════
            //
            // Q: Why is 'object' considered the base type of all types in C#? 
            //    What methods does every type inherit from System.Object?
            //
            // ══════════════════════════════════════════════════════════════════════


            /*
             
            
                 All C# types inherit from System.Object
                
                Objects contain basic methods such as:
                ToString(), Equals(), GetHashCode(), GetType()
             
            object obj = 10;
            Console.WriteLine(obj.ToString());
            Console.WriteLine(obj.GetType());
            */
            #endregion


        }
    }
}
