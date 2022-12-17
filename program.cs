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
    

        static void Main(){
            Max();
            TripleMax();
        }

    }
}