using P03_StudentSystem;
using System;

namespace StartUp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentSystem studentSystem = new StudentSystem();
            studentSystem.ParseCommands();
        }
    }
}
