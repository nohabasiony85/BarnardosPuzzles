namespace BarnardosPuzzles.Core.Triangles
{
    /*
        Write a function that receives three integer inputs for the lengths of the sides of a triangle 
        and returns one of four values to determine the triangle type.
            1.	Scalene
            2.	Isosceles
            3.	Equilateral
            4.	Error
    */

    public class Triangles
    {
        /// <summary>
        /// Gets the type of the triangle.
        /// </summary>
        /// <param name="x">The first side.</param>
        /// <param name="y">The second side.</param>
        /// <param name="z">The third side.</param>
        /// <returns></returns>
        public static TriangleType GetTriangleType(double x, double y, double z)
        {
            // We would have error if one of the sides is less than zero or the summation of any two 
            // sides is less than the third side.
            if ((x <= 0 || y <= 0 || z <= 0) ||
                    (x + y <= z || x + z <= y || y + z <= x))
            {
                return TriangleType.Error;
            }

            // Equilateral if all sides are equal.
            if (x == y && y == z)
            {
                return TriangleType.Equilateral;
            }

            // Isosceles if the triangel have two equal sides.
            if (x == y || y == z || x == z)
            {
                return TriangleType.Isosceles;
            }

            // Scalene if there is no balanced sides.
            return TriangleType.Scalene;
        } 
    }
}