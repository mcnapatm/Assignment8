// Hello2.cs
using System;

public class classGPA
{
    public static void Main()
    {
        
        int classTotalAmount;
		string className;
		string letterGrade;
		int creditint;
		int creditTotal = 0;
		int weightValue;
		int weightValueTotal = 0;
		int GPA;
		int SIZE = 10;
		int x = 0;
		int y = 0;
		string[] LETTERGRADE_ARRAY = {"A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "F"};
        double[] GRADEPOINT_ARRAY = { 4.0, 3.70, 3.30, 3.00, 2.70, 2.30, 2.00, 1.70, 1.30, 1.00, 0.00 };

        classTotalAmount = housekeeping();
        Console.WriteLine(classTotalAmount);
        Console.ReadLine();


    }
    public static int housekeeping()
    {
        string classTotalAmount;
        Console.WriteLine("This is a program that is used to determine the GPA for the current semester.");
        Console.WriteLine("Please enter the number of classes in the semseter.");
        Console.WriteLine("It should be a number in between 1 and 6.");
        classTotalAmount = Console.ReadLine();
        int classTotalNum = Convert.ToInt32(classTotalAmount);

        return classTotalNum;
    }
}