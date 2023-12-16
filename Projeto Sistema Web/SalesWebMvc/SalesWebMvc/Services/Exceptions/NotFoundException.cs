using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class NotFoundException : AppDomainUnloadedException
    {

        public NotFoundException(string message) : base(message)
        {

        }

    }
}
