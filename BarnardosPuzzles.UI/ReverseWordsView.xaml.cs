namespace BarnardosPuzzles.UI
{
    using System;
    using System.Windows;
    using Core.ReverseWords;

    /// <summary>
    /// Interaction logic for ReverseWordsView.xaml
    /// </summary>
    public partial class ReverseWordsView : Window, IReverseWordsView
    {
        #region Private Fields

        private ReverseWordsPresenter presenter;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseWordsView"/> class.
        /// </summary>
        public ReverseWordsView()
        {
            InitializeComponent();

            presenter = new ReverseWordsPresenter(this);
        }

        #region Implementation of IReverseWordsView

        /// <summary>
        /// Gets or sets the source text.
        /// </summary>
        /// <value>The source.</value>
        public string Source
        {
            get
            {
                return SourceTextBox.Text;
            }
            set
            {
                SourceTextBox.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets the destination text.
        /// </summary>
        /// <value>The destination.</value>
        public string Destination
        {
            get
            {
                return DestinationTextBox.Text;
            }
            set
            {
                DestinationTextBox.Text = value;
            }
        }

        #endregion


        #region Event Handling

        /// <summary>
        /// Handles the Click event of the btnConvert control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ConvertButtonClick(object sender, EventArgs e)
        {
            presenter.Reverse();
        }

        #endregion
    }
}
