/*Write a program to create a class Staff having data members as Name, Department,Designation, Experience & Salary.
Accept this data for 5 different staffs and display only names & salary of those staff who are HOD. */
using System;

namespace LAB2
{
    using System;

    namespace StaffDetails
    {
        class Staff
        {
            string Name;
            string Department;
            string Designation;
            int Experience;
            double Salary;


            public Staff(string name, string department, string designation, int experience, double salary)
            {
                Name = name;
                Department = department;
                Designation = designation;
                Experience = experience;
                Salary = salary;
            }


            public void DisplayIfHOD()
            {
                if (Designation.ToUpper() == "HOD")
                {
                    Console.WriteLine($"Name: {Name}, Salary: {Salary}");
                }
            }
        }
    }

}