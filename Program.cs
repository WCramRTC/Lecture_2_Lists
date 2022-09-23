using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Lists
{
    internal class Program
    {
        static List<string> names = new List<string>();
        static List<int> compSciGrades = new List<int>();
        static List<int> genEdGrades = new List<int>();

        static void Main(string[] args)
        {
            //            Create 3 Lists: One to hold names, one to comp sci grades(numeric ), one to hold gen ed grades(numeric )


            CreateLists();
            DisplayLists(names, compSciGrades, genEdGrades);
     


            //Create a console menu with the options to display all students, enter a new student, or exit the app.

            //Give the user the option to display all the students:
            //Ex:

            //            Student Name: Will Cram
            //Comp Sci Grade: 72
            //Gen Ed Grade: 89
            //Average: 80.5

            //Student Name: Hannah Angel
            //Comp Sci Grade: 100
            //Gen Ed Grade: 100
            //Average: 100

            //Student Name: Kristyn Tanaguchi
            //Comp Sci Grade: 100
            //Gen Ed Grade: 100
            //Average: 100

            //Create a method that returns the average

            //When entering in a new student make sure the name isn't blank, and that the numbers are actually numbers. Alert the user to enter in proper information and let them try again.

        } // Main

        public static void CreateLists()
        {

            names.Add("Samantha");
            compSciGrades.Add(199);
            genEdGrades.Add(100);

            names.Add("Wong");
            compSciGrades.Add(150);
            genEdGrades.Add(125);

            names.Add("Zack");
            compSciGrades.Add(250);
            genEdGrades.Add(125);

            names.Add("Will");
            compSciGrades.Add(25);
            genEdGrades.Add(15);
        } // CreateLists()

        public static void DisplayLists(List<string> n, List<int> cs, List<int> ge)
        {
            for (int i = 0; i < n.Count; i++)
            {
                Console.WriteLine($"Name: {n[i]}");
                Console.WriteLine($"Comp Sci Grade: {cs[i]}");
                Console.WriteLine($"Gen Ed Grade: {ge[i]}");
                Console.WriteLine();
            }
        } // DisplayLists()

        public static void ListExample()
        {
            // How to declare a List
            List<int> ages = new List<int>();
            List<string> names = new List<string>();
            List<bool> attendence = new List<bool>();

            // Pro
            // Easy to add values to
            ages.Add(5);
            ages.Add(4);
            ages.Add(3);
            ages.Add(2);
            ages.Add(1);

            // Lists start with an array of 10
            // use list.Count to get your current count value
            for (int i = 0; i < 20; i++)
            {
                ages.Add(4);
            }

            while (ages.Contains(4))
            {
                ages.Remove(4);
            }

            foreach (int item in ages)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(ages.Contains(4));
        } // ListExample

        public static void ArrayExample()
        {
            int[] ages2 = new int[5];
            // 5 4 3 2 1
            //ages[0] = 5;
            //ages[1] = 4;
            //ages[2] = 3;

            for (int i = 0; i < ages2.Length; i++)
            {
                int age = 5;
                ages2[i] = age - i;
            }

            foreach (int item in ages2)
            {
                Console.WriteLine(item);
            }
        } // ArrayExample

        // Method Signature
        // taktes two int arguments, returns the sum of the two arguments, is called add
        // Access Modifier - Static - Return Type - Name - Parameters - Code Body
        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        } // Add

        public static void DisplayNumbers(int num)
        {
            Console.WriteLine(num);
        } // DisplayNumbers

        public static string[] StudentList()
        {
            string[] students =
 {
                "Will",
                "Hannah",
                "Samantha",
                "Zach",
                "Wong"
            };

            return students;
        } // StudentList

        public static void Prog1Review()
        {
            // inputs
            Console.ReadLine();

            // outputs
            Console.WriteLine();
            Console.Write("");

            // null
            // variable
            // Primitive Data Types
            // string, char 
            // bool
            // double, decimal, float
            // int, long, short, byte

            // Loops
            // for
            // while loop
            // do while

            // conditions
            // if, else if, else
            // switch

            // operators
            // Math Operators : + - / * %
            // Assignment Operators: = , -=, +=, /=, *=, %=
            // Conditional Operators: >, <, >=,<=, != , ==
            // Logical Operators: &&, ||, !

            // Array
            int[] ages = new int[10];
            float[] grades = new float[30];
            uint[] times = new uint[2000];

            //             0  1  2  3  4
            int[] nums = { 1, 2, 3, 4, 5 };
            // 12
            // 2
            nums[2] = 12;
            nums[4] = 15;
            nums[1] = 83;
            // 3
            nums[3] = nums[2] + nums[4];

            //foreach (int item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            string[] students = StudentList();

            foreach (string item in students)
            {
                Console.WriteLine(item);
            }

            int addTwoNumber = Add(1, 2);
            int addAnotherTwoNumbers = Add(3, 4);

            Console.WriteLine(addTwoNumber + "\n" + addAnotherTwoNumbers);
            Console.WriteLine(Add(addTwoNumber, addAnotherTwoNumbers));


            addTwoNumber = Add(Add(1, 2), Add(3, 4));
            //Console.WriteLine(addTwoNumber);
            DisplayNumbers(addTwoNumber);
        } // Prog1Review



    } // class

} // namespace
