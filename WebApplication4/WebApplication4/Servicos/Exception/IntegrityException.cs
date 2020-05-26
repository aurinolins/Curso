using System;

namespace WebApplication4.Servicos.Exception
{
    public class IntegrityException : ApplicationException
    {
        public IntegrityException(string Message) : base(Message)
        {
        }
    }
}
