namespace BarnardosPuzzles.Core.Triangles
{
    public enum TriangleType
    {
        /// <summary>
        /// No equal sides.
        /// </summary>
        Scalene,

        /// <summary>
        /// Two equal sides.
        /// </summary>
        Isosceles,

        /// <summary>
        /// Three equal sides.
        /// </summary>
        Equilateral,

        /// <summary>
        /// Not a triangle.
        /// </summary>
        Error
    }
}