using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace register_form.Exeptions
{
    internal class UsernameExeption : Exception
    {
        public UsernameExeption(string message): base(message) { }
    }
}
