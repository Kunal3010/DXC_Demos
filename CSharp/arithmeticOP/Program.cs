Console.WriteLine("Enter First Number: ");
int a = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter Second Number: ");
int b = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Enter the Operator :");

char ch = Convert.ToChar(Console.ReadLine());

switch(ch)
{
    case '+' :
    {
       Console.WriteLine("Result is "+ (a+b));
       break; 
    }
    case '-' :
    {
       Console.WriteLine("Result is "+ (a-b));
       break; 
    }
    case '*' :
    {
       Console.WriteLine("Result is "+ (a*b));
       break; 
    }
    case '/' :
    {
       Console.WriteLine("Result is "+ (a/b));
       break; 
    }
    case '%' :
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

