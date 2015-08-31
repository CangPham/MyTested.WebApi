﻿namespace MyWebApi.Utilities
{
    using System;

    /// <summary>
    /// Validator class containing common validation logic.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Validates object for null reference.
        /// </summary>
        /// <param name="value">Object to be validated.</param>
        /// <param name="parameterName">Name of the parameter to be checked.</param>
        /// <param name="errorMessageName">Name of the parameter to be included in the error message.</param>
        public static void CheckForNullReference(
            object value,
            string parameterName = "value",
            string errorMessageName = "Value")
        {
            if (value == null)
            {
                throw new ArgumentNullException(parameterName, string.Format("{0} cannot be null.", errorMessageName));
            }
        }

        /// <summary>
        /// Validates string for null reference or whitespace.
        /// </summary>
        /// <param name="value">String to be validated.</param>
        /// <param name="parameterName">Name of the parameter to be checked.</param>
        /// <param name="errorMessageName">Name of the parameter to be included in the error message.</param>
        public static void CheckForNotWhiteSpaceString(
            string value,
            string parameterName = "value",
            string errorMessageName = "Value")
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(parameterName, string.Format("{0} cannot be null or white space.", errorMessageName));
            }
        }

        public static void CheckForEqualityWithDefaultValue<T>(T value, string message)
        {
            if (value == null || value.Equals(default(T)))
            {
                throw new InvalidOperationException(message);
            }
        }
    }
}
