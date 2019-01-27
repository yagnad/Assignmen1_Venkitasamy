//Programmer: Yagna Dheepika Venkitasamy
//Course: ISM6225 -DIS
//Assignment: Assignment 1

using System;

namespace Assignmen1_Venkitasamy
{
    class Program
    {
        public static void Main()
        {
            //Gather user input to calculate results
            Console.WriteLine("Hi! Choose from the following operations: " +
                "\n 1: Print Prime Numbers" +
                "\n 2: Get series result" +
                "\n 3: Decimal to Binary conversion" +
                " \n 4: Binary to Decimal Conversion " +
                "\n 5: Print Star Triange" +
                "\n 6: Compute frequency in an array " +
                "\n 7: Exit");

            int userSelection = Convert.ToInt32(Console.ReadLine());
            //Convert the user input to integer value

            //Using try block to validate the user input 
            try
            {
                switch (userSelection)
                {
                    //Print Prime nos case
                    case 1:
                        //Displaying the user choice
                        Console.WriteLine("You have chosen to print prime numbers between 2 integers");

                        Console.WriteLine("Please input the value of X: ");
                        string X_input = Console.ReadLine();//Gathering user input
                        int X = int.Parse(X_input);//Converting user input

                        Console.WriteLine("Please input the value of Y: ");
                        string Y_input = Console.ReadLine();//Gathering user input
                        int Y = int.Parse(Y_input);//Converting user input

                        printPrimeNos(X, Y); //Calls the void method to execute the calculation

                        break;

                    //Get the series value case
                    case 2:
                        //Displaying the user choice
                        Console.WriteLine("You have chosen to get series result for N");

                        Console.WriteLine("Input the number N: ");
                        int n = Convert.ToInt32(Console.ReadLine());


                        getSeriesResult(n);//Calling the return method to calculate the series value of N

                        break;

                    //Decimal to binary conversion case
                    case 3:

                        //Displaying the user choice
                        Console.WriteLine("You have chosen to convert the decimal to binary for N");

                        Console.WriteLine("Input the number N: ");//Gathering user input
                        int a = Convert.ToInt32(Console.ReadLine());//Converting user input

                        decimalToBinary(a);//Calls the return method to display the binary conversion

                        break;

                    //Binary to decimal conversion case
                    case 4:
                        //Displaying the user choice
                        Console.WriteLine("You have chosen to convert the binary to Decimal for N");

                        Console.Write("Enter a Binary Number(1s and 0s) : ");//Gathering user input
                        int b = int.Parse(Console.ReadLine()); //Converting user input

                        binaryToDecimal(b);//Calls the return method to display the decimal conversion

                        break;

                    //Print star traingle case
                    case 5:
                        //Displaying the user choice
                        Console.WriteLine("You have chosen to print triangle using * for N");
                        Console.WriteLine("Please input the number of rows desired: ");

                        int k = int.Parse(Console.ReadLine());
                        printTriange(k);//Calls the method to print traingle using *

                        break;

                    //Compute frquency in the array case
                    case 6:
                        //Displaying the user choice
                        Console.WriteLine("You have chosen to compute the frequency of elements in the array");
                        int[] arr = new int[] { 1, 2, 3, 2, 2, 1, 3, 2 };

                        computeFrequency(arr);

                        break;

                    //Exit program
                    case 7:

                        Console.WriteLine("Now exiting the console..!");//Display the exit message
                        break;

                    //Default message incase user does not select valid option
                    default:

                        Console.WriteLine("Please enter valid integers only next time..");
                        break;


                }//End of switch

                //To freeze user selection in the console
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);

            }//End of try block

            //Using catch block to display message in case of bad user input
            catch
            {
                Console.WriteLine("Please input valid integers only..");
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);
            }//End of catch block

        }//End of Main

        //Print prime number case method
        private static void printPrimeNos(int X, int Y)

        {
            //This method prints all the prime numbers between X and Y
            Console.WriteLine("Find all prime numbers between 2 integers X and Y: ");

            //Declare the variables to use in the calculation
            int i, A, N;

            //Using the try block to validate user input
            try
            {
                Console.Write("The prime numbers between {0} and {1} are : \n", X, Y);
                //Display the message based on user input

                //For loop to calculate the prime numbers in the range
                for (N = X; N <= Y; N++)
                {
                    A = 0;

                    for (i = 2; i <= N / 2; i++)
                    {
                        if (N % i == 0)
                        {
                            A++;
                            break;
                        }
                    }
                    if (A == 0 && N != 1)

                        Console.Write("{0} ", N);

                }//End of for loop

            }//End of try block

            //Using catch block to show error message for bad input
            catch
            {
                Console.WriteLine("Exception occured while computing printPrimeNumbers()");
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);
            } //End of catch block
        } //End of the method printPrimeNos

        //Method to compute factorial values
        private static double printFactorial(int n)
        {
            //Using the try block to validate user input
            try
            {
                int i, f;
                f = 1;

                //For loop to calculate the factorial values
                for (i = 1; i <= n; i++)

                    f = f * i;

                return n;
            }//End of try block
            //Using catch block to show error message for bad input
            catch
            {
                Console.WriteLine("Exception occured while computing printFactorial()");
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);
                
            } //End of catch block
            return n;

        }//End of the factorial method

        private static double getSeriesResult(int n)
        {
            //Using the try block to validate user input
            try
            {
                int i = 0;
                double sum = 0;

                //For loop to compute the series result using factorial method
                for (i = 1; i <= n; i++)
                {
                    double temp_sum = printFactorial(i) / (i + 1);

                    if (i % 2 == 0)
                    {
                        temp_sum = temp_sum * (-1);
                        sum = sum + temp_sum;
                    }
                    else
                    {
                        sum = sum + temp_sum;
                    }
                }//End of for loop
                //Displaying the sum of the series by rounding up to 3 decimal places
                Console.WriteLine("The result of the series is " + Math.Round(sum, 3));

                return sum; //Returns the sum
            }//End of try block
            //Using catch block to show error message for bad input
            catch
            {
                Console.WriteLine("Exception occured while computing getSeriesResult()");
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);
            }
            return 0;//It's a return method!!
            
        }//End of GetSeriesResult method

        //Method to convert decimal numbers to binary
        private static long decimalToBinary(long a)
        {
            //Using the try block to validate user input
            try
            {
                long quot;
                string rem = "";
                //using while loop to execute the binary conversion
                while (a >= 1)
                {
                    quot = a / 2;
                    rem += (a % 2).ToString();
                    a = quot;
                }

                string bin = "";

                //Using for loop to iterate the binary numbers for the decimals
                for (int i = rem.Length - 1; i >= 0; i--)
                {
                    bin = bin + rem[i];
                }
                Console.WriteLine("The Binary format for given number is {0}", bin);

                return a;//Its a return method!!
            }//End of try block
            //Using catch block to show error message for bad input
            catch
            {
                Console.WriteLine("Exception occured while computing decimalToBinary()");
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);
            }//End of catch
            return 0;

        }//End of DecimaltoBinary Method

        //Method to convert binary numbers to decimals
        private static long binaryToDecimal(long b)
        {
            //Using the try block to validate user input
            try
            {
                long binary_val, decimal_val = 0, base_val = 1, rem;

                binary_val = b;
                //Using while loop to compute the decimal values
                while (b > 0)
                {
                    rem = b % 10;
                    decimal_val = decimal_val + rem * base_val;
                    b = b / 10;
                    base_val = base_val * 2;
                }//End of while loop

                Console.Write("The Binary Number is : " + binary_val);
                Console.Write("\nIts Decimal Equivalent is : " + decimal_val);

                return b;//Its a return method!!
            }//End of try block
            //Using catch block to show error message for bad input
            catch
            {
                Console.WriteLine("Exception occured while computing binaryToDecimal()");
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);
            }//End of catch block
            return 0;

        }//End of the method binaryToDecimal

        //Method to print star triangle
        private static void printTriange(int k)

        {
            //Using try block to validate user input
            try
            {

                int number, i, count = 1;
                number = k;
                count = number - 1;

                //Using for loop to iterate the star using * and spaces
                for (k = 1; k <= number; k++)
                {
                    for (i = 1; i <= count; i++)
                        Console.Write(" ");
                    count--;
                    for (i = 1; i <= 2 * k - 1; i++)
                        Console.Write("*");
                    Console.WriteLine();
                }//end of for loop
            }//end of try block

            //Using catch block for bad user input
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
                Console.WriteLine("Press any key to exit..");
                Console.ReadKey();
            }
        }//End of print triangle method
        
        //Method to compute the frequency of elements in the array
        private static void computeFrequency(int[] a)
        {
            //Using the try block to validate user input
            try
            {
                int[] arr1 = new int[100];
                int[] fr1 = new int[100];
                int n, i, j, ctr;
                //Gathering user input to create the array list
                Console.Write("Input the number of elements to be stored in the array :");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input {0} elements in the array :\n", n);
                //Using for loop to gather input from the user
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i+1);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                    fr1[i] = -1;
                }

                //Using for loop to count the frequency of elements in the array list
                for (i = 0; i < n; i++)
                {
                    ctr = 1;
                    for (j = i + 1; j < n; j++)
                    {
                        if (arr1[i] == arr1[j])
                        {
                            ctr++;
                            fr1[j] = 0;
                        }
                    }

                    if (fr1[i] != 0)
                    {
                        fr1[i] = ctr;
                    }
                }
                //Displaying the result using for loop
                Console.Write("\nThe frequency of all elements of the array : \n");
                for (i = 0; i < n; i++)
                {
                    if (fr1[i] != 0)
                    {
                        Console.Write("Number " +"Frequency\n"+ "   {0} " + "  {1}\n", arr1[i], fr1[i]);
                    }
                }
            }//End of try block
            //Using catch block to show error message for bad input
            catch
            {
                Console.WriteLine("Exception occured while computing computeFrequency()");
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);
            }//End of catch block
        } //End of computeFrequency method
    }//End of Class
} //End of namespace

/*
 * 
 * 
 */