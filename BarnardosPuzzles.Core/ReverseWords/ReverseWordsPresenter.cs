using BarnardosPuzzles.Core.ReverseWords.Exceptions;

namespace BarnardosPuzzles.Core.ReverseWords
{
    public class ReverseWordsPresenter
    {
        #region Private Fields

        /// <summary>
        /// Reverse words view.
        /// </summary>
        private IReverseWordsView _view;

        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="ReverseWordsPresenter"/> class.
        /// </summary>
        /// <param name="view">The view.</param>
        public ReverseWordsPresenter(IReverseWordsView view)
        {
            _view = view;
        }

        #region Public Methods

        /// <summary>
        /// Reverses the input text and write the results in the destination text.
        /// </summary>
        /// <returns></returns>
        public void Reverse()
        {
            // Through EmptyText Exception if the source text was empty.
            if (string.IsNullOrWhiteSpace(_view.Source))
            {
                throw new EmptyTextException();
            }

            // Hint: In order to use the other approach, Just call ReverseUsingLinkedList instead of Reverse
            // this.view.Destination = this.view.Source.ReverseUsingLinkedList();

            // Set the destination text to the reversed text.
            _view.Destination = _view.Source.Reverse();
        }

        #endregion
    }
}
