using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOnListDemo
{
    using CrudOnListDemo.Model;
    using System;
    using System.Collections.Generic;

    class Program
    {


        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();



            // Create
            studentList.Add(new Student { StudentId = 1, StudentName = "Albin" });
            studentList.Add(new Student { StudentId = 2, StudentName = "Albin Seba" });


            Console.WriteLine("----------------------------------------");
            // Read
            
            Console.WriteLine("Student in the list:");
            foreach (Student student in studentList)
            {
                Console.WriteLine($"Id: {student.StudentId}, Name: {student.StudentName}");
            }




            Console.WriteLine("----------------------------------------");
            // Update

            int studentIdToUpdate = 2;
            Student studentNameUpdate = studentList.Find(item => item.StudentId == studentIdToUpdate);
            if (studentNameUpdate != null)
            {
                studentNameUpdate.StudentName = "Updated to Albii";
                Console.WriteLine($"Item {studentIdToUpdate} updated.");
            }
            else
            {
                Console.WriteLine($"Item {studentIdToUpdate} not found.");
            }



            Console.WriteLine("----------------------------------------");
            // Read again after update
            Console.WriteLine("Items in the list after update:");
            foreach (Student student in studentList)
            {
                Console.WriteLine($"Id: {student.StudentId}, Name: {student.StudentName}");
            }




            Console.WriteLine("----------------------------------------");
            // Delete
            int studentIdToDelete = 1;
            Student studentToDelete = studentList.Find(item => item.StudentId == studentIdToDelete);
            if (studentToDelete != null)
            {
                studentList.Remove(studentToDelete);
                Console.WriteLine($"Student {studentIdToDelete} deleted.");
            }
            else
            {
                Console.WriteLine($"Student {studentIdToDelete} not found.");
            }



            Console.WriteLine("----------------------------------------");
            // Read again after delete
            Console.WriteLine("Items in the list after delete:");
            foreach (Student student in studentList)
            {
                Console.WriteLine($"Id: {student.StudentId}, Name: {student.StudentName}");
            }
        }
    }
}
