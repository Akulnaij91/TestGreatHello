using System;
using System.Linq;

namespace TestGreatHello.Utilities
{
    public static class StringExtensions
    {
        public static bool IsUpper(this string s) => s.All(char.IsUpper);
    }
}
