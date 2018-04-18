namespace BarnardosPuzzles.Core.ReverseWords
{
    public interface IReverseWordsView
    {
        /// <summary>
        /// Gets or sets the source text.
        /// </summary>
        /// <value>The source.</value>
        string Source { get; set; }

        /// <summary>
        /// Gets or sets the destination text.
        /// </summary>
        /// <value>The destination.</value>
        string Destination { get; set; } 
    }
}