namespace OOP_Principles_Part1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
        public static class Verify
    {
        public static void CheckIfNullOrEmpty(string value, string message)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void CheckIfNumberNegative(int num, string message)
        {
            if (num < 0)
            {
                throw new Exception(message);
            }
        }
    }
}
