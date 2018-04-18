using System;
using System.IO;
using BarnardosPuzzles.Core.Helpers;

namespace BarnardosPuzzles.Core.ExceptionHandling
{
    /// <summary>
    /// Exception Logging
    /// </summary>
    public class Logger
    {
        #region Private Fields

        /// <summary>
        /// Represents the default log file, to log the exceptions.
        /// </summary>
        private const string FileName = "log.txt";

        /// <summary>
        /// Represents the default route of the log file name.
        /// The default value is the application directory
        /// </summary>
        private static string LogFileDirectory = AppDomain.CurrentDomain.BaseDirectory;

        #endregion

        /// <summary>
        /// Logs the exception.
        /// </summary>
        /// <param name="exception">The exception.</param>
        public static void LogException(Exception exception)
        {
            if (exception != null)
            {
                //Log the details of the inner and the outer exceptions
                if (exception.InnerException != null)
                {
                    IOHelper.WriteContentToFile(LogFileDirectory, Path.Combine(LogFileDirectory, FileName), string.Format(
                    "{0} {1}\t|\t{2}{3}{4}{5} Inner Exception: {6}{7}{8}",
                    DateTime.Now.ToLongDateString(),
                    DateTime.Now.ToLongTimeString(),
                    exception.Message,
                    Environment.NewLine,
                    exception.StackTrace,
                    Environment.NewLine,
                    exception.InnerException.Message,
                    Environment.NewLine,
                    exception.InnerException.StackTrace), true);
                }
                else
                {
                    IOHelper.WriteContentToFile(LogFileDirectory, Path.Combine(LogFileDirectory, FileName), string.Format(
                        "{0} {1}\t|\t{2}{3}{4}{5}",
                        DateTime.Now.ToLongDateString(),
                        DateTime.Now.ToLongTimeString(),
                        exception.Message,
                        Environment.NewLine,
                        exception.StackTrace,
                        Environment.NewLine
                        ),
                        true);
                }
            }
        }
    }
}