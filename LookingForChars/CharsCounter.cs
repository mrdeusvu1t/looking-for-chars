using System;

namespace LookingForChars
{
    public static class CharsCounter
    {
        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <returns>The number of occurrences of all characters.</returns>
        public static int GetCharsCount(string str, char[] chars)
        {
            // TODO #1. Implement the method using "for" statement.

            if (chars is null)
            {
                throw new ArgumentNullException("error");
            }

            if (str is null)
            {
                throw new ArgumentNullException("error");
            }

            var result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (str[i] == chars[j])
                    {
                        result++;
                        break;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Searches a string for all characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <returns>The number of occurrences of all characters within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string str, char[] chars, int startIndex, int endIndex)
        {
            // TODO #2. Implement the method using "while" statement.
            if (chars is null)
            {
                throw new ArgumentNullException("error");
            }

            if (str is null)
            {
                throw new ArgumentNullException("error");
            }

            if (endIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (endIndex < 0)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (startIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            var result = 0;

            while (startIndex <= endIndex)
            {
                int i = 0;
                while (i < chars.Length)
                {
                    if (str[startIndex] == chars[i])
                    {
                        result++;
                        break;
                    }

                    i++;
                }

                startIndex++;
            }

            return result;
        }

        /// <summary>
        /// Searches a string for a limited number of characters that are in <see cref="Array" />, and returns the number of occurrences of all characters within the range of elements in the <see cref="string"/> that starts at the specified index and ends at the specified index.
        /// </summary>
        /// <param name="str">String to search.</param>
        /// <param name="chars">One-dimensional, zero-based <see cref="Array"/> that contains characters to search for.</param>
        /// <param name="startIndex">A zero-based starting index of the search.</param>
        /// <param name="endIndex">A zero-based ending index of the search.</param>
        /// <param name="limit">A maximum number of characters to search.</param>
        /// <returns>The limited number of occurrences of characters to search for within the specified range of elements in the <see cref="string"/>.</returns>
        public static int GetCharsCount(string str, char[] chars, int startIndex, int endIndex, int limit)
        {
            // TODO #3. Implement the method using "do..while" statements.
            if (chars is null)
            {
                throw new ArgumentNullException("error");
            }

            if (endIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (endIndex < 0)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (limit < 0)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (startIndex > endIndex)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (startIndex > str.Length)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (startIndex < 0)
            {
                throw new ArgumentOutOfRangeException("error");
            }

            if (str is null)
            {
                throw new ArgumentNullException("error");
            }

            var result = 0;

            do
            {
                int i = 0;
                do
                {
                    if (str[startIndex] == chars[i])
                    {
                        result++;
                        break;
                    }

                    i++;
                } while (i < chars.Length);

                if (result + 1 > limit)
                {
                    break;
                }

                startIndex++;
            } while (startIndex <= endIndex);

            return result;
        }
    }
}
