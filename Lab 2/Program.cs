using System;
public class Program
{
    public static void Main(String[] args)
    {
        Console.Write("Enter number of code to run: ");
        int N = int.Parse(Console.ReadLine());
        if (N == 1) 
        {
            Candidate n = new Candidate();
            n.GetCandidateDetails();
            n.DisplayCandidateDetails();
        }
    }
}