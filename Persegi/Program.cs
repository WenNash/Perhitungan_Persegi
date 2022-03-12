using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persegi
{
    class Woke
    {
        /// <summary>
        /// ini method main
        /// </summary>
        /// <param name="args"></param>
        double panjang, lebar;
        public void Masukkandata()
        {
            Console.Write("Masukkan Panjang: ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan lebar: ");
            lebar = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// ini method untuk menghitung luas
        /// </summary>
        /// <param name="p">variabel untuk bilangan panjang</param>
        /// <param name="l">variabel untuk bilangan lebar</param>
        /// <returns></returns>
        public double hitungluas(double p, double l)
        {
            return panjang * lebar;
        }

        public double luasp(double p, double l)
        {
            return p * l;
        }
        static void Main(string[] args)
        {
            Woke pp = new Woke();
            pp.Masukkandata();
            //pp.Tampil();
            Console.Write("Luas Persegi = {0}", pp.luasp(pp.panjang, pp.lebar));
            Console.ReadKey();
        }
    }
}
