namespace BarnardosPuzzles.Core.Triangles
{
    public interface ITrianglesView
    {
        /// <summary>
        /// Gets or sets the first triangel side.        
        /// </summary>
        /// <value>The first triangel side.</value>
        float X { get; set; }

        /// <summary>
        /// Gets or sets the second triangel side.
        /// </summary>
        /// <value>The second triangel side.</value>
        float Y { get; set; }

        /// <summary>
        /// Gets or sets the third triangel side.
        /// </summary>
        /// <value>The third triangel side.</value>
        float Z { get; set; } 
    }
}