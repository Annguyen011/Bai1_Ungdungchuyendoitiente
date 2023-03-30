using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_Ungdungchuyendoitiente
{
    class Program
    {
        static void Main(string[] args)
        {
            double vnd, usd;
            const int tiGia = 23000;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine($"Tỉ giá hiện tại giữ VND và USD là 1 USD = {tiGia} VND");
            Console.Write("Mời nhập giá tiền USD = ");
            usd = double.Parse(Console.ReadLine());
            vnd = usd * tiGia;
            Console.WriteLine($"Giá VND là : {vnd}");
            Console.ReadLine();

        }
    }
}
