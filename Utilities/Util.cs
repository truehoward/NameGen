using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NameGen.Utilities
{
    public static class Util
    {
        public static string UppercaseFirst(string s)
        {
	        if (string.IsNullOrEmpty(s))
	        {
	            return string.Empty;
	        }
	        
	        return char.ToUpper(s[0]) + s.ToLower().Substring(1);
        }
    }
}