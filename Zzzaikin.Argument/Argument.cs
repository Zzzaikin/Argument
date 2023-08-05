using System;
using System.Linq;
using System.Collections.Generic;

namespace Zzzaikin.Argument
{
    public static class Argument
    {
        public static void NotNull(object argumentValue, string argumentName)
        {
            if (argumentValue == null)
            {
                var exceptionMessage = string.Format(Resources.ArgumentCanNotBeNull, argumentName);
                throw new ArgumentNullException(exceptionMessage);
            }
        }

        public static void NotNullOrEmpty(string argumentValue, string argumentName)
        {
            if (string.IsNullOrEmpty(argumentValue))
            {
                var exceptionMessage = string.Format(Resources.ArgumentCanNotBeNullOrEmpty, argumentName);
                throw new ArgumentException(exceptionMessage);
            }
        }

        public static void NotNullOrEmpty(IEnumerable<object> argumentValue, string argumentName)
        {
            NotNull(argumentValue, argumentName);

            if (!argumentValue.Any())
            {
                var exceptionMessage = string.Format(Resources.ArgumentCanNotBeNullOrEmpty, argumentName);
                throw new ArgumentException(exceptionMessage);
            }
        }
    }
}
