using BaiTap1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap1
{
    class NotNegativeException : Exception
    {
        public NotNegativeException()
            : base("Gia tri trong can phai lon hon hoac bang 0")
        {
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Nhap x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Nhap y: ");
            int y = int.Parse(Console.ReadLine());

            int mau = 2 * x - y;

            if (mau == 0)
                throw new DivideByZeroException();

            double trongcan = (double)(3 * x + 2 * y) / mau;
                if(trongcan<0) throw new DivideByZeroException();

            double H = Math.Sqrt(trongcan);

            Console.WriteLine("H= " + H);
        }
        catch (FormatException)
        {
            Console.WriteLine("loi: Vui long nhap so nguyen hop le");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Loi: Mau so bang 0");
        }
        catch (NotNegativeException ex)
        {
            Console.WriteLine("Loi: " + ex.Message);
        }
    }
}
