using System;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace Day_5_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // part 01
            #region problem1
            //int n1, n2, res;
            //do
            //{
            //    Console.Write("Enter n1 : ");
            //} while (!int.TryParse(Console.ReadLine(), out n1));
            //do
            //{
            //    Console.Write("Enter n2 : ");
            //} while (!int.TryParse(Console.ReadLine(), out n2));

            //try
            //{
            //    res = n1 / n2;
            //    Console.WriteLine(res);

            //}
            //catch (DivideByZeroException error)
            //{

            //    Console.WriteLine(error.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Operation complete");
            //}

            /**
             *  What is the purpose of the finally block?
             *  
             *  ensure that a specific block of code executes,
             *  regardless of whether an exception was thrown or handled
             *   handles unexpected scenarios gracefully.
             */

            #endregion

            #region problem2
            //int X, Y, Z;
            ////bool flag;
            //do
            //    Console.WriteLine("enter first number :");
            //while (!int.TryParse(Console.ReadLine(), out X) || X < 0);
            //do
            //    Console.WriteLine("enter second number :");
            //while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);
            //Z = X / Y;

            //Console.WriteLine(Z);

            /**
             * How does int.TryParse() improve program robustness compared to int.Parse()? 
             * 
             * Avoiding Exceptions: It does not throw an exception for invalid input; instead,
             * it returns false and sets the output to 0.
             * 
             * Simpler Error Handling: It uses a boolean result to indicate success or failure,
             * eliminating the need for try-catch blocks.
             * 
             * Graceful Input Validation: It allows safe handling of user input without risking program crashes.
             * 
             * Better Performance: Avoids the overhead of exception handling, making it more efficient for frequent input checks.
             */
            #endregion

            #region Problem3
            //Nullable<int> x = null;
            //int y = x ?? 0;
            //Console.WriteLine(y);
            //if (x.HasValue)
            //{
            //    Console.WriteLine($"x has value : {x.Value}");
            //}
            //else
            //{
            //    Console.WriteLine("x :{null}");
            //}
            //x = 10;
            //if (x.HasValue)
            //{
            //    Console.WriteLine($"x has value : {x.Value}");
            //}

            /**
             * What exception occurs when trying to access Value on a null Nullable<T>?
             * 
             * When you access Value on a Nullable<T> that is null, an InvalidOperationException occurs with the message: "Nullable object must have a value."
             */
            #endregion

            #region problem4
            //int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            //try
            //{
            //    int x = arr[5];
            //    Console.WriteLine(x);
            //}
            //catch (IndexOutOfRangeException error)
            //{
            //    Console.WriteLine(error.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("op finish");
            //}

            /**
             *  Why is it necessary to check array bounds before accessing elements? 
             *  
             *  Checking array bounds before accessing elements 
             *  is necessary to prevent runtime errors and ensure program stability
             */
            #endregion

            #region problem5
            //int[,] arr_2D = new int[3, 3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"enter the value of array number {i+ 1}");
            //    for (int x = 0; x < 3; x++)
            //    {
            //        Console.Write($"Enter the number {x + 1} : ");
            //        int.TryParse(Console.ReadLine(), out arr_2D[i, x]);
            //    }
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    int row_sum = 0;
            //    for (int x = 0; x < 3; x++)
            //    {
            //        row_sum += arr_2D[i, x];
            //    }
            //    Console.WriteLine($"the result of row {i + 1} is {row_sum}");
            //}

            //for (int i = 0; i < 3; i++)
            //{
            //    int col_sum = 0;
            //    for (int x = 0; x < 3; x++)
            //    {
            //        col_sum += arr_2D[x, i];
            //    }
            //    Console.WriteLine($"the result of column {i + 1} is {col_sum}");
            //}

            /**
             * How is the GetLength(dimension) method used in multi-dimensional arrays? 
             * int[,] multiArray = {
                    {1, 2, 3},
                    {4, 5, 6},
                    {7, 8, 9}
                };
                int rows = multiArray.GetLength(0); // Number of rows
                int columns = multiArray.GetLength(1); // Number of columns
                
                The GetLength(dimension) method allows for flexible and dynamic handling of multi-dimensional arrays by providing the size of specific dimensions,
                making it a key tool for working with such arrays effectively.
             */
            #endregion

            #region problem6
            //int[][] jagged_arr = new int[3][];
            //jagged_arr[0] = new int[3];
            //jagged_arr[1] = new int[2];
            //jagged_arr[2] = new int[1];

            //for (int i = 0; i < jagged_arr.Length; i++)
            //{
            //    Console.WriteLine($"Enter the numbers of array {1 + i}");
            //    for (int x = 0; x < jagged_arr[i].Length; x++)
            //    {
            //        Console.Write($"Enter number {x + 1} : ");
            //        int.TryParse(Console.ReadLine(), out jagged_arr[i][x]);
            //    }
            //}

            //for (int i = 0; i < jagged_arr.Length; i++)
            //{
            //    Console.WriteLine($"the numbers of array {1 + i}");
            //    for (int x = 0; x < jagged_arr[i].Length; x++)
            //    {
            //        Console.Write($" {jagged_arr[i][x]}");
            //    }
            //    Console.WriteLine();
            //}

            /**
             * How does the memory allocation differ between jagged arrays and rectangular arrays?
             * 
             * Jagged Arrays: An array of arrays, where each row can have a different size.
             * They are stored in non-contiguous memory, leading to more flexibility but potentially slower access due to indirection.
             * 
             * Rectangular Arrays: A multi-dimensional array where all rows have the same size.
             * They are stored in a single, contiguous memory block, leading to faster access and better memory efficiency but less flexibility in row sizes.
             */
            #endregion

            #region problem7

            //string? input = null;

            //Console.WriteLine("enter string :");
            //input = Console.ReadLine();

            //if (input != null)
            //{
            //    Console.WriteLine($"You entered: {input!}");
            //}
            //else
            //{
            //    Console.WriteLine("No string was entered.");
            //}

            /**
             * What is the purpose of nullable reference types in C#? 
             * 
             * help prevent null reference exceptions by distinguishing between nullable and non-nullable reference types at compile time.
             * With nullable reference types, you can explicitly specify whether a reference type can be null, improving code safety and clarity.
             */
            #endregion

            #region problem8
            //int x = 22;
            ////boxing valid
            //object obj = x;

            ////unboxing valid
            //int y = (int)obj;


            //object obj2 = "ahmed";
            //int z = (int)obj2; // invalid unboxing;

            /**
             * What is the performance impact of boxing and unboxing in C#? 
             * 
             * Boxing: Converts a value type to a reference type, causing heap allocation, data copying, and garbage collection overhead.
             * Unboxing: Involves type checking and accessing memory, which is slower than using value types directly.
             */


            #endregion

            #region problem9
            //int n1 = 5, n2 = 6;
            //int sum, product;

            //SumAndMultiply(n1, n2, out sum, out product); //work like pointer in c/c++ we pass the address of &sum and &product

            //Console.WriteLine(sum);
            //Console.WriteLine(product);

            /**
             *  Why must out parameters be initialized inside the method? 
             *  
             *  out parameters must be initialized inside the method because they are intended to return a value to the caller.
             *  Unlike regular parameters, out parameters do not need to be initialized before being passed to the method,
             *  but the method must assign a value to them before exiting, ensuring that they have a valid value when the method completes.
             *  This guarantees that the caller will always receive a properly initialized value.
             */
            #endregion

            #region problem10
            //Console.Write("enter the string: ");
            //string str = Console.ReadLine();
            //print_str(str);

            /**
             * Why must optional parameters always appear at the end of a method's parameter list?
             * 
             * Optional parameters must appear at the end of a method's parameter list because C# needs to know which arguments are being passed explicitly and which are using default values.
             * If optional parameters were placed before required ones, 
             * it would be unclear how arguments are matched to parameters,
             * leading to ambiguity in the method call.
             */
            #endregion

            #region problem11
            //int?[] nul_arr = new int?[] {1, 2, 3, null};
            //int? len = nul_arr.Length;
            //Console.WriteLine(len);

            //int? null_value = nul_arr?[3];
            //Console.WriteLine(null_value);

            /**
             * How does the null propagation operator prevent NullReferenceException?
             * 
             * The null propagation operator (?.) prevents a NullReferenceException by safely accessing members or methods of an object that may be null.
             * If the object is null, the expression evaluates to null instead of throwing an exception, allowing the program to continue running without errors.
             */


            #endregion

            #region problem12
            //Console.Write("entr the day: ");

            //string Day = Console.ReadLine();
            //int dayNum;
            //switch (Day)
            //{
            //    case "Monday":
            //        dayNum = 1;
            //        break;
            //    case "Tuesday":
            //        dayNum = 2;
            //        break;
            //    case "Wednesday":
            //        dayNum = 3;
            //        break;
            //    case "Thursday":
            //        dayNum = 4;
            //        break;
            //    case "Friday":
            //        dayNum = 5;
            //        break;
            //    case "Saturday":
            //        dayNum = 6;
            //        break;
            //    case "Sunday":
            //        dayNum = 7;
            //        break;
            //    default:
            //        dayNum = -1; // invalid
            //        break;
            //}

            //Console.WriteLine(dayNum);

            //===========================================================

            //int dayNum = Day switch
            //{
            //    "Monday" => 1,
            //    "Tuesday" => 2,
            //    "Wednesday" => 3,
            //    "Thursday" => 4,
            //    "Friday" => 5,
            //    "Saturday" => 6,
            //    "Sunday" => 7,
            //    _ => -1
            //};

            //if (dayNum == -1)
            //{
            //    Console.WriteLine('Invalid input');
            //}
            //else
            //{
            //    Console.WriteLine($"the number of {Day} you enter is {dayNum}");
            //}


            /**
             *  When is a switch expression preferred over a traditional if statement? 
             *  
             *  A switch expression is preferred over an if statement when you need to match a variable against multiple possible values concisely,
             *  especially when returning a value directly. It improves readability and reduces code complexity compared to multiple if-else conditions.
             */

            #endregion

            #region problem13
            //int res = SumArray(1, 2, 3, 4, 5);
            //Console.WriteLine(res);

            //int[] arr = { 1, 2, 3 };
            //int res2 = SumArray(arr);
            //Console.WriteLine(res2);

            /**
             * What are the limitations of the params keyword in method definitions? 
             * 
             * Only one params parameter per method.
             * It must be the last parameter.
             * Cannot be used with other parameters of the same type after it.
             * Cannot be used with optional parameters after it.
             */
            #endregion

            //=========================================

            //part 02

            #region Program1
            //Write a program that allows the user to insert a positive integer, then print all numbers from 1 to
            // that number
            //int input;
            //do
            //{
            //    Console.WriteLine("enter the number :");

            //} while (!int.TryParse(Console.ReadLine(), out input) || input < 0);

            //for (int i = 1; i <= input; i++)
            //{
            //    Console.Write(i);
            //}
            //Console.WriteLine();
            #endregion

            #region Program2
            //Write a program that allows the user to insert an integer, then print the multiplication table for
            //that number up to 12 times.

            //int input;
            //do
            //{
            //    Console.WriteLine("enter the number :");

            //} while (!int.TryParse(Console.ReadLine(), out input) || input <= 0);

            //for (int i = 1; i <= 12; i++)
            //{
            //    if (i == 12)
            //    {
            //        Console.Write($"{i * input}");
            //    }
            //    else
            //    {
            //        Console.Write($"{i * input}, ");
            //    }
            //}
            //Console.WriteLine();

            #endregion

            #region Program3
            //int input;
            //do
            //{
            //    Console.WriteLine("enter the number :");

            //} while (!int.TryParse(Console.ReadLine(), out input) || input <= 0);

            //for (int i = 1; i <= input ; i++)
            //{
            //    if (i % 2 == 0 && (i == input || i == input -1))
            //    {
            //        Console.Write(i);
            //    }
            //    else if(i % 2 == 0)
            //    {
            //        Console.Write($"{i}, ");
            //    }
            //}
            //Console.WriteLine();
            #endregion

            #region Program4
            //int input1, input2, res;
            //do
            //{
            //    Console.WriteLine("enter the number1 :");

            //} while (!int.TryParse(Console.ReadLine(), out input1) || input1 < 0);
            //do
            //{
            //    Console.WriteLine("enter the number2 :");

            //} while (!int.TryParse(Console.ReadLine(), out input2) || input2 < 0);

            //res = 1;
            //for (int i = 0; i < input2; i++)
            //{
            //    res *= input1;
            //}
            //Console.WriteLine(res);
            #endregion

            #region Program5
            //Console.WriteLine("Enter the string: ");
            //string input = Console.ReadLine();

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(input[i]);
            //}
            //Console.WriteLine();
            #endregion

            #region Program6
            // Write a program that allows the user to enter an integer and then prints the integer with its digits
            //in reverse order.
            //Console.WriteLine("Enter an integer:");
            //int number = int.Parse(Console.ReadLine());
            //int reversed = 0;

            //// While the number is not zero
            //while (number != 0)
            //{
            //    int digit = number % 10;

            //    reversed = reversed * 10 + digit;

            //    // Remove the last digit from the number
            //    number /= 10;

            //}
            //Console.WriteLine(reversed);
            #endregion

            #region Program7
            //Console.WriteLine("Enter the array elements separated by ,:");
            //string input = Console.ReadLine();

            //int[] arr = Array.ConvertAll(input.Split(','), int.Parse);

            //int longestDistance = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i;

            //            if (distance > longestDistance)
            //            {
            //                longestDistance = distance;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine(longestDistance);
            #endregion

            #region Program8
            //Console.WriteLine("enter the sentance: ");
            //string input = Console.ReadLine();
            //string[] arr = input.Split(' ');
            //Array.Reverse(arr);
            //string res = string.Join(" ", arr);
            //Console.WriteLine(res);
            #endregion

        }
        static void print_str(string str, int value=5)
        {
            for (int i = 0; i < value; i++)
            {
                Console.WriteLine(str);
            }
        }
        static void SumAndMultiply(int a, int b, out int sum, out int product) // like i use pointer *sum and *product
        {
            sum = a + b;
            product = a * b;
        }
        static int SumArray(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
}