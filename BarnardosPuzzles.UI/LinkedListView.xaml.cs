namespace BarnardosPuzzles.UI
{
    using System.Windows;

    using Core.LinkedList;

    /// <summary>
    /// Interaction logic for LinkedListView.xaml
    /// </summary>
    public partial class LinkedListView : ILinkedListView<int>
    {
        /// <summary>
        /// Element index to be retrieved
        /// </summary>
        public const int FifthElementIndex = 5;

        #region Private Fields

        private readonly LinkedListPresenter<int> _presenter;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListView"/> class.
        /// </summary>
        public LinkedListView()
        {
            InitializeComponent();

            _presenter = new LinkedListPresenter<int>(this);
        }

        #region Implementation of ILinkedListView

        /// <summary>
        /// Gets or sets the array elements.
        /// </summary>
        /// <value>The array elements.</value>
        public string TextElements
        {
            get { return txtElement.Text; }
            set { txtElement.Text = value; }
        }

        /// <summary>
        /// Gets or sets the element to be added to the array.
        /// </summary>
        /// <value>The element to be added to the array.</value>
        public int Element
        {
            get { return int.Parse(txtElements.Text); }
            set { txtElements.Text = value.ToString(); }
        }

        #endregion

        #region Event Handling

        /// <summary>
        /// Handles the Click event of the AddButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void AddButtonClick(object sender, RoutedEventArgs e)
        {
            _presenter.AddToList();
        }

        /// <summary>
        /// Handles the Click event of the ClearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ClearButtonClick(object sender, RoutedEventArgs e)
        {
            _presenter.Clear();
        }

        /// <summary>
        /// Handles the Click event of the Get5thElementButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Get5thElementButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(
            string.Format("{0} {1}", Properties.Resources.TheFifthElement, _presenter.GetElement(FifthElementIndex)),
            Properties.Resources.Results,
            MessageBoxButton.OK,
            MessageBoxImage.Information);
        }
        #endregion
    }
}
