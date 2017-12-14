using System;

namespace HomeExpenses.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var bootstraper = new Bootstraper())
            {
                bootstraper.Bootstrap();
                Console.ReadKey();
            }
        }
    }
}
