﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ExceptionClass
{
    [Serializable()]
    public class NotPrimeException : Exception
    {
        private int notAPrime;

        protected NotPrimeException()
            : base()
        { }

        public NotPrimeException(int value) :
            base(String.Format("{0} is not a prime number.", value))
        {
            notAPrime = value;
        }

        public NotPrimeException(int value, string message)
            : base(message)
        {
            notAPrime = value;
        }

        public NotPrimeException(int value, string message, Exception innerException) :
            base(message, innerException)
        {
            notAPrime = value;
        }

        protected NotPrimeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        { }

        public int NonPrime
        {
            get
            {
                return notAPrime;
            }
        }
    }
}
