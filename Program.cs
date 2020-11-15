using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computingTestAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            string restart;
            do
            {
                Console.WriteLine("\n\r##########Computing Test Results##########"); // shows the title of the program
                bool selectedNumber = false;
                while (selectedNumber == false) // while loop used for validation
                {
                    Console.WriteLine("\nEnter the number of students: ");
                    string studentNumber = Console.ReadLine();
                    int numberStudents;



                    if (!int.TryParse(studentNumber, out numberStudents)) // user input validation, if the user inputs anything other than an integar,
                                                                          //program will show an error message and loop to the question below.
                    {
                        Console.WriteLine("\nTry again, please input the number of student as an integer");
                    }
                    else
                    {
                        int i;
                        selectedNumber = true;
                        string studentName;
                        string[] name = new string[numberStudents]; // students name array
                        double[] grades = new double[numberStudents]; // grades array
                        for (i = 0; i < numberStudents; i++) // for loop
                        {
                            bool selectName = false;
                            while (selectName == false)
                            {
                                Console.WriteLine("\nPlease input student name {0} ", (i + 1));

                                studentName = Console.ReadLine();
                                if (studentName == "")
                                {
                                    Console.WriteLine("\nTry again, please input the students name using valid characters");
                                }
                                else
                                {
                                    selectName = true;
                                    name[i] = studentName;
                                    bool studentGrade = false;
                                    while (studentGrade == false)
                                    {
                                        Console.WriteLine("\nPlease input student grade");
                                        string inputtedGrade = Console.ReadLine();
                                        int mark;
                                        if (!int.TryParse(inputtedGrade, out mark) || mark > 100 || mark < 0 || inputtedGrade == "") // data valdiation using TryParse

                                        {
                                            Console.WriteLine("\nTry again, please input the students grade as an integer");
                                        }
                                        else
                                        {
                                            studentGrade = true;
                                            grades[i] = mark;

                                        }
                                    }
                                }
                            }

                        }
                        Array.Sort(grades);
                        Array.Reverse(grades);
                        Console.WriteLine("\nStudent grades from highest to lowest marks ");
                        for (i = 0; i < numberStudents; i++) // for loop used to display student grades
                        {
                            Console.WriteLine(grades[i]);

                        }
                    }
                }
                Console.WriteLine("\npress Y to restart. \n press any key to exit.");
                restart = Console.ReadLine().ToUpper();
            } while (restart == "Y"); // a Do While loop to restart or exit the application
        }
    }
}
