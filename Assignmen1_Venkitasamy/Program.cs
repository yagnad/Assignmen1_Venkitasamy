using System;

namespace Assignmen1_Venkitasamy
{
    class Program
    {
        public static void Main()
        {
            //This method prints all the prime numbers between X and Y
            Console.WriteLine("Find all prime numbers between 2 integers X and Y: ");

            int X, Y, i, A, N;
            
            try
            {

                Console.WriteLine("Pls input X: ");//Input starting number
                X = Convert.ToInt32(Console.ReadLine());//Converts the data to int

                Console.WriteLine("Pls input Y: ");//Input ending number
                Y = Convert.ToInt32(Console.ReadLine());//Converts the data to int

                Console.Write("The prime numbers between {0} and {1} are : \n", X, Y);//Display the message

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

                        Console.Write("{0} ",N);
                        
                }
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Pls enter a valid integer..");
                Console.WriteLine("\nPress any key to exit the program ...");
                Console.ReadKey(true);
            }
            }

        }
    }

