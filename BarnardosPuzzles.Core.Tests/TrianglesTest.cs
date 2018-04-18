namespace BarnardosPuzzles.Core.Tests
{
    using NUnit.Framework;
    using Triangles;

    /// <summary>
    ///This is a test class for TrianglesTest and is intended
    ///to contain all TrianglesTest Unit Tests
    ///</summary>
    [TestFixture]
    public class TrianglesTest
    {
        #region GetTriangleType Tests

        /// <summary>
        ///A test for GetTriangleType
        ///</summary>
        [Test]
        public void GetTriangleTypeTest_NumbersLessThanZero_Error()
        {
            double x = -1;
            double y = 1;
            double z = 5;
            TriangleType expected = TriangleType.Error;
            TriangleType actual = Triangles.GetTriangleType(x, y, z);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetTriangleType
        ///</summary>
        [Test]
        public void GetTriangleTypeTest_NumbersEqualZero_Error()
        {
            double x = 5;
            double y = 0;
            double z = 5;
            TriangleType expected = TriangleType.Error;
            TriangleType actual = Triangles.GetTriangleType(x, y, z);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetTriangleType
        ///</summary>
        [Test]
        public void GetTriangleTypeTest_TwoSidesLessThanTheThirdTest1_Error()
        {
            double x = 5;
            double y = 10;
            double z = 50;
            TriangleType expected = TriangleType.Error;
            TriangleType actual = Triangles.GetTriangleType(x, y, z);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetTriangleType
        ///</summary>
        [Test]
        public void GetTriangleTypeTest_TwoSidesLessThanTheThirdTest2_Error()
        {
            double x = 500;
            double y = 10;
            double z = 50;
            TriangleType expected = TriangleType.Error;
            TriangleType actual = Triangles.GetTriangleType(x, y, z);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetTriangleType
        ///</summary>
        [Test]
        public void GetTriangleTypeTest_TwoSidesLessThanTheThirdTest3_Error()
        {
            double x = 50;
            double y = 20;
            double z = 30;
            TriangleType expected = TriangleType.Error;
            TriangleType actual = Triangles.GetTriangleType(x, y, z);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetTriangleType
        ///</summary>
        [Test]
        public void GetTriangleTypeTest_BalancedSides_Equilateral()
        {
            double x = 10;
            double y = 10;
            double z = 10;
            TriangleType expected = TriangleType.Equilateral;
            TriangleType actual = Triangles.GetTriangleType(x, y, z);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetTriangleType
        ///</summary>
        [Test]
        public void GetTriangleTypeTest_TwoEqualSides_Isosceles()
        {
            double x = 10;
            double y = 10;
            double z = 15;
            TriangleType expected = TriangleType.Isosceles;
            TriangleType actual = Triangles.GetTriangleType(x, y, z);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetTriangleType
        ///</summary>
        [Test]
        public void GetTriangleTypeTest_NoEqualSides_Scalene()
        {
            double x = 10;
            double y = 12;
            double z = 15;
            TriangleType expected = TriangleType.Scalene;
            TriangleType actual = Triangles.GetTriangleType(x, y, z);
            Assert.AreEqual(expected, actual);
        }

        #endregion
    }
}