using System;

namespace Assignmen1_Venkitasamy
{
    class Program
    {
        public static void Main()
        {
            //This method prints all the prime numbers between X and Y
            Console.WriteLine("FInd all prime numbers between 2 integers X and Y: ");

            int X, Y, i,A, N;
            
            try
            {

                Console.WriteLine("Pls input X: ");
                X = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pls input Y: ");
                Y = Convert.ToInt32(Console.ReadLine());

                Console.Write("The prime numbers between {0} and {1} are : \n", X, Y);

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

