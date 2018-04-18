using System.Text;

namespace BarnardosPuzzles.Core.ReverseWords
{
    /*
        Write a function to reverse the words in a string, for example “cat and dog” becomes “tac dna god”.
        Please do not use any string manipulation functions that you do not implement yourself.
        Your code 
            •	Should reverse each word within the string without altering whitespace characters
            •	Should treat punctuation characters as part of the word
            •	Is only required to deal with standard English characters.  Unicode support is not required.
            •	Should be your own code and should not use any built-in .NET string manipulation calls.

     */

    public static class ReverseWords
    {
        /// <summary>
        /// Reverses the specified text.
        /// The idea to start a reverse loop when reach a separator(white space or a new line) to write the
        ///  characters in a reverse order.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        public static string Reverse(this string text)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                var reversedText = new StringBuilder();

                // Point to the last whiteSpace or any other separation.
                int lastSeparatorIndex = 0;

                // Loop over the string characters
                for (int i = 0; i <= text.Length; i++)
                {
                    if (i + 1 > text.Length || text[i] == ' ' || text[i] == '\r' || text[i] == '\n')
                    {
                        for (int index = i - 1; index >= lastSeparatorIndex; index--)
                        {
                            reversedText.Append(text[index]);
                        }

                        // If not reach the end of the string, add the separator from the original string.
                        if (i + 1 <= text.Length)
                        {
                            reversedText.Append(text[i]);
                        }

                        // i+1 because we add the separator if we not reach the end of the string.
                        lastSeparatorIndex = i + 1;

                    }
                }

                return reversedText.ToString();
            }

            return text;
        }
    }
}