using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.Hospital
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Department> departments = new List<Department>();
            List<Doctor> doctors = new List<Doctor>();
            Room room = new Room();
            while ((input=Console.ReadLine())!="Output")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string departmentName = inputArgs[0];
                string doctorName = inputArgs[1] + " " + inputArgs[2];
                string patientName = inputArgs[3];
                Patient patient = new Patient(patientName);
                Department dep = new Department(departmentName);
                if (!departments.Any(x=>x.Name==departmentName))
                {
                    departments.Add(dep);
                    for (int i = 0; i < dep.Rooms.Length; i++)
                    {
                        dep.Rooms[i] = new Room();
                    }
                }
                var currentDep = departments.FirstOrDefault(x => x.Name == departmentName);
                for (int i = 0; i < currentDep.Rooms.Length; i++)
                {
                    if (!currentDep.Rooms[i].isFull)
                    {
                        currentDep.Rooms[i].Patients.Add(patient);
                        break;
                    }
                }
                Doctor doctor = new Doctor(doctorName);
                if (!doctors.Any(x=>x.Name==doctorName))
                {
                    doctors.Add(doctor);
                }
                else
                {
                    doctor = doctors.FirstOrDefault(x => x.Name == doctorName);
                }
                doctor.Patients.Add(patient);

            }
            while ((input=Console.ReadLine())!="End")
            {
                string[] inputArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var name = inputArgs[0];
                if (inputArgs.Length==2)
                {
                    bool isDigit = int.TryParse(inputArgs[1], out int roomIndex);
                    if (isDigit)
                    {
                        var currDep = departments.FirstOrDefault(x => x.Name == name);
                        foreach (var patient in currDep.Rooms[roomIndex - 1].Patients.OrderBy(x => x.Name))
                        {
                            Console.WriteLine(patient.Name);
                        }
                    }
                    else
                    {

                        var doc = doctors.FirstOrDefault(x => x.Name == input);
                        foreach (var patient in doc.Patients.OrderBy(x=>x.Name))
                        {
                            Console.WriteLine(patient.Name);
                        }
                    }
                }
                else
                {
                    
                    var dep = departments.FirstOrDefault(x => x.Name == name);
                    foreach (var rooms in dep.Rooms)
                    {
                        foreach (var patient in rooms.Patients)
                        {
                            Console.WriteLine(patient.Name);
                        }
                    }
                    
                }
            }
        }
    }
}
