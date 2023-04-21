Console.WriteLine("Enter month(Press 1 for Jan, 2 for Feb, 12 for Dec......): ");
int month = Convert.ToUInt16(Console.ReadLine());
Console.WriteLine("Enter Year: ");
int year = Convert.ToUInt16(Console.ReadLine());
Console.WriteLine("Enter Day of week(Press 1 for Mon, 2 for Tue, 7 for Sun......): ");
int day = Convert.ToUInt16(Console.ReadLine());

Console.WriteLine(" \t \t \t Calender  \n ");
Console.WriteLine("S\tM\tTu\tW\tTh\tF\tS\n");

switch (month)
{
    case 1:
        {
            for(int i = 0;i<day;i++)
            {
                Console.Write("\t");
            }
            for(int i = 1;i<=31;i++)
            { Console.Write(i+"\t");
                if((day+i)%7==0)
                    Console.WriteLine("\n");
            }
            break;
        }
    case 2:
        {
            if((year%4==0) && (year%100!=0) || (year%400==0))
            {
                for (int i = 0; i < day; i++)
                {
                    Console.Write("\t");
                }
                for (int i = 1; i <= 29; i++)
                {
                    Console.Write(i + "\t");
                    if ((day + i) % 7 == 0)
                        Console.WriteLine("\n");
                }
            }
            else
            {
                for (int i = 0; i < day; i++)
                {
                    Console.Write("\t");
                }
                for (int i = 1; i <= 28; i++)
                {
                    Console.Write(i + "\t");
                    if ((day + i) % 7 == 0)
                        Console.WriteLine("\n");
                }
            }
            break;

        }
    case 3:
        {
            for (int i = 0; i < day; i++)
            {
                Console.Write("\t");
            }
            for (int i = 1; i <= 31; i++)
            {
                Console.Write(i + "\t");
                if ((day + i) % 7 == 0)
                    Console.WriteLine("\n");
            }
            break;
        }
    case 4:
        {
            for (int i = 0; i < day; i++)
            {
                Console.Write("\t");
            }
            for (int i = 1; i <= 30; i++)
            {
                Console.Write(i + "\t");
                if ((day + i) % 7 == 0)
                    Console.WriteLine("\n");
            }
            break;
        }
    case 5:
        {
            for (int i = 0; i < day; i++)
            {
                Console.Write("\t");
            }
            for (int i = 1; i <= 30; i++)
            {
                Console.Write(i + "\t");
                if ((day + i) % 7 == 0)
                    Console.WriteLine("\n");
            }
            break;
        }
    case 6:
        {
            for (int i = 0; i < day; i++)
            {
                Console.Write("\t");
            }
            for (int i = 1; i <= 31; i++)
            {
                Console.Write(i + "\t");
                if ((day + i) % 7 == 0)
                    Console.WriteLine("\n");
            }
            break;
        }
    case 7:
        {
            for (int i = 0; i < day; i++)
            {
                Console.Write("\t");
            }
            for (int i = 1; i <= 31; i++)
            {
                Console.Write(i + "\t");
                if ((day + i) % 7 == 0)
                    Console.WriteLine("\n");
            }
            break;
        }
    case 8:
        {
            for (int i = 0; i < day; i++)
            {
                Console.Write("\t");
            }
            for (int i = 1; i <= 31; i++)
            {
                Console.Write(i + "\t");
                if ((day + i) % 7 == 0)
                    Console.WriteLine("\n");
            }
            break;
        }
    case 9:
        {
            for (int i = 0; i < day; i++)
            {
                Console.Write("\t");
            }
            for (int i = 1; i <= 30; i++)
            {
                Console.Write(i + "\t");
                if ((day + i) % 7 == 0)
                    Console.WriteLine("\n");
            }
            break;
        }
    case 10:
        {
            for (int i = 0; i < day; i++)
            {
                Console.Write("\t");
            }
            for (int i = 1; i <= 31; i++)
            {
                Console.Write(i + "\t");
                if ((day + i) % 7 == 0)
                    Console.WriteLine("\n");
            }
            break;
        }
    case 11:
        {
            for (int i = 0; i < day; i++)
            {
                Console.Write("\t");
            }
            for (int i = 1; i <= 30; i++)
            {
                Console.Write(i + "\t");
                if ((day + i) % 7 == 0)
                    Console.WriteLine("\n");
            }
            break;
        }
    case 12:
        {
            for (int i = 0; i < day; i++)
            {
                Console.Write("\t");
            }
            for (int i = 1; i <= 31; i++)
            {
                Console.Write(i + "\t");
                if ((day + i) % 7 == 0)
                    Console.WriteLine("\n");
            }
            break;
        }
    default: 
        {
            Console.WriteLine("You have Entered a Wrong choice");
            break;
        }
}
