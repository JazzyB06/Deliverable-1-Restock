namespace RestockInventoryItems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Restocking Tool");
            Console.WriteLine();
            int sodastock = 100;
            int sodarestock = 40;
            Console.WriteLine("How many sodas have been sold today? 100 are in stock");
            int sodassold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("There are " + (sodastock - sodassold) + " sodas left");
            sodastock = sodastock - sodassold;
            Console.WriteLine();


            Console.WriteLine("How many Chips have been sold today? 40 are in stock");
            int chipssold = Convert.ToInt32(Console.ReadLine());
            int chipsstock = 40;
            int chipsrestock = 20;
            Console.WriteLine("There are " + (chipsstock - chipssold) + " chips left");
            chipsstock = chipsstock - chipssold;
            Console.WriteLine();

            Console.WriteLine("How much candy have been sold today? 60 are in stock");
            int candysold = Convert.ToInt32(Console.ReadLine());
            int candystock = 60;
            int candyrestock = 20;
            Console.WriteLine("There are " + (candystock - candysold) + " candies left");
            candystock = candystock - candysold;
            Console.WriteLine();

            Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.");
            Console.WriteLine();
            //The following if statements will run if the item needs to be restocked.//
            if (sodastock <= sodarestock)
            {
                Console.WriteLine("Sodas needs to be restocked");
                Console.WriteLine();
            }
            if (chipsstock <= chipsrestock)
            {
                Console.WriteLine("Chips needs to be restocked");
                Console.WriteLine();
            }
            if (candystock <= candyrestock)
            {
                Console.WriteLine("Candies needs to be restocked");
                Console.WriteLine();
            }
            //The following if statements will run if the user input is higher than the stock.//
            if (candysold >= candystock)
            {
                Console.WriteLine("That value is too high. Candy stock not adjusted ");
                Console.WriteLine();
            }

            if (chipssold >= chipsstock)
            {
                Console.WriteLine("That value is too high. Chips stock not adjusted");
                Console.WriteLine();
            }
            if (sodassold >= sodastock)
            {
                Console.WriteLine("That value is too high. Soda stock not adjusted");
                Console.WriteLine();
            }


        }
    }
}
