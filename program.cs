
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
        static void Main(){
            Max ();
        }

    }
}
