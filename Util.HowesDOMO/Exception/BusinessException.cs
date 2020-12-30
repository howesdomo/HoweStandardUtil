using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public class BusinessException : Exception
    {
        public const string cStart = "\u0002";

        public const string cEnd = "\u0003";


        public BusinessException(string exMsg) : base($"{cStart}{exMsg}{cEnd}")
        {

        }

        public BusinessException(string exMsg, Exception innerEx) : base("{cStart}{exMsg}{cEnd}", innerEx)
        {

        }
    }
}
