namespace SimpleRecursion
{
    internal class Program
    {
        public static void RightTrangle(int x)
        {
            if(x < 0)
            {
                return;
            }

            RightTrangle(x - 1);
            while(x>0)
            {
                Console.Write("* ");
                x--;
            }
            Console.WriteLine();
        }

        public static void IsocelesTriangle(int maxLevel, int currLevel = 0)
        {
            if(currLevel > maxLevel)
            {
                return;
            }
 
            int spaces = (((maxLevel *2)+1) / 2) - currLevel;
            int stars = 1 + (currLevel * 2);

            while(spaces > 0)
            {
                Console.Write("  ");
                spaces--;
            }
            while(stars > 0)
            {
                Console.Write("* ");
                stars--;
            }
            Console.WriteLine();

            IsocelesTriangle(maxLevel, currLevel + 1);
        }
        public static void Main(string[] args)
        {
            RightTrangle(5);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            IsocelesTriangle(5);
        }
    }
}
