﻿using System;

namespace oop
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int x = 3; x < 100; x = x + 3)//小鸡
            { // 小鸡的个数肯定是3的倍数，所以x的变化是已3的倍数递增
                for (int a = 1; a < 20; a++)//公鸡
                {
                    for (int m = 1; m < 33; m++)//母鸡
                    {

                        if (x + a + m == 100 && x / 3 + 5 * a + 3 * m == 100)
                        { // 个数和总价都为100
                            Console.WriteLine("公鸡数量：" + a + "，母鸡数量：" + m + "，小鸡数量：" + x);
                        }
                    }
                }
            }
        }
    }
}
