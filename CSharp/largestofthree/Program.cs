int num1, num2, num3;
Console.WriteLine("Write First Number ");
num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Write Second Number ");
num2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Write Third Number ");
num3 = Convert.ToInt16(Console.ReadLine());
if(num1>num2)
{
    if(num1>num3)
    {
        Console.WriteLine("First number is Greatest");
    }
    else{
        Console.WriteLine("Third number is greatest");
    }  
}
else if(num2>num3)
{
        Console.WriteLine("Second number is Greatest"); 
}
else
{
    Console.WriteLine("Third Number is Greatest");
}