using System;
using System.Runtime.Serialization;

namespace Jobs.Exceptions
{
    public class JobNotStartedException : Exception
    {
        public JobNotStartedException()
        {
        }
    }
}