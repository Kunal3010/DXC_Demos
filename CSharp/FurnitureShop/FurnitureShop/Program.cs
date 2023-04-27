namespace FurnitureShop
{
    class Furniture
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public string Color { get; set; }
        public int Qty { get; set; }
        public double Price { get; set; }

        public void Acceptdetail()
        {
            Console.Write("Enter height: ");
            Height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter width: ");
            Width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter color: ");
            Color = Console.ReadLine();

            Console.Write("Enter quantity: ");
            Qty = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter price: ");
            Price = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Height: " + Height);
            Console.WriteLine("Width: " + Width);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Quantity: " + Qty);
            Console.WriteLine("Price: " + Price);
        }

    }
    class BookShelf : Furniture
    {
        public int NoOfShelves { get; set; }
        public void Accept()
        {
            base.Acceptdetail();
            Console.Write("Enter number of shelves: ");
            NoOfShelves = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            base.DisplayDetails();
            Console.WriteLine("Number of shelves: " + NoOfShelves);
        }
    }
    class DiningTable : Furniture
    {
        public int NoOfLegs { get; set; }
        public void Accept()
        {
            base.Acceptdetail();
            Console.Write("Enter number of legs: ");
            NoOfLegs = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            base.DisplayDetails();
            Console.WriteLine("Number of legs: " + NoOfLegs);
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            BookShelf bookshelf = new BookShelf();
            DiningTable table = new DiningTable();
            Console.WriteLine("Which Furniture Would you like to buy");
            Console.WriteLine("Type 1 for BookShelf \nType 2 for Dinning Table");
            int choice = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            while (x == 0)
            {
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Welcome to BookShelf Section");
                            bookshelf.Accept();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Welcome to Dining Table Section");
                            table.Accept();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice");
                            break;
                        }
                }
                Console.WriteLine("Would you like to continue");
                Console.WriteLine("Press 0 to Continue\nPress 1 to exit");
                x = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}