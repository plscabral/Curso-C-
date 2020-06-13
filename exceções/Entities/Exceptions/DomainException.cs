using System;

namespace aula.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException(string message) :base(message) {

        }
    }
}