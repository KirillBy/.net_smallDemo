using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prc
{
    internal static class ParamsValidator
    {
        public static bool GameParamsValidate(string[] arguments, out string message)
        {
            if (arguments.Length < 3)
            {
                message = "You must enter more than 3 parametrs";
                    return false;
            }
            if(arguments.Length % 2 == 0)
            {
                message = "Number of parametrs must be even";
                    return false;
            }
            if (arguments.Distinct().Count() == arguments.Count())
            {
                message = "Validation - ok";
                return true;
            }
            else
            {
                message = "Parametrs must be unique";
                return false;
            }
        }
    }
}
