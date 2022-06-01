using System;

namespace Prima
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bilangan Prima");
            Console.Write("Input angka dari = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input angka sampai = ");
            int y = Convert.ToInt32(Console.ReadLine());
            var hasil = "";
            for (int j = x; j < y; j++)
            {

                int n, i, m = 0, flag = 0;
                n = j;
                m = n / 2;
                for (i = 2; i <= m; i++)
                {
                    if (n % i == 0)
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                    if (hasil == "")
                    {
                        hasil = n.ToString();
                    }
                    else
                    {
                        hasil = hasil + "," + n.ToString();
                    }
            }
            Console.WriteLine("Hasil = " + hasil);



        }


    }
}