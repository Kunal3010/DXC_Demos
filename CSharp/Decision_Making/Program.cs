//Age>=18 and qualificaton>=10
Console.WriteLine("Enter your Age");
int age = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter your Qualification");
int qual = Convert.ToInt16(Console.ReadLine());
if(age>=18 && qual>=10)
{
    Console.WriteLine("You are eligible");
}
else
{
    Console.WriteLine("You are not eligible");
}