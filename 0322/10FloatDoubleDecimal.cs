using System;


namespace Basic
{
    class Basic
    {
        static void Main(string[] args)
        {
            {
                {
                    Console.WriteLine("{0:N2}", 1234.5678); // 출력: 1,234.57
                    Console.WriteLine("{0:D8}", 1234); // 출력: 00001234 
                    Console.WriteLine("{0:F3}", 1234.56); // 출력: 1234.560
                    Console.WriteLine("{0,8}", 1234); // 출력: ____1234
                    Console.WriteLine("{0,-8}", 1234); // 출력: 1234____
                    string s;
                    s = string.Format("{0:N2}", 1234.5678);
                    Console.WriteLine(s);
                    s = string.Format("{0:D8}", 1234);
                    Console.WriteLine(s);
                    s = string.Format("{0:F3}", 1234.56);
                    Console.WriteLine(s);


                }


            }
        }
    }
}
