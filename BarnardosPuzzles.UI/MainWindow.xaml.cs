namespace BarnardosPuzzles.UI
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Event Handling

        /// <summary>
        /// Handles the Click event of the LinkedListButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void LinkedListButtonClick(object sender, RoutedEventArgs e)
        {
            var view = new LinkedListView();
            view.ShowDialog();
        }


        /// <summary>
        /// Handles the Click event of the ReverseWordButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ReverseWordButtonClick(object sender, RoutedEventArgs e)
        {
            var view = new ReverseWordsView();
            view.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the TriangleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void TriangleButtonClick(object sender, RoutedEventArgs e)
        {
            var view = new TrianglesView();
            view.ShowDialog();
        }

        #endregion
    }
}
