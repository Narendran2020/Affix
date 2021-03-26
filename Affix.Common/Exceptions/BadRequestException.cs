using Affix.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Affix.Common.Exceptions
{
     public sealed class BadRequestException : Exception
    {
        public ValidationError Error { get; }

        public BadRequestException(ValidationError error)
        {
            this.Error = error;
        }


    }
}
