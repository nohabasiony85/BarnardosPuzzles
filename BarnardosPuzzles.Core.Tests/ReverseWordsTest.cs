namespace BarnardosPuzzles.Core.Tests
{
    using System;
    using System.Text;
    using NUnit.Framework;
    using ReverseWords;

    /// <summary>
    ///This is a test class for ReverseWordsTest and is intended
    ///to contain all ReverseWordsTest Unit Tests
    ///</summary>
    [TestFixture]
    public class ReverseWordsTest
    {
        #region Reverse Tests

        [Test]
        public void ReverseTest_EmprtString_DoNothing()
        {
            string text = string.Empty;
            string expected = string.Empty;
            string actual = ReverseWords.Reverse(text);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseTest_WhiteSpaceString_RetuenOriginalString()
        {
            string text = " ";
            string expected = " ";
            string actual = ReverseWords.Reverse(text);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseTest_StringWithTwoWhiteSpaces_ReturnReversedString()
        {
            string text = "Test the first";
            string expected = "tseT eht tsrif";
            string actual = ReverseWords.Reverse(text);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseTest_StringWithWhiteSpaceAtTheEnd_ReturnReversedString()
        {
            string text = "Test the first ";
            string expected = "tseT eht tsrif ";
            string actual = ReverseWords.Reverse(text);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ReverseTest_StringWithMultipleLines_ReturnReversedString()
        {
            var builder = new StringBuilder();
            builder.Append("Test the first line");
            builder.Append(Environment.NewLine);
            builder.Append("Test the second line");
            builder.Append(Environment.NewLine);
            builder.Append("Test the third line!!");

            var expected = new StringBuilder();
            expected.Append("tseT eht tsrif enil");
            expected.Append(Environment.NewLine);
            expected.Append("tseT eht dnoces enil");
            expected.Append(Environment.NewLine);
            expected.Append("tseT eht driht !!enil");

            string actual = ReverseWords.Reverse(builder.ToString());
            Assert.IsTrue(expected.ToString().Equals(actual));
        }

        #endregion
    }
}