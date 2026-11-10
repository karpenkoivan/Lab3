using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace register_form
{
    internal static class Rules
    {
        public static List<(string rule, string errorMesage)> USERNAME_RULES = new List<(string, string)>
        {
            (@"[a-zA-Z\.]+", "Has characters that are not letters or '.'"),
            (@"^[a-zA-Z]+\.[a-zA-Z]+$", "Has to be divided in 2 by '.'"),
            (@"^[A-Z]", "Has to start with capital letter"),
            (@"\.[A-Z]", "Has to have a capital letter after '.'")
        };

        public static List<(string rule, string errorMesage)> EMAIL_RULES = new List<(string, string)>
        {
            (@"[a-zA-Z0-9!@#$%/*-+=?_]+", "Has characters that are not suported"),
            (@"[a-zA-Z0-9!@#$%/*-+=?_]+@[a-zA-Z0-9!@#$%/*-+=?_]+", "Has to have 2 parts wich divided by '@'"),
        };

        public static List<(string rule, string errorMesage)> PASSWORD_RULES = new List<(string, string)>
        {
            (@"[a-zA-Z0-9]+", "Has characters that are not leters or numbers"),
            (@"Hello", "Has to include word 'Hello'"),
            (@"^67", "Has to start with '67'"),
            (@"67$", "Has to end with '67'")
        };
    }
}
