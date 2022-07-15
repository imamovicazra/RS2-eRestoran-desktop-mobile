using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.WinUI.Validators
{
    public class JeloValidator : BaseValidator, IJeloValidator
    {
        private readonly APIService _apiService = new APIService("korisnici");

        public ValidationResult NameCheck(string value)
        {
            if (!Required(value))
            {
                return new ValidationResult("Obavezno  polje", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }

        public ValidationResult DescriptionCheck(string value)
        {
            if (!Required(value))
            {
                return new ValidationResult("Obavezno  polje", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }

        public ValidationResult PriceCheck(string value)
        {
            if (!Required(value))
            {
                return new ValidationResult("Obavezno  polje", false);
            }
            if( !NumberDouble(value))
            {
                return new ValidationResult("Pogrešan format", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }
    }
}
