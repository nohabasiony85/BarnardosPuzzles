namespace BarnardosPuzzles.Core.Triangles
{
    public class TrianglesPresenter
    {
        #region Private Fields

        /// <summary>
        /// Triangle view.
        /// </summary>
        private ITrianglesView _view;

        #endregion 


        /// <summary>
        /// Initializes a new instance of the <see cref="TrianglesPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public TrianglesPresenter(ITrianglesView view)
        {
            _view = view;
        }

        #region Public Methods

        /// <summary>
        /// Gets the type of the triangle.
        /// </summary>
        /// <returns>Triangle type in string</returns>
        public string GetTriangleType()
        {
            return Triangles.GetTriangleType(_view.X, _view.Y, _view.Z).ToString();
        }

        #endregion
    }
}