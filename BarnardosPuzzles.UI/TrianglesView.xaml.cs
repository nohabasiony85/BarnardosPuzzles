namespace BarnardosPuzzles.UI
{
    using System.Windows;
    using Core.Triangles;

    /// <summary>
    /// Interaction logic for TrianglesView.xaml
    /// </summary>
    public partial class TrianglesView : Window, ITrianglesView
    {
        #region Private Fields

        private TrianglesPresenter _presenter;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="TrianglesView"/> class.
        /// </summary>
        public TrianglesView()
        {
            InitializeComponent();

            _presenter = new TrianglesPresenter(this);
        }

        #region Implementation of ITrianglesView

        /// <summary>
        /// Gets or sets the first triangel side.
        /// </summary>
        /// <value>The first triangel side.</value>
        public float X
        {
            get
            {
                return float.Parse(XTextBox.Text);
            }
            set
            {
                XTextBox.Text = value.ToString();
            }
        }

        /// <summary>
        /// Gets or sets the second triangel side.
        /// </summary>
        /// <value>The second triangel side.</value>
        public float Y
        {
            get
            {
                return float.Parse(YTextBox.Text);
            }
            set
            {
                YTextBox.Text = value.ToString();
            }
        }

        /// <summary>
        /// Gets or sets the third triangel side.
        /// </summary>
        /// <value>The third triangel side.</value>
        public float Z
        {
            get
            {
                return float.Parse(ZTextBox.Text);
            }
            set
            {
                ZTextBox.Text = value.ToString();
            }
        }

        #endregion

        #region Event Handling

        /// <summary>
        /// Handles the Click event of the btnCalculate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void CalculateButtonClick(object sender, RoutedEventArgs e)
        {
            string result = string.Empty;

            //Make sure that X/Y/Z TextBoxes have values
            if (!(string.IsNullOrWhiteSpace(XTextBox.Text)
                || string.IsNullOrWhiteSpace(YTextBox.Text)
                || string.IsNullOrWhiteSpace(ZTextBox.Text)))
            {
                result = _presenter.GetTriangleType();
            }

            if (!string.IsNullOrWhiteSpace(result))
            {
                MessageBox.Show(
               string.Format("{0} {1}",
                   Properties.Resources.TheTriangleType,
                   _presenter.GetTriangleType()),
                   Properties.Resources.Results,
                   MessageBoxButton.OK,
                   MessageBoxImage.Information);
            }
        }

        #endregion
    }
}
