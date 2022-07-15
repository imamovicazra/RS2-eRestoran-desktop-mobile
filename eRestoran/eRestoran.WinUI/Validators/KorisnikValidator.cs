using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.WinUI.Validators
{
    public class KorisnikValidator : BaseValidator, IKorisnikValidator
    {
        private readonly APIService _apiService = new APIService("korisnici");
        public ValidationResult EmailCheck(string value)
        {
            if (!Required(value))
            {
                return new ValidationResult("Obavezno polje", false);
            }
            else if (!Email(value))
            {
                return new ValidationResult("Email adresa nije u ispravnom obliku", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }

        public ValidationResult FirstNameCheck(string value)
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

        public ValidationResult LastNameCheck(string value)
        {
            if (!Required(value))
            {
                return new ValidationResult("Obavezno polje", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }

        public ValidationResult PasswordCheck(string value)
        {
            if (!Required(value))
            {
                return new ValidationResult("Obavezno polje", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }

        public ValidationResult PasswordConfirmCheck(string password, string confirmpassword)
        {
            if (!Required(password))
            {
                return new ValidationResult("Obavezno polje", false);
            }
            else if (password != confirmpassword)
            {
                return new ValidationResult("Lozinke se ne podudaraju", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }

        public ValidationResult PhoneCheck(string value)
        {
            if (!PhoneNumber(value) && !string.IsNullOrEmpty(value))
            {
                return new ValidationResult("Neispravan format broja", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }

        public ValidationResult UsernameCheck(string value)
        {
            if (!Required(value))
            {
                return new ValidationResult("Obavezno polje", false);
            }
            else
            {
                return new ValidationResult("", true);
            }
        }
    }
}
