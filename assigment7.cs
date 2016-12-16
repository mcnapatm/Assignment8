// Hello2.cs
using System;

public class GPAClass
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
        GPAC[] GPACArray; 

        classTotalAmount = housekeeping();
        GPACArray = new GPAC[classTotalAmount];
        while (x <= classTotalAmount) { 
            if(x == 0)
            {
                Console.WriteLine("Please enter the name of the first class.");
            }
            else if(x == classTotalAmount)
            {
                Console.WriteLine("Please enter the name of the last class.");
            }
            else
            {
                Console.WriteLine("Please enter the name of the next class.");
            }
            ++x;
        
        }



    }
    public static int housekeeping()
    {
        string classTotalAmount;
        Console.WriteLine("This is a program that is used to determine the GPA for the current semester.");
        Console.WriteLine("Please enter the number of classes in the semseter.");
        Console.WriteLine("It should be a number in between 1 and 6.");
        classTotalAmount = Console.ReadLine();
        int classTotalNum = Convert.ToInt32(classTotalAmount);
        while ((classTotalNum < 1) | (classTotalNum > 6))
        {
            if (classTotalNum < 1) {
                Console.WriteLine("That is too few classes. Please enter a number between 1 and 6.");
                classTotalAmount = Console.ReadLine();
                classTotalNum = Convert.ToInt32(classTotalAmount);
            }
            else if (classTotalNum > 6) {
                Console.WriteLine("That is many few classes. Please enter a number between 1 and 6.");
                classTotalAmount = Console.ReadLine();
                classTotalNum = Convert.ToInt32(classTotalAmount);
            }
        
            }


        return classTotalNum;
    }
    public class GPAC{

        private string className;
		private string letterGrade;
		private int creditNum;

        public void setClassName(string cName)
        {
            className = cName;
        }
        public void setLetterGrade(string grd)
        {
            letterGrade = grd;
        }
        public void setCreditNum(int cred)
        {
            creditNum = cred;
        }
        public string getClassName()
        {

            return className;
        }
        public string getLetterGrade()
        {

            return letterGrade;
        }
        public int getCreditNum()
        {
            return creditNum;
        }
    
    
    
    }
}