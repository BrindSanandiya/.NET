/*Write a program to create a class named Candidate with ID, Name, Age, Weight and Height
as data members & also create a member functions like
GetCandidateDetails() and DisplayCandidateDetails(). */

using System;

public class Candidate
{
            int id;
            string name;
            int age;
            double weight;
            double height;

        public void GetCandidateDetails()
        {
        Console.Write("Enter id: ");
        id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter name: ");
        name = Console.ReadLine();
        Console.Write("Enter age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter weight: ");
        weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height: ");
        height = Convert.ToDouble(Console.ReadLine());
        }
        
        public void DisplayCandidateDetails()
        {
            Console.WriteLine($" id: {id}, name {name}, age {age}, weight {weight}, height {height}");
        }

}
