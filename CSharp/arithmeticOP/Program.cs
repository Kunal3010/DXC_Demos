Console.WriteLine("Enter First Number: ");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Second Number: ");
int b = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the Operator Number :");
Console.WriteLine("1 - Addition");
Console.WriteLine("2 - Subtraction");
Console.WriteLine("3 - Multiplication");
Console.WriteLine("4 - Division");
Console.WriteLine("5 - Modulus");

int ch = Convert.ToInt16(Console.ReadLine());

switch(ch)
{
    case 1 :
    {
       Console.WriteLine("Result is "+ (a+b));
       break; 
    }
    case 2 :
    {
       Console.WriteLine("Result is "+ (a-b));
       break; 
    }
    case 3 :
    {
       Console.WriteLine("Result is "+ (a*b));
       break; 
    }
    case 4 :
    {
       Console.WriteLine("Result is "+ (a/b));
       break; 
    }
    case 5 :
    {
       Console.WriteLine("Result is "+ (a%b));
       break; 
    }
    default:
    {
        Console.WriteLine("Wrong Choice");
        break;
    }
}

