using System;

namespace BarnardosPuzzles.Core.ExceptionHandling
{
    public static class ExceptionHandler
    {
        /// <summary>
        /// Handles exceptions.
        /// </summary>
        /// <param name="e">The exception.</param>
        /// <param name="exceptionHandlerAction">Action to be executed when an exception occurred(for instance show a message box).</param>
         public static void HandleException(Exception e, Action<string> exceptionHandlerAction)
         {
             if (e != null)
             {
                 if (exceptionHandlerAction != null)
                 {
                     exceptionHandlerAction.Invoke(e.Message);
                 }

                 if (!(e is CustomExceptionBase))
                 {
                     Logger.LogException(e);
                 }
             }
         }
    }
}