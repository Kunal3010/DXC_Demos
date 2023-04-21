Console.WriteLine("Sr.No   Temperature(Celcius)   Temperature(Fahrenheit)");
for (int i = 0; i <10; i++)
{
    int c = i * 10;
    int f = ((int)((c * 1.8) + 32));
    Console.WriteLine(i+"        "+c + "                     " + f);
}