using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int a=random.Next(0, 1000);
            int b=0;
            
            do{
                Console.Write("숫자를 입력해주세요:");
                b=int.Parse(Console.ReadLine());

                if (a > b)
                    Console.WriteLine(b + "보다는 큰 숫자입니다.\n");
                else if (a < b)
                    Console.WriteLine(b + "보다는 작은 숫자입니다.\n");
                else
                    Console.WriteLine("정답입니다!\n");
            } while (a != b) ;
        }
    }
}
