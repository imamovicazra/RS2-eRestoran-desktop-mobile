using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace eRestoran.WinUI.Validators
{
    public class BaseValidator
    {
        protected bool Email(string value)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
            Match match = regex.Match(value);

            return match.Success;
        }

        protected bool MaxLength(string value, int max)
        {
            return value.Length <= max;
        }

        protected bool MinLength(string value, int min)
        {
            return value.Length >= min;
        }

        protected bool Number(string value)
        {
            return int.TryParse(value, out _);
        }

        protected bool NumberDouble(string value)
        {
            return double.TryParse(value, out _);
        }

        protected bool PhoneNumber(string value)
        {
            Regex regex = new Regex(@"^(\+)?([0-9]){9,16}$");
            Match match = regex.Match(value);

            return match.Success;
        }

        protected bool Range(string value, int min, int max)
        {
            return min <= value.Length && value.Length <= max;
        }

        protected bool Required(string value)
        {
            return !string.IsNullOrEmpty(value);
        }

        protected bool Time(string value)
        {
            Regex regex = new Regex(@"^([01]?[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9]$");
            Match match = regex.Match(value);

            return match.Success;
        }
    }
}

