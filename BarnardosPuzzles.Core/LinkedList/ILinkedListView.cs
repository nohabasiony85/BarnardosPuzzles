namespace BarnardosPuzzles.Core.LinkedList
{
    /// <summary>
    /// Represents a list element.
    /// </summary>
    public interface ILinkedListView<T>
    {
        /// <summary>
        /// Gets or sets the array elements.
        /// </summary>
        /// <value>The array elements.</value>
        string TextElements { get; set; }

        /// <summary>
        /// Gets or sets the element to be added to the array.
        /// </summary>
        /// <value>The element to be added to the array.</value>
        T Element { get; set; }
    }
}