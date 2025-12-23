using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2Function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = GetNumber();
            ShowResult(number);
        }
        static int[] GetNumber()
        {
            Console.WriteLine("ใส่จำนวนตัวเลขที่ต้องการหา: ");
            int n = int.Parse(Console.ReadLine());

            int[] number = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"ตัวเลขตัวที่ {i + 1}: ");
                number[i] = int.Parse(Console.ReadLine());
            }
            return number;
        }
        static void ShowResult(int[] number)
        {
            Console.WriteLine("\n=== ผลลัพธ์การคำนวณ ===");

            double avg = number.Average();
            int max = number.Max();
            int min = number.Min();

            var sorted = number.OrderBy(x => x).ToArray();
            double median;

            if (sorted.Length % 2 == 1)
                median = sorted[sorted.Length / 2];
            else
                median = (sorted[(sorted.Length / 2) - 1] + sorted[sorted.Length / 2]) / 2.0;

            Console.WriteLine($"ค่าเฉลี่ย: {avg}");
            Console.WriteLine($"ค่าสูงสุด: {max}");
            Console.WriteLine($"ค่าต่ำสุด: {min}");
            Console.WriteLine($"ค่ากลางข้อมูล: (Median): {median}");

            Console.WriteLine("เรียงจากมากไปน้อย: " + string.Join(", ", number.OrderByDescending(x => x)));
            Console.WriteLine("เรียงจากน้อยไปมาก: " + string.Join(", ", number.OrderBy(x => x)));

        }
    }
}