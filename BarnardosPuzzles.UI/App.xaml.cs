namespace BarnardosPuzzles.UI
{
    using System;
    using System.Windows;
    using System.Windows.Threading;
    using Core.ExceptionHandling;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Current.DispatcherUnhandledException += CurrentOnDispatcherUnhandledException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }

        /// <summary>
        /// Handles the DispatcherUnhandledException event of the Application control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="dispatcherUnhandledExceptionEventArgs">The <see cref="System.Threading.ThreadExceptionEventArgs"/> instance containing the event data.</param>
        private static void CurrentOnDispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs dispatcherUnhandledExceptionEventArgs)
        {
            ExceptionHandler.HandleException(
               dispatcherUnhandledExceptionEventArgs.Exception,
               exceptionMessage => MessageBox.Show(exceptionMessage,
                   UI.Properties.Resources.Error,
                   MessageBoxButton.OK,
                   MessageBoxImage.Error));
        }

        /// <summary>
        /// Handles the UnhandledException event of the CurrentDomain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.UnhandledExceptionEventArgs"/> instance containing the event data.</param>
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception)
            {
                ExceptionHandler.HandleException(
                    (Exception)e.ExceptionObject,
                    exceptionMessage => MessageBox.Show(exceptionMessage,
                                                      UI.Properties.Resources.Error,
                                                      MessageBoxButton.OK,
                                                      MessageBoxImage.Error));
            }
        }



    }
}
