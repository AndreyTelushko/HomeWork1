namespace Geek_Brains_Lessons
{
    public static class Lesson1
    {
        public static void Max()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine($"{a} its max");
            }
            else
            {
                Console.WriteLine($"{b} its max");
            }
        }
        public static void TripleMax()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a>b & a>c)
            {
                Console.WriteLine($"{a} its max");
            }
            else if (b>a & b>c)
            {
                Console.WriteLine($"{b} its max");
            }
            else if (c>a &c>b)
            {
                Console.WriteLine($"{c} its max");
            }
        }
    
        public static void Divide() 
        {
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} its even");
            }
            else
            {
                Console.WriteLine($"{a} is not even");
            }      
        }
        public static void ItsEven()
        {
            int a = int.Parse(Console.ReadLine());
            for(int i = 1; i <= a; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void Main(){
            Max();
            TripleMax();
            Divide();
            ItsEven();
        }

    }
}


