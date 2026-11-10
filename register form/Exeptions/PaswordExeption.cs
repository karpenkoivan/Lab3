using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace register_form.Exeptions
{
    internal class PaswordExeption : Exception
    {
        public PaswordExeption(string message) : base(message) { }

    }
}
