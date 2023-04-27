using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace grahminBank
{
    class Customer
    {
        public string PhNum { get; set; }
        public int CID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public String Gender { get; set; }
        public String State { get; set; }
        public String Village { get; set; }
        public String Pincode { get; set;}
        public DateTime DateOfBirth { get; set; }

    }

    class grahminBank
    {
        Customer[] c = new Customer[100];
        public void addcustomer()
        {
            Console.WriteLine("Enter the number of people for whom you want to open an account: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter The First Name:");
                string fname = Console.ReadLine();

                Console.WriteLine("Enter the Last Name:");
                string lname = Console.ReadLine();

                Console.WriteLine("Enter the Age:");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Gender: ");
                string Gen = Console.ReadLine();

                Console.WriteLine("Enter the Village: ");
                string village = Console.ReadLine();

                Console.WriteLine("Enter the State: ");
                string state = Console.ReadLine();

                Console.WriteLine("Enter the pincode: ");
                string pcode = Console.ReadLine();

                Console.Write("Date of birth (mm/dd/yyyy): ");
                DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter Phone Number: ");
                string num = Console.ReadLine();
                if(num.Length !=10)
                {
                    Console.WriteLine("Invalid Number!! Enter the number again: ");
                    num = Console.ReadLine();
                }
                int cid = Random();
                Console.WriteLine($"Your Customer ID is {cid}");
                c[i] = new Customer() { PhNum = num, FName = fname, LName = lname, Age =  age, Gender = Gen, State = state, Village = village, Pincode = pcode, DateOfBirth = dateOfBirth, CID= cid };

            }
            Console.WriteLine();
            
        }
        public int Random()
        {
            Random r = new Random();
            int genRand = r.Next(10, 30);
            return genRand;
        }
        public void Showbylname()
        {
            Console.WriteLine("Enter the last name: ");
            String lname = Console.ReadLine();
            foreach (Customer customer in c)
            {
                if (customer.LName == lname)
                {
                    Console.WriteLine($" First Name: {customer.FName}\n Last Name: {customer.LName}\n Age: {customer.Age}\n Gender: {customer.Gender}\n Date of Birth: {customer.DateOfBirth}\n Village: {customer.Village}\n State: {customer.State}\n Pincode: {customer.Pincode}\n Phone Number: {customer.PhNum}\n Customer ID: {customer.CID}");
                }
            }
        }
        public void samevillage() 
        {
            Console.WriteLine("Enter Village Name ");
            string village = Console.ReadLine();
            foreach( Customer customer in c ) 
            {
                if(customer.Village == village)
                {
                    Console.WriteLine($" First Name: {customer.FName}\n Last Name: {customer.LName}\n Age: {customer.Age}\n Gender: {customer.Gender}\n Date of Birth: {customer.DateOfBirth}\n Village: {customer.Village}\n State: {customer.State}\n Pincode: {customer.Pincode}\n Phone Number: {customer.PhNum}\n Customer ID: {customer.CID}");
                }
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            grahminBank bank = new grahminBank();
            Console.WriteLine("Welcome to Grahmin Bank!!");
            Console.WriteLine("Choose the operation you would like to perform:");
            Console.WriteLine("Type 1 for Adding a new customer. ");
            Console.WriteLine("Type 2 for Searching Customer by their last name. ");
            Console.WriteLine("Type 3 for seeing all customers from same village. ");
            int choice = Convert.ToInt32(Console.ReadLine());
            String ch = "y";
            while(ch == "y" || ch == "Y")
            {
                switch(choice)
                {
                    case 1:
                        {
                            bank.addcustomer();
                            break;
                        }
                        case 2:
                        {
                            bank.Showbylname(); 
                            break;
                        }
                        case 3:
                        {
                            bank.samevillage();
                            break;
                        }
                        default:
                        {
                            Console.WriteLine("Invalid Choice!!");
                            break;
                        }
                }
                Console.WriteLine("Would you like to Continue\nType Y for and N for NO");
                ch = Console.ReadLine();
            }
            
        }
    }
}