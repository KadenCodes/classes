namespace product
{
    public class product
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
            product rag = new product();
            product towel = new product();
            Console.WriteLine(towel.name);
            towel.info();
            Console.WriteLine(rag.name);
            rag.info();

        }
    }
}