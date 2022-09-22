using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class Converter
    {
        private readonly double usd;
        private readonly double eur;
        private readonly double rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double ConvertUsd(double money, bool toUsd = true)
        {
            return toUsd ? money / usd : money * usd;
        }
        public double ConvertEur(double money, bool toEur = true)
        {
            return toEur ? money / eur : money * eur;
        }
        public double ConvertRub(double money, bool toRub = true)
        {
            return toRub ? money / rub : money * rub;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(36.57, 0.60, 36.53);

            //Долари $
            Console.WriteLine(converter.ConvertUsd(500));
            Console.WriteLine(converter.ConvertUsd(500, false));
            Console.WriteLine();

            //непотріб
            Console.WriteLine(converter.ConvertRub(500));
            Console.WriteLine(converter.ConvertRub(500, false));
            Console.WriteLine();

            //Євро
            Console.WriteLine(converter.ConvertEur(500));
            Console.WriteLine(converter.ConvertEur(500, false));
            Console.WriteLine();
        }
    }
}
