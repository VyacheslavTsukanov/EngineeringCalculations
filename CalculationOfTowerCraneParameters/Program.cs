using System;

namespace CalculationOfTowerCraneParameters
{
    class Program
    {
        private static decimal craneLoadCapacity(decimal mэ, decimal mc, decimal mo)
        {
            // Q=mэ+mc+mo (т)
            return mэ + mc + mo;

        }

        private static decimal hookLiftingHeight(decimal h0, decimal h3, decimal hэ, decimal hc)
        {
            // Hкр = h0 + h3 + hэ + hc(м)
            return h0 + h3 + hэ + hc;

        }

        static void Main(string[] args)
        {
            // 1. Проектирование, конструирование и расчет механизмов мостовых кранов

            /*
             * 1 Определяем требуемую грузоподъемность крана:
             * Q=mэ+mc+mo (т),
             * где 
             * mэ - масса монтируемого элемента, т
             * mс – масса захватного приспособления (строповки), т.
             * mo – масса установленной на нем оснастки, т
             * 
             */

            decimal mэ, mс, mo;

            Console.WriteLine("Определяем требуемую грузоподъемность крана");
            Console.Write("Введите массу монтируемого элемента: ");
            mэ = decimal.Parse(Console.ReadLine());
            Console.Write("Введите массу захватного приспособления (строповки): ");
            mс = decimal.Parse(Console.ReadLine());
            Console.Write("Введите массу установленной на нем оснастки: ");
            mo = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Требуемая грузоподъемность крана: " + craneLoadCapacity(mэ, mс, mo) + " t");

            /*
             * 2 Определяем требуемую высоту подъема крюка: 
             * Hкр = h0 + h3 + hэ + hc(м)
             * где h0 – превышение опоры монтируемого элемента над уровнем стоянки крана, м;
             * hз – запас по высоте, требующийся по условиям монтажа для заводки конструкции к месту установки или переноса ее через ранее смонтированные конструкции (не менее 0,5м), м;
             * hэ – высота элемента в монтируемом положении, м;
             * hс – высота строповки, м.
             * 
             */

            decimal h0, h3, hэ, hc;

            Console.WriteLine("Определяем требуемую высоту подъема крюка");
            Console.Write("Введите массу превышение опоры монтируемого элемента над уровнем стоянки крана: ");
            h0 = decimal.Parse(Console.ReadLine());
            Console.Write("Введите запас по высоте: ");
            h3 = decimal.Parse(Console.ReadLine());
            Console.Write("Введите высоту элемента в монтируемом положении: ");
            hэ = decimal.Parse(Console.ReadLine());
            Console.Write("Введите высоту строповки: ");
            hc = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Требуемая грузоподъемность крана: " + hookLiftingHeight(h0, h3, hэ, hc) + " m");

            Console.ReadLine();
        }
    }
}
