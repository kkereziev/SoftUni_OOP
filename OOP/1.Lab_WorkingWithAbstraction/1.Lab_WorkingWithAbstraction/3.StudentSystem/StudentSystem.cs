using _3.StudentSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03_StudentSystem
{
    public class StudentSystem
    {
        private StudentsDatabase students;
        public StudentSystem()
        {
            this.students = new StudentsDatabase();
        }
        public void ParseCommands()
        {
            while (true)
            {
                string[] args = Console.ReadLine().Split();
                string command = args[0];
                if (command == "Create")
                {
                    this.Create(args);
                }
                else if (command == "Show")
                {
                    this.Show(args);
                }
                else if (command == "Exit")
                {
                    return;
                }
            }
        }

        private void Show(string[] args)
        {
            var name = args[1];
            Student student=this.students.Find(name);
            if (student!=null)
            {
                Console.WriteLine(student);
            }
        }

        private void Create(string[] args)
        {
            var name = args[1];
            var age = int.Parse(args[2]);
            var grade = double.Parse(args[3]);
            this.students.Add(name,age,grade); 
        }
    }
}
