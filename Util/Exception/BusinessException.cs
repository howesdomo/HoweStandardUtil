using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace System
{
    public class BusinessException : Exception
    {
        public BusinessException(string exMsg) : base(exMsg)
        {

        }

        public BusinessException(string exMsg, Exception innerEx) : base(exMsg, innerEx)
        {

        }
    }
}
