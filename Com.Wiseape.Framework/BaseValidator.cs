using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.Wiseape.Framework
{
    public class BaseValidator : IFormValidator
    {

        public ValidationResult Validate<T>(T form)
        {
            throw new NotImplementedException();
        }
    }
}
