using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Author - Sam Conneely
//Date - 27.05.21

namespace CA_One_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring and assigning the variables by calling the NameReturned() and AgeReturned() Methods
            string name = NameReturn();
            int age = AgeReturn();

            //When calling the YearBornCalc() Method, the two parameters are given
            //These two parameters are the variables returned from the AgeReturned() and the NameReturned() Methods
            YearBornCalc(name, age);

            Console.WriteLine("Press any button to move onto Part Two");
            Console.ReadKey();
            Console.Clear();

            //This is the other part of Question 3 -- The ArrayMethod() was created to split the code into chunks
            ArrayMethod();

            Console.Read();
        }

        //This is the array part of the question and does not return any values or take in parameters
        public static void ArrayMethod()
        {
            //Creating the string called grades with the variables given
            string[] grades = {"34.7", "56.9", "75", "52", "92.2"};

            Console.WriteLine($"The size of the array is: {grades.Length} elements long." + Environment.NewLine);
            Console.WriteLine(grades[1] + Environment.NewLine);

            //This is the loop for printing each of the elements in the Array
            Console.WriteLine("All of the elements in the Array are:");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }

            Console.WriteLine("Press any button to exit");
            Console.ReadKey();
            System.Environment.Exit(0);
        }

        //This method is used to get around an issue found when users input was returning the wrong age
        //Users that had not celebrated their birthdays yet were being returned the wrong age
        //Question is asked to user if they have had a birthdya yet this year fixing the issue
        public static void YearBornCalc(string nameInput, int ageInput)
        {
            //Declaring the variables here - Current year is set to 2021
            int yearBorn;
            int currentYear = 2021;
            bool answeredQuestion = false;

            //While loop is used to continue the program until user answers the question
            while (!answeredQuestion)
            {
                Console.WriteLine("Have you celebrated your birthday this year? Yes or No?");
                string celebrated = Console.ReadLine();

                if (celebrated.ToLower() == "no")
                {
                    //If the user has not celebrated a birthday this year, 1 is taken from the year to resolve
                    yearBorn = currentYear - ageInput;
                    Console.WriteLine($"{nameInput}, you were born in {yearBorn - 1}" + Environment.NewLine);
                    answeredQuestion = true;
                }

                else if (celebrated.ToLower() == "yes")
                {
                    yearBorn = currentYear - ageInput;
                    Console.WriteLine($"{nameInput}, you were born in {yearBorn}" + Environment.NewLine);
                    answeredQuestion = true;
                }

                else
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("Please answer Yes or No");
                }
            }
        }


        public static string NameReturn()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            return name;
        }

        //The method that returns an int has validation as to only allow a whole number
        public static int AgeReturn()
        {
            Console.WriteLine("Please enter your age");
            string age = Console.ReadLine();
            bool correctInput = int.TryParse(age, out int ageOutput);

            while (!correctInput)
            {
                Console.WriteLine("Invalid input");
                Console.WriteLine("Please enter a valid number");

                age = Console.ReadLine();

                correctInput = int.TryParse(age, out ageOutput);
            }

            return ageOutput;
        }
    }
}
