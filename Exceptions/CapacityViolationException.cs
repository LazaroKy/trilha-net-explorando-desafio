using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Exceptions
{
    public class CapacityViolationException : Exception
    {
        public CapacityViolationException(string msg)
        {
            Console.WriteLine($"Error: {msg}");
        }
    }
}