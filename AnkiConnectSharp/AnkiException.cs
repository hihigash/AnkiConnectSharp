using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkiConnectSharp
{
    public class AnkiException : Exception
    {
        public AnkiException(string message) : base(message)
        {
        }
    }
}
