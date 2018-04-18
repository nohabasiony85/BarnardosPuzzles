using BarnardosPuzzles.Core.LinkedList.Exceptions;

namespace BarnardosPuzzles.Core.LinkedList
{
    public class LinkedListPresenter<T>
    {
        #region Private Fields

        /// <summary>
        /// LinkedList view.
        /// </summary>
        private ILinkedListView<T> view;

        /// <summary>
        /// The Generic linked list.
        /// </summary>
        private SinglyLinkedList<T> list;

        #endregion
 

        public LinkedListPresenter(ILinkedListView<T> view)
        {
            this.view = view;
            list = new SinglyLinkedList<T>();
        }

        #region Public Methods

        /// <summary>
        /// Add to List
        /// </summary>
        public void AddToList()
        {
            if (string.IsNullOrWhiteSpace(view.TextElements))
            {
                view.TextElements += string.Format("{0}", view.Element);
            }
            else
            {
                view.TextElements += string.Format(" - {0}", view.Element);
            }

            list.Insert(view.Element);
        }


        ///<summary>
        /// Gets the element by position
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns></returns>
        public T GetElement(int position)
        {
            if (string.IsNullOrEmpty(view.TextElements))
                    throw new EmptyListException();

            return list.GetItemFromTail(position);
        }

        /// <summary>
        /// Clears the list.
        /// </summary>
        public void Clear()
        {
            list.Clear();
            view.TextElements = string.Empty;
        }


        #endregion
    }
}