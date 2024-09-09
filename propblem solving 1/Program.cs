
using System.Reflection.Metadata.Ecma335;

namespace propblem_solving_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            long x = 0, y = 0;
            string[] nums = Console.ReadLine().Split(' ');
            x = long.Parse(nums[0]);
            y = long.Parse(nums[1]);
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} - {y} = {x - y}");


            long a = 0, b = 0, c = 0, d = 0;
            string[] nums2 = Console.ReadLine().Split(' ');
            a = long.Parse(nums2[0]);
            b = long.Parse(nums2[1]);
            c = long.Parse(nums2[2]);
            d = long.Parse(nums2[3]);
            Console.WriteLine($"Difference = {(a * b) - (c * d)}");



            double R = 0;
            double pi = 3.141592653;
            R = double.Parse(Console.ReadLine());
            Console.WriteLine(pi * R * R);



            string m = "", n = "";
            string[] nums3 = Console.ReadLine().Split(' ');
            m = (nums3[0]);
            n = (nums3[1]);
            char lastDigitCharm = m[m.Length - 1];
            char lastDigitCharN = n[n.Length - 1];
            long lastDigitM = long.Parse(lastDigitCharm.ToString());
            long lastDigitn = long.Parse(lastDigitCharN.ToString());
            Console.WriteLine(lastDigitM + lastDigitn);






        }
    }
}
