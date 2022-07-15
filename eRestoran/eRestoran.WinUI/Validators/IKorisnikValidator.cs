using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.WinUI.Validators
{
    public interface IKorisnikValidator
    {
        ValidationResult FirstNameCheck(string value);
        ValidationResult LastNameCheck(string value);
        ValidationResult EmailCheck(string value);
        ValidationResult PhoneCheck(string value);
        ValidationResult UsernameCheck(string value);
        ValidationResult PasswordCheck(string value);
        ValidationResult PasswordConfirmCheck(string password, string confirmpassword);
    }
}
