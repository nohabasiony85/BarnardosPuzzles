using System;

namespace BarnardosPuzzles.Core.LinkedList
{
    /// <summary>
    /// A simple node that contains data and next pointers
    /// </summary>
    /// <typeparam name="T">The type that he node contains</typeparam>
    public class Node<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        public Node()
        {
            Next = null; 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node{T}"/> class.
        /// </summary>
        /// <param name="body">Data for the node to hold</param>
        public Node(T body)
        {
            if (body == null)
            {
                throw new ArgumentNullException("data");
            }

            Body = body;
            Next = null; 
        }

        /// <summary>
        /// Gets or sets the data of the node
        /// </summary>
        public T Body { get; set; }

        /// <summary>
        /// Gets or sets a next pointer
        /// </summary>
        public Node<T> Next { get; set; }

        
        /// <summary>
        /// A simple toString method that calls {T}'s toString method
        /// </summary>
        /// <returns>A string representation of the data</returns>
        public override string ToString()
        {
            return Body.ToString();
        }
    }
}