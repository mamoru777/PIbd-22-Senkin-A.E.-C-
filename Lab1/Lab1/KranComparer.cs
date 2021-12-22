using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class KranComparer: IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            // Реализовать метод сравнения для объектов
            if (x is Gusmashina && y is Kran)
            {
                return 1;
            }
            if (x is Kran && y is Gusmashina)
            {
                return -1;
            }
            if (x is Gusmashina && y is Gusmashina)
            {
                return ComparerGusmashina((Gusmashina)x, (Gusmashina)y);
            }
            if (x is Kran && y is Kran)
            {
                return ComparerKran((Kran)x, (Kran)y);
            }
            return 0;
        }
        private int ComparerGusmashina(Gusmashina x, Gusmashina y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerKran(Kran x, Kran y)
        {
            var res = ComparerGusmashina(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.DopColor2 != y.DopColor2)
            {
                return x.DopColor2.Name.CompareTo(y.DopColor2.Name);
            }
            if (x.Krann != y.Krann)
            {
                return x.Krann.CompareTo(y.Krann);
            }
            if (x.Okna != y.Okna)
            {
                return x.Okna.CompareTo(y.Okna);
            }
            return 0;
        }
    }
}
