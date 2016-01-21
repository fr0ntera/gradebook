using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/* STUDENT GRADEBOOK APPLICATION
Create a console application that will record the score scores for each student.  
Define a class student that contains the following information: First Name, Last Name, a score for each of 5 
score assignments, and the average of those assignments.Declare two constructors, including one default 
constructor.Create a method that will calculate the average of the 5 score assignments.The application should 
accept all inputs from a user and then write all of the information to a text file.Make sure the user can input as 
many students as they want and then can open up the text file to see all of the information. */
namespace gradebook
{

    class Program
    {
        static void Main(string[] args)
        {

            StreamWriter writer = new StreamWriter("grades.txt");
            string check = "y";
            using (writer)
            {
                while (check == "y")

                {
                    Console.WriteLine("First Name:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Last Name:");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Score 1:");
                    int score1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Score 2:");
                    int score2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Score 3:");
                    int score3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Score 4:");
                    int score4 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Score 5:");
                    int score5 = Convert.ToInt32(Console.ReadLine());
                    Student student = new Student(firstName, lastName, score1, score2, score3, score4, score5);
                    Console.WriteLine(student.StudentAverage());

                    
                        writer.WriteLine("First Name" + "   " + "Last Name" + "  " + "HW1" + "   " + "HW2" + "    " + "HW3" + "   " + "HW4" + "   " + "HW5");
                        writer.Write(firstName + "    ");
                        writer.Write(lastName + "    ");
                        writer.Write(score1 + "    ");
                        writer.Write(score2 + "    ");
                        writer.Write(score3 + "    ");
                        writer.Write(score4 + "    ");
                        writer.Write(score5 + "    ");
                        writer.WriteLine();
                    

                    Console.WriteLine("Would you like to enter another student? y/n");
                    check = Console.ReadLine();
                }
            }
        }
    }
    class Student
    {
        private string firstName;
        private string lastName;
        int score1;
        int score2;
        int score3;
        int score4;
        int score5;


        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int ScoreOne
        {
            get { return this.score1; }
            set { this.score1 = value; }
        }

        public int ScoreTwo
        {
            get { return this.score2; }
            set { this.score2 = value; }
        }

        public int ScoreThree
        {
            get { return this.score3; }
            set { this.score3 = value; }
        }

        public int ScoreFour
        {
            get { return this.score4; }
            set { this.score4 = value; }
        }

        public int ScoreFive
        {
            get { return this.score5; }
            set { this.score5 = value; }
        }

        public Student()
        {
            this.FirstName = "undefined";
            this.LastName = "undefined";
            this.ScoreOne = 0;
            this.ScoreTwo = 0;
            this.ScoreThree = 0;
            this.ScoreFour = 0;
            this.ScoreFive = 0;

        }

        public Student(string FirstName, string LastName, int ScoreOne, int ScoreTwo, int ScoreThree, int ScoreFour, int ScoreFive)
        {

            this.FirstName = FirstName;
            this.LastName = LastName;
            this.ScoreOne = ScoreOne;
            this.ScoreTwo = ScoreTwo;
            this.ScoreThree = ScoreThree;
            this.ScoreFour = ScoreFour;
            this.ScoreFive = ScoreFive;
        }

        public int StudentAverage()
        {
            int StudentAverage = (this.ScoreOne + this.ScoreTwo + this.ScoreThree + this.ScoreFour + this.ScoreFive) / 5;
            return StudentAverage;
        }
    }
}