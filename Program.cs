namespace ConsoleApp14
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Amount ?");
           
            double amount = Convert.ToDouble(Console.ReadLine());
            ShowMoney currency = Euros;
            currency(amount);
            currency = Dollars;
            currency(amount);
        }

        public delegate void ShowMoney(double amount);

        public static void Euros(double amount)
        {
            Console.WriteLine(amount + "€");
        }

        public static void Dollars(double amount)
        {
            Console.WriteLine(amount + "$");
        }
    }
}
