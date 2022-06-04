namespace product
{
    public class prod2
    {
        public string name = "rag";
        string price = "19.99";
        int id = 2;
        int oh = 12;
        public void info()
        {
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Ammount on hand: {oh}");
        }
    }
    public class prod1
    {
        public string name = "towel";
        public string price = "10.99";
        public int id = 1;
        public int oh = 11;
        public void info()
        {
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Ammount on hand: {oh}");
        }
        public static void Main(string[] args)
        {
            prod2 rag = new prod2();
            prod1 towel = new prod1();
            Console.WriteLine(towel.name);
            towel.info();
            Console.WriteLine(rag.name);
            rag.info();

        }
    }
}