using System;
using System.Globalization;

namespace Open_Lab_02._09
{
    public class Names
    {
        public string ConcatName(string firstName, string lastName)
        {
            string fullName = lastName + ", " + firstName;
            return fullName;
        }
    }
}
