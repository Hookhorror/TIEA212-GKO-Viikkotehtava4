using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Viikkotehtava4
{
    public class AikaVirheentarkistus : ValidationRule
    {
        private TimeSpan min;
        private TimeSpan max;

        public AikaVirheentarkistus()
        {
        }

        public TimeSpan Min
        {
            get { return min; }
            set { min = value; }
        }

        public TimeSpan Max
        {
            get { return max; }
            set { max = value; }
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string s = (string)value;
            TimeSpan aika = TimeSpan.Zero;

            try
            {
                if (s.Length > 0)
                    aika = TimeSpan.Parse(s);
            }
            catch (Exception e)
            {
                return new ValidationResult(false, "Virheellinen syöte tai " + e.Message);
            }

            if ((aika < min) || (max < aika))
                return new ValidationResult(false, "Anna aika väliltä " + min + " ja " + max);

            return ValidationResult.ValidResult;

            //throw new NotImplementedException();
        }
    }
}
