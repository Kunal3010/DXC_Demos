Console.WriteLine("Enter StudentID ");
int id = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Student Name ");
String name = Console.ReadLine();
Console.WriteLine("Enter Student Age ");
int age = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Marks 1 ");
int mark1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Marks 2 ");
int mark2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Marks 3 ");
int mark3 = Convert.ToInt16(Console.ReadLine());

int total = mark1+mark2+mark3;

Console.WriteLine("Your Total Score is " + total);
int percentage = total/3;
Console.WriteLine("Your Total Average Score is " + percentage);
String Grade;
if(percentage>=90 && percentage<=100)
{
    Grade = "A";
    Console.WriteLine("Your Total Grade is "+Grade);
    Console.WriteLine("Your Result for the exam is PASS");
}
else if(percentage>=80 && percentage<=89)
{
    Grade = "B";
    Console.WriteLine("Your Total Grade is "+Grade);
    Console.WriteLine("Your Result for the exam is PASS");
}
else if(percentage>=60 && percentage<=79)
{
    Grade = "C";
    Console.WriteLine("Your Total Grade is "+Grade);
    Console.WriteLine("Your Result for the exam is PASS");
}
else if(percentage>=50 && percentage<=59)
{
    Grade = "D";
    Console.WriteLine("Your Total Grade is "+Grade);
    Console.WriteLine("Your Result for the exam is PASS");
}
else
{
    Grade = "E";
    Console.WriteLine("Your Total Grade is "+Grade);
    Console.WriteLine("Your Result for the exam is FAIL");
}




