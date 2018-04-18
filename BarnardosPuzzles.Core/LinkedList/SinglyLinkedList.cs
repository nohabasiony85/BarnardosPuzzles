using BarnardosPuzzles.Core.LinkedList.Exceptions;

namespace BarnardosPuzzles.Core.LinkedList
{
    /*
       Write a function that would return the 5th element from the Tail (or end) of a singly linked list of integers.
       For example, given the list 2 -> 3 -> 4 ->5 -> 6 -> 7 -> 8 -> 9 -> 10 -> 11 your function would return 7.
       Your code 
       •	Should return the 5th element from the Tail in a single pass.
       •	Should be your own code and should not use any built-in .NET collection components.
   */
    public class SinglyLinkedList<T>
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the head (first element) of the list.  Internal so that <see cref="SinglyLinkedList"/> can access.
        /// Exposing set so that I can do some programming exercises, usually I wouldn't expose these to the client
        /// </summary>
        public Node<T> Head { get; set; }

        /// <summary>
        /// Gets or sets the tail (end element) of the list.  Internal so that <see cref="SinglyLinkedList"/> can access.
        /// Exposing set so that I can do some programming exercises, usually I wouldn't expose these to the client
        /// </summary>
        public Node<T> Tail { get; set; }

        /// <summary>
        /// Gets or sets the number of elements in the list
        /// Exposing set so that I can do some programming exercises, usually I wouldn't expose these to the client
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Gets a value indicating whether this list is empty.
        /// </summary>
        /// <value><c>true</c> if the list is empty; otherwise, <c>false</c>.</value>
        public bool IsEmpty
        {
            get
            {
                lock (this)
                {
                    return Tail == null;
                }
            }
        }

        #endregion

        #region Constructors
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SinglyLinkedList<T>"/> class.</see>
        /// </summary>
        public SinglyLinkedList()
        {
            //Do basic initialization
            Count = 0;
            Head = null;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="SinglyLinkedList<T>"/> class.
        /// </summary>
        /// <param name="head">The first element in a list</param>
        public SinglyLinkedList(T head)
        {
            Insert(head);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Insert a new item, and set the Tail with this element.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>the list count.</returns>
        public int Insert(T item)
        {
            lock (this)
            {
                // We have an empty list
                if (Count == 0)
                {
                    Head = Tail = new Node<T>(item);
                    return Count = 1;
                }
                Tail.Next = new Node<T>(item);
                Tail = Tail.Next;
                return ++Count;
            }
        }



        /// <summary>
        /// Retrieves a node at a specified position from the Tail.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns>the requested element body value.</returns>
        public T GetItemFromTail(int position)
        {
            lock (this)
            {
                //Put on concern that  the list is based Zero index, 
                //we set the target positon by substract
                //given position of Count. 
                position = Count - position;


                //Throw EmptyListException if the List is empty
                if (IsEmpty)
                {
                    throw new EmptyListException();
                }



                //Throw an OutOfRangeException if the target index is out of range
                if (position < 0 || position > Count)
                {
                    throw new OutOfRangeException(position);
                }

                //Get the Tail
                Node<T> currentNode = Head;

                //Start counting till reach the target element index
                for (int i = 0; i < position && currentNode != null; i++)
                    currentNode = currentNode.Next;

                //Return the request index value
                return currentNode.Body;
            }
        }

        /// <summary>
        /// Clears the list.
        /// </summary>
        public void Clear()
        {
            if (!IsEmpty)
            {
                Tail = null;
                Count = 0;
            }
        }

        #endregion
    }
}