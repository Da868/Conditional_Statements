// Author: Montarious Starks
// Date:   09/17/2020
// Comments:  This C# console application code demonstrates the use of conditional statements


using System;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Line created to ask the user to input potential grade
            Console.WriteLine("What grade do you expect to recieve in ISM 4300....");

            try
            {
                // This variable will gather the input by the user
                string input = Console.ReadLine();
                /* 
                 * This variable will be used to store grades after
                 * the input variable is parsed by the decimal
                 */

                decimal grades = decimal.Parse(input);

                // this variable will be used to determine students resolve
                int spirit_in_heart = 0;

                if (grades < 59)
                {
                    //Provides the statement for a failing grade
                    Console.WriteLine("Your Letter grade is a F");
                    Console.WriteLine("This is a Failing grade. ISM 4300 is a Core Course, you will need" +
                        "  to achieve a C or better to pass the class ");

                    Console.WriteLine("On a scale of 1 to 3 do you really believe you will perform this poorly?");
                    // Assign the number to determine the resolve for the student
                    spirit_in_heart = int.Parse(Console.ReadLine());

                    switch (spirit_in_heart)
                    {
                        case 1:
                            Console.WriteLine("Awesome, of course you will do better. This is just a prediction...");
                            Console.WriteLine("Press any key to exit the program...");
                            Console.ReadKey(true);
                            break;
                        case 2:
                            Console.WriteLine("You can do better. This is just a prediction...");
                            Console.WriteLine("Press any key to exit the program...");
                            Console.ReadKey(true);
                            break;
                        case 3:
                            Console.WriteLine(" If you speak with the professor and do the the work you will succeed.");
                            Console.WriteLine("Press any key to exit the program...");
                            Console.ReadKey(true);
                            break;
                    }

                }
                else if ((grades > 60) && (grades <= 64))
                {
                    Console.WriteLine("Your Letter grade is a D-");
                    Console.WriteLine("Although this is technically passing, Muma College of Business does not accept" +
                        " this grade. ISM 4300 is a Core Course, you will need to achieve a C or Better to pass the class");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (grades == 65)
                {
                    Console.WriteLine("Your Letter grade is: D");
                    Console.WriteLine("Although this is technically passing, Muma College of Business does not accept" +
                        " this grade. ISM 4300 is a Core Course, you will need to achieve a C or Better to pass the class");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grades > 65) && (grades < 70))
                {
                    Console.WriteLine("Your Letter grade is: D +");
                    Console.WriteLine("Although this is technically passing, Muma College of Business does not accept" +
                        " this grade. ISM 4300 is a Core Course, you will need to achieve a C or Better to pass the class");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);

                }
                else if ((grades >= 70) && (grades <= 74))
                {
                    Console.WriteLine("Your Letter grade is: C -");
                    Console.WriteLine("Unfortunately, you have earned the worst Passing grade, although this is technically passing, Muma College of Business does not accept" +
                        " this grade officially as passing, you will need to take the class again. ISM 4300 is a Core Course, you will need to achieve a C or Better to pass the class");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (grades == 75)
                {
                    Console.WriteLine("Your Letter grade is: C ");
                    Console.WriteLine("This is a Passing Grade. This is average, I suggest you shoot higher to increase overall GPA.");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grades > 75) && (grades <= 79))
                {

                    Console.WriteLine("Your Letter grade is: C+");
                    Console.WriteLine("This is a Passing grade. This is slighlty above average, I suggest you shoot higher to increase" +
                        " overall GPA");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grades >= 80) && (grades <= 84))
                {
                    Console.WriteLine(" Your Letter grade is: B -");
                    Console.WriteLine("This is a Passing grade. This is slighlty above average, I suggest you shoot  higher to increase" +
                        " overall GPA");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (grades == 85)
                {
                    Console.WriteLine("Your Letter grade is: B");
                    Console.WriteLine("This is a Passing grade. This is a above average grade.");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grades >= 86) && (grades <= 89))
                {
                    Console.WriteLine("Your Letter grade is: B+");
                    Console.WriteLine("This is a Passing grade. This is a above average grade. Close to Greatness!");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grades >= 90) && (grades <= 94))
                {
                    Console.WriteLine("Your Letter grade is: A -");
                    Console.WriteLine(" This is a Passing grade. This is a ideal grade for one to aim towards.");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if (grades == 95)
                {
                    Console.WriteLine(" Your Letter grades is: A");
                    Console.WriteLine("This is an Excellent grade. This is the ideal grade for any student");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                }
                else if ((grades >= 96) && (grades <= 100))
                {
                    Console.WriteLine(" Your Letter grade is: A +");
                    Console.WriteLine(" This is the best grade any student can achieve in the class.");
                    Console.WriteLine("Press any key to exit the program...");
                    Console.ReadKey(true);
                } 

            }
            catch
            {
                Console.WriteLine("Please use a decimal data type for providing your grade...");
                Console.WriteLine(".....OR.....");
                Console.WriteLine("Please use an interger data type providing your grade....");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } /// end of catch
        } /// end of Main
    } /// end of class
} /// end of namespace
