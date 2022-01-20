using System;
using System.Collections.Generic;
using System.Linq;

namespace StringCalculator
{
    public class StringCalculator
    {
        #region Constants
        private const int DEF_NUMBER = 0;
        private const string CUSTOM_DELIMITER = "//";
        private readonly List<string> delimiters = new List<string>() { ",", "\n" };
        private const int MAX_NUMBER = 1000;
        #endregion
        #region Addition Method
        /// <summary>
        /// Common method to accept input as number and return sum of string integers
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public int Add(string numbers)
        {
            int sumOfNumbers = 0;
            try
            {
                if (string.IsNullOrEmpty(numbers))
                    return DEF_NUMBER;

                if (numbers.Contains(CUSTOM_DELIMITER))
                {
                    numbers = AddCustomDelimiter(numbers);
                }

                sumOfNumbers = CalculateSum(numbers);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return sumOfNumbers;
        }
        #endregion
        #region Common Methods
        /// <summary>
        /// Adding Delimiters
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        private string AddCustomDelimiter(string numbers)
        {
            string[] customDelimiters = { CUSTOM_DELIMITER, "[", "]" };
            var customDelimiter = numbers.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).FirstOrDefault();

            numbers = numbers.Substring(customDelimiter.Length, numbers.Length - customDelimiter.Length);
            var allDelimiterDefaults = customDelimiter.Split(customDelimiters, StringSplitOptions.RemoveEmptyEntries);

            foreach(var delimit in allDelimiterDefaults)
            {
                delimiters.Add(delimit);
            }
            return numbers;
        }

        /// <summary>
        /// Calculate Sum
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        private int CalculateSum(string numbers)
        {
            int number = 0;
            List<int> lstnumbers = new List<int>();
            try
            {
                var seperatenumber = numbers.Split(delimiters.ToArray(), StringSplitOptions.RemoveEmptyEntries);

                // Iterate lopp of comma or new line seperated and inserted
                for (int i = 0; i < seperatenumber.Length; i++)
                {
                    number = int.Parse(seperatenumber[i]);

                    // Negative Number Validation 
                    if (number < 0)
                        throw new ApplicationException("Number can not be Negative");

                    // Max Number adding entry
                    if (number <= MAX_NUMBER)
                        lstnumbers.Add(number);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return lstnumbers.Count() > 0 ? lstnumbers.Sum() : 0;
        }
        #endregion
    }
}
