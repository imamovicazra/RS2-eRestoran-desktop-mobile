using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestoran.WinUI.Validators
{
    public class ValidationResult
    {
        public readonly string Message;
        public readonly bool IsValid;

        public ValidationResult(string message, bool isvalid)
        {
            Message = message;
            IsValid = isvalid;
        }
    }
}
