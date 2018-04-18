using System.IO;

namespace BarnardosPuzzles.Core.Helpers
{
    /// <summary>
    /// Performs IO operations
    /// </summary>
    public class IOHelper
    {
        /// <summary>
        /// Write content string to a text file.
        /// </summary>
        /// <param name="filePath">file path as string</param>
        /// <param name="fileName">file name as string</param>
        /// <param name="content">content to be written as string</param>
        /// <param name="append">if set to <c>true</c> append text to the existing file.</param>
        public static void WriteContentToFile(
            string filePath, 
            string fileName, 
            string content, 
            bool append)
        {
            if (!string.IsNullOrEmpty(content))
            {
                StreamWriter swr = null;
                try
                {
                    using (swr = new StreamWriter(filePath, append))
                    {
                        swr.Write(content);
                        swr.Close();
                    }
                }
                finally
                {
                    swr?.Close();
                }
            }
        }
    }
}
