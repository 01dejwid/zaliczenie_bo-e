namespace Zaliczenie
{
    public static class UserAction
    {
        public static int Get0or1()
        {
            while (true)
            {
                var key = Console.ReadKey();
                Console.WriteLine();
                if (key.KeyChar == '0')
                    return 0;
                if (key.KeyChar == '1')
                    return 1;
                Console.WriteLine("Incorrect data. Try again.");
            }
        }
    }
}