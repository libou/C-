//求解稀疏数，特点：左移一位与原数与运算结果得0
using System;

namespace XiShuShu   //求大于或等于n的第一个稀疏数（二进制表示没有相邻的1）
{
    class Program
    {
        public static void  Main()
        {
          Console.Write("请输入数字n");
          int n=Convert.ToInt32(Console.ReadLine());
          for(;;n++)
          {
            if(((n<<1)&n)==0)
            {
              Console.WriteLine(n);
              break;
            }
          }
        }
    }
}