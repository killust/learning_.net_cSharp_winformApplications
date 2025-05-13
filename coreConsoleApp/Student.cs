using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreConsoleApp
{
    internal class Student
    {
        int studentId;
        string studentName;
        public void acceptDetails()
        {
            Console.WriteLine("Enter the student ID: ");
            studentId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student Name: ");
            studentName = Console.ReadLine();
        } 
        public void Display()
        {
            Console.WriteLine("the student ID is " + studentId);
            Console.WriteLine("the student Name is " + studentName);
        }
    }
}
