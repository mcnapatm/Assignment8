// Hello2.cs
using System;

public class GPAClass
{
    public static void Main()
    {
        
        int classTotalAmount;
		string className;
		string letterGrade;
        string creditStr;
        int creditNum;
        double creditDoub;
		int creditTotal = 0;
        double creditTotalDoub;
		double weightValue;
		double weightValueTotal = 0;
		double GPA;
		int x = 0;
		int y = 0;
		string[] LETTERGRADE_ARRAY = {"A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "F"};
        double[] GRADEPOINT_ARRAY = { 4.0, 3.70, 3.30, 3.00, 2.70, 2.30, 2.00, 1.70, 1.30, 1.00, 0.00 };

        classTotalAmount = housekeeping();
        GPAC[] GPACArray = new GPAC[classTotalAmount];
        while (x < classTotalAmount) { 
            if(x == 0)
            {
                Console.WriteLine("Please enter the name of the first class.");
            }
            else if(x == (classTotalAmount - 1))
            {
                Console.WriteLine("Please enter the name of the last class.");
            }
            else
            {
                Console.WriteLine("Please enter the name of the next class.");
            }
            className = Console.ReadLine();
            Console.WriteLine("Please enter the letter grade for this class.");
            letterGrade = Console.ReadLine();
            Console.WriteLine("Please enter the number of credits for this class.");
            creditStr = Console.ReadLine();
            creditNum = Convert.ToInt32(creditStr);
            GPACArray[x] = new GPAC();
            GPACArray[x].setClassName(className);
            GPACArray[x].setLetterGrade(letterGrade);
            GPACArray[x].setCreditNum(creditNum);
            ++x;
        
        }
        x = 0;
        while (x < classTotalAmount)
        {
            className = GPACArray[x].getClassName();
			letterGrade = GPACArray[x].getLetterGrade();
			creditNum = GPACArray[x].getCreditNum();
            Console.WriteLine("Class Name: " + className + " Letter Grade: " + letterGrade + " Credits: " + creditNum);
            while(letterGrade != LETTERGRADE_ARRAY[y]){
                y++;
            }

            creditTotal = creditTotal + creditNum;
            creditDoub = Convert.ToDouble(creditNum);
			weightValue = creditDoub * GRADEPOINT_ARRAY[y];
			weightValueTotal = weightValueTotal + weightValue;
			y = 0;
            x++;
        
        }
        creditTotalDoub = Convert.ToDouble(creditTotal);
        GPA = (weightValueTotal / creditTotalDoub);
        Console.WriteLine("Your total GPA for this semester is "+ GPA);
        Console.WriteLine("Press enter to quit.");
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
            return;
        }
        public void setLetterGrade(string grd)
        {
            letterGrade = grd;
            return;
        }
        public void setCreditNum(int cred)
        {
            creditNum = cred;
            return;
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