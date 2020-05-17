using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Servicos.Exception
{
    public class DBConcurrencyException : ApplicationException
    {
        public DBConcurrencyException(string Message) : base(Message)
        {
        }
    }
}
