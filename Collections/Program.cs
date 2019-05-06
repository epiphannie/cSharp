using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>(new List<Student>())
           {
               new Student() {Name = "Sally", GradeLevel = 3},
               new Student() {Name = "Bob", GradeLevel = 3},
               new Student() {Name = "Sally", GradeLevel = 2}
           };

            //SchoolRoll schoolRoll = new SchoolRoll();
            //schoolRoll.AddStudents(students);

            //students.Sort();

            //Student newStudent = new Student() { Name = "Joe", GradeLevel = 2 };

            //int index = students.BinarySearch(newStudent);

            //if (index < 0)
            //{
            //    students.Insert(~index, newStudent); 
            //}
            ////~index = (-index)-1
            Student joe = new Student() { Name = "Joe", GradeLevel = 2 };
            Student duplicateJoe = new Student() { Name = "Joe", GradeLevel = 2 };

            students.Add(joe);
            students.Add(duplicateJoe);

            //if (students.Contains(joe))
            //{

            //}

            //Console.WriteLine(joe.GetHashCode());
            //Console.WriteLine(duplicateJoe.GetHashCode());
            foreach (Student student in students)
            {
                Console.WriteLine(String.Format("{0} is in grade {1}", student.Name, student.GradeLevel));
            }
            ////Jagged Array
            //Cell[][] sheet = new Cell[100][];
            //for (int rowIndex = 0; rowIndex < sheet.Length; rowIndex++)
            //{
            //    sheet[rowIndex] = new Cell[10];
            //    //create a row of 10 cells
            //    for (int colIndex = 0; colIndex < sheet[rowIndex].Length; colIndex++)
            //    {
            //        sheet[rowIndex][colIndex] = new Cell();
            //    }
            //}

            //foreach(Cell[] row in sheet)
            //{
            //    foreach(Cell cell in row)
            //    {
            //        Console.Write(cell);
            //    }
            //    Console.WriteLine();
            //}

            ////Every row has the exact same number of cells, a true multi-dimensional array
            //Cell[,] sheet2D = new Cell[100, 10];
            
            //for(int rowIndex = 0; rowIndex < sheet2D.GetLength(0); rowIndex++)
            //    //Get length of first dimension
            //{
            //    for(int colIndex = 0; colIndex < sheet2D.GetLength(1); colIndex++)
            //        //Get length of second dimenstion
            //    {
            //        sheet2D[rowIndex, colIndex] = new Cell();
            //    }
            //}

            ////adding stuff to an array
            //int[]ages = { 24, 31, 56 };
            //int[] agesCopy = new int[4];
            //ages.CopyTo(agesCopy, 1);
            //agesCopy[0] = 16;
            //ages = agesCopy; //this won't work as prior references won't be updated

            ////fast for retrieving and setting, slow for removing and adding

            ////lists
            //List<string> students = new List<string>();
            //students.Add("Sue");
            //students.Add("Ann");
            //students.Count(); //=2;
            //students[0]; //"Sue";
            //students.Capacity(); //=4, when the number is increased, it automatically doubles the size of the original array, which is 4
            ////its a good idea to pass an estimated capacity initially
            //List<string> students = new List<string>(500);
            //List<string> students = new List<string>(5) { "Ann", "Sue", "David" };
            //List<string> students2 = new List<string>(students);
            //string[] studentArray = students.ToArray();
            //foreach(string student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //students.Insert(1, "Frank"); //this is not quick if there are a lot of items, since the underlying base is just an array
            //students.RemoveAt(2);
            //students.Remove("Sue"); //returns true if it found the student and removed them, only removes the first
            //students.Sort()//alphabetical, stores the sorted list back in the same list

            ////Not optimized to have insertions and deletions
        }

    }
}
