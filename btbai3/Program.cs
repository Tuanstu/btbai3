using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btbai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Bai 1
            //Console.Write("Nhap so nguyen A: ");
            //int a = int.Parse(Console.ReadLine());
            //string str = "ko chia het";
            //if (a % 3 == 0)
            //{
            //    str = "chia het";
            //}
            //Console.WriteLine("so nguyen A {0} cho 3", str);


            ////Bai 2
            //Console.Write("Nhap so nguyen B: ");
            //int b = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= b; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} x {j}= {i * j}");
            //    }
            //}

            ////Bai 3
            //Console.Write("Nhap so nguyen C: ");
            //int c = int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 0; i <= c; i++)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine(sum);

            ////Bai 4
            //Console.Write("Nhap vao so nguyen D: ");
            //int d = int.Parse(Console.ReadLine());
            //string str1 = "ko la so chinh phuong";
            //if(Math.Sqrt(d) % 1 == 0)
            //{
            //    str1 = "la so chinh phuong";
            //}
            //Console.WriteLine("So nguyen D {0}", str1);

            ////Bai 5

            //    Console.Write("Nhap so thang E: ");
            //    int e = int.Parse(Console.ReadLine());
            //    switch (e)
            //    {
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            Console.WriteLine($"Thang {e} co 30 ngay");
            //            break;
            //        case 2:
            //            Console.WriteLine($"Thang {e} co 28 hoac 29 ngay");
            //            break;
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            Console.WriteLine($"Thang {e} co 31 ngay");
            //            break;
            //        default:
            //            Console.WriteLine("Thang ko ton tai");
            //            break;
            //    }

            ////Bai 6
            ////Cach 1
            // Console.Write("Nhap so nguyen F: ");
            // int f = int.Parse(Console.ReadLine());
            // int sum3 = 0;

            // for (int i = 1; i <= f; i++)
            // {
            //     sum3 = (int)Math.Pow(i, i) + sum3;

            // }
            // Console.WriteLine(sum3);

            ////Cach 2
            // Console.Write("Nhap so nguyen G: ");
            // int g = int.Parse(Console.ReadLine());
            // int sum4 = 1;
            // int sum5 = 0;
            // for (int j = 1; j <= g; j++)
            // {
            //     for (int i = 1; i <= j; i++)
            //     {
            //         sum4 = j * sum4;
            //     }
            //     Console.WriteLine(sum4);
            //     sum5 = sum4 + sum5;
            //     sum4 = 1;         
            // }
            // Console.WriteLine(sum5);


            ////Bai 7
            //Console.Write("Nhap so nguyen H: ");
            //int h = int.Parse(Console.ReadLine());
            //int sum6 = 0;
            //for(int i = 1; i <= h; i=i+2)
            //{
            //    sum6 += i;
            //}
            //Console.WriteLine(sum6);

            ////Bai8 
            //Console.Write("Nhap so nguyen k: ");
            //int k = int.Parse(Console.ReadLine());

            //for (int i = 2; i <= k; i++)
            //{
            //  for(int j =1;
            //        j<= i; j++)
            //    {
            //        if(i%j ==0 && j !=1 && j != i)
            //        {
            //            Console.WriteLine(i);
            //            break;
            //        }

            //    }

            //}

            ////Bai 9 
            //Console.Write("Nhap so hang L: ");
            //int l = int.Parse(Console.ReadLine());
            //string sao = "";
            //    for(int i = 1; i <= l; i++)
            //    {
            //        sao = sao + "*";
            //        Console.WriteLine(sao);
            //    }

            ////Tam giac nguoc
            //Console.Write("Nhap so hang Z: ");
            //int hang = int.Parse(Console.ReadLine());
            //string tgiacnguoc = "";
            //for(int j = hang; j >=0; j--)
            //{
            //    for (int i = 1; i <= j; i++)
            //    {
            //        tgiacnguoc = tgiacnguoc + "*";
            //    }
            //    Console.WriteLine(tgiacnguoc);
            //    tgiacnguoc = "";
            //}

            ////Bai 10
            //Console.Write("Nhap so nguyen n: ");
            //int n = int.Parse(Console.ReadLine());
            //int f1 = 0;
            //int f2 = 1;
            //int f3 = 0;
            //Console.WriteLine(f1);
            //Console.WriteLine(f2);
            //for (int k = 3; k <= n; k++)
            //{
            //    f3 = f2 + f1;   
            //    f1 = f2;
            //    f2 = f3;

            //    Console.WriteLine(f3);
            //}

            Console.ReadKey();
        }
    }
}

