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

                            printPrimeNos(X,Y); //Calls the void method to execute the calculation
                            
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
                            Console.WriteLine("Enter the Maximum Range for the Array");
                            
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

        private static void printPrimeNos(int X, int Y)

        {
            //This method prints all the prime numbers between X and Y
            Console.WriteLine("Find all prime numbers between 2 integers X and Y: ");

            //Declare the variables to use in the calculation
            int i, A, N;

            //Using the try block to validate user input
            try
            {

                Console.Write("The prime numbers between {0} and {1} are : \n", X, Y);//Display the message based on user input

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

            int i, f;
            f = 1;
            
            for (i = 1; i <= n; i++)

                f = f * i;

            return n;
            
        }//End of the factorial method

        private static double getSeriesResult(int n)
        {

            int i = 0;
            double sum = 0;
            
            
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
                
            }
            Console.WriteLine("The result of the series is " + Math.Round(sum,3));
            
            return sum; //Returns the sum
            
            
        }//End of GetSeriesResult method

        private static long decimalToBinary(long a)
        {
            long quot;
            string rem = "";
            while (a >= 1)
            {
                quot = a / 2;
                rem += (a % 2).ToString();
                a = quot;
            }
            string bin = "";
            for (int i = rem.Length - 1; i >= 0; i--)
            {
                bin = bin + rem[i];
            }
            Console.WriteLine("The Binary format for given number is {0}", bin);
            
            return a;
            
        }//End of DecimaltoBinary Method

        private static long binaryToDecimal(long b)
        {
            long binary_val, decimal_val = 0, base_val = 1, rem;
            
            binary_val = b;
            while (b > 0)
            {
                rem = b % 10;
                decimal_val = decimal_val + rem * base_val;
                b = b / 10;
                base_val = base_val * 2;
            }
            Console.Write("The Binary Number is : " + binary_val);
            Console.Write("\nIts Decimal Equivalent is : " + decimal_val);

            return b;
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
                for (k = 1; k <= number; k++)
                {
                    for (i = 1; i <= count; i++)
                        Console.Write(" ");
                    count--;
                    for (i = 1; i <= 2 * k - 1; i++)
                        Console.Write("*");
                    Console.WriteLine();
                }//end of for loop
            }//end of try

            //Using catch block for bad user input
            catch
            {
                Console.WriteLine("Exception occured while computing printTriangle()");
                Console.WriteLine("Press any key to exit..");
                Console.ReadKey();
            }
        }//End of print triangle method


        private static void computeFrequency(int []a)
        {
            int i, j, N, count;

            Console.WriteLine("Enter the Maximum Range for the Array");
            N = Convert.ToInt32(Console.ReadLine());
            string[] m = new string[N];
            int[] freq = new int[N];
            for (i = 0; i < N; i++)
            {
                m[i] = Console.ReadLine();
                freq[i] = -1;
            }
            for (i = 0; i < N; i++)
            {
                count = 1;
                for (j = i + 1; j < N; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        freq[j] = 0;
                    }
                    
                }
                if (freq[i] != 0)
                {
                    freq[i] = count;
                }

            }
            for (i = 0; i < N; i++)
            {
                if (freq[i] != 1)
                {
                    Console.Write("{0}{1}", a[i], freq[i]);
                }
            }

        } //End of computeFrequency method

    }//End of Class
} //End of namespace

