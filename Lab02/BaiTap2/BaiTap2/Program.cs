using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int N = 50;
            List<int> ml = new List<int>();
            Random rnd = new Random((int)DateTime.Now.Ticks);

            for (int i = 0; i < N; i++)
            {
                ml.Add(rnd.Next(100));
                Console.Write(ml[i] + " ");
            }

            // Sap xep day so tang dan
            for (int i = 0; i < ml.Count - 1; i++)
            {
                for (int j = i + 1; j < ml.Count; j++)
                {
                    if (ml[i] > ml[j])
                    {
                        int tam = ml[i];
                        ml[i] = ml[j];
                        ml[j] = tam;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Day so sau khi sap xep tang dan:");

            for (int i = 0; i < ml.Count; i++)
            {
                Console.Write(ml[i] + " ");
            }
        }
    }
}
