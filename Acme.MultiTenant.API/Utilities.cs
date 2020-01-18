using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.MultiTenant.API
{
    public static class Utilities
    {
        private static Random _rnd = new Random();

        public static string GetRandomString()
        {
            var sb = new StringBuilder();
            for (var ii = 0; ii < 10; ii++)
            {
                sb.Append((char)_rnd.Next(97, 122));
            }
            return sb.ToString();
        }
    }
}
