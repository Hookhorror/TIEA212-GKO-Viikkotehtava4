using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Viikkotehtava4
{
    public class MatkaVirheentarkistus : ValidationRule
    {
        private double min;
        private double max;

        public MatkaVirheentarkistus()
        {
        }

        public double Min
        {
            get { return min; }
            set { min = value; }
        }

        public double Max
        {
            get { return max; }
            set { max = value; }
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string s = (string)value;
            double luku = 0;

            try
            {
                if (s.Length > 0)
                    luku = double.Parse(s);
            }
            catch(Exception e)
            {
                return new ValidationResult(false, "Virheellinen syöte tai " + e.Message);
            }

            if ((luku < min) || (max < luku))
                return new ValidationResult(false, "Anna luku väliltä " + min + " ja " + max);

            return ValidationResult.ValidResult;

            //throw new NotImplementedException();
        }
    }
}
