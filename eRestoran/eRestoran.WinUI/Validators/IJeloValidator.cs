using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.WinUI.Validators
{
    public interface IJeloValidator
    {
        ValidationResult NameCheck(string value);
        ValidationResult DescriptionCheck(string value);
        ValidationResult PriceCheck(string value);
    }
}
