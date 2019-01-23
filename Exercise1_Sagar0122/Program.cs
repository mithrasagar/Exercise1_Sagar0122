using System;

namespace Exercise1_Sagar0122
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a grade
            Console.Write("Enter the grade you have in the class. ");

            try
            {
                string input = Console.ReadLine();
                int gradeNum = int.Parse(input);

                letterGrade(gradeNum);
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey(true);

            } // End try
            catch
            {
                Console.WriteLine("There is an error in the application. Please close and try again.");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey(true);
            } // End catch
        } // End main

        private static int letterGrade(int gradeNum)
        {

            int letterGradeValue = gradeNum;

            if ((gradeNum >= 60) && (gradeNum < 63))
            {
                Console.WriteLine("You have a D in the class.");
            }
            else if ((gradeNum >= 63) && (gradeNum < 67))
            {
                Console.WriteLine("You have a D+ in the class.");
            }
            else if ((gradeNum >= 67) && (gradeNum < 70))
            {
                Console.WriteLine("You have a C- in the class.");
            }
            else if ((gradeNum >= 70) && (gradeNum < 74))
            {
                Console.WriteLine("You have a C in the class. You can do it!");
            }
            else if ((gradeNum >= 74) && (gradeNum < 77))
            {
                Console.WriteLine("You have a C+ in the class. You can do it!");
            }
            else if ((gradeNum >= 77) && (gradeNum < 80))
            {
                Console.WriteLine("You have a B- in the class. You can do it!");
            }
            else if ((gradeNum >= 80) && (gradeNum < 84))
            {
                Console.WriteLine("You have a B in the class. Not too bad!");
            }
            else if ((gradeNum >= 84) && (gradeNum < 87))
            {
                Console.WriteLine("You have a B+ in the class. Not too bad!");
            }
            else if ((gradeNum >= 87) && (gradeNum < 90))
            {
                Console.WriteLine("You have an A- in the class. Almost there!");
            }
            else if ((gradeNum >= 90) && (gradeNum < 95))
            {
                Console.WriteLine("You have an A in the class. Great work!");
            }
            else if ((gradeNum >= 95) && (gradeNum < 100))
            {
                Console.WriteLine("You have an A+ in the class. Great work!");
            }
            else if ((gradeNum < 60) && (gradeNum >= 0))
            {
                Console.WriteLine("You have an F in the class.");
            }
            else
            {
                Console.WriteLine("Be sure to enter an integer value between 0 and 100.");
                Console.WriteLine("Close the application and try again.");
                Console.ReadKey(true);
            }

            return letterGradeValue;
        }

    } // End class
} // End namespace
