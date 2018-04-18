namespace BarnardosPuzzles.Core.Tests
{
    using NUnit.Framework;
    using LinkedList;
    using LinkedList.Exceptions;

    /// <summary>
    ///This is a test class for SinglyLinkedListTest and is intended
    ///to contain all SinglyLinkedListTest Unit Tests
    ///</summary>
    [TestFixture]
    public class SinglyLinkedList
    { 
        #region Insert Tests

        [Test]
        public void InsertTest_InsertOneItemAsInteger_ReturnOneAndSetTail()
        {
            var targetList = new SinglyLinkedList<int>();
            int item = 1;
            int expected = 1;
            var actual = targetList.Insert(item);


            //Assert
            Assert.AreEqual(expected, actual); 
        }


        [Test]
        public void InsertTest_InsertOneItemAsString_ReturnOne()
        {
            var targetList = new SinglyLinkedList<string>();
            string item = "Test";
            targetList.Insert(item);
            
            Assert.IsNotNull(targetList.Tail); 
        }

        [Test]
        public void InsertTest_InsertOneItemAsString_SetTail()
        {
            var targetList = new SinglyLinkedList<string>();
            string item = "Test";
            targetList.Insert(item);

            Assert.IsNotNull(targetList.Tail);
        }

        [Test]
        public void InsertTest_InsertMoreThanItem_ReturnItemsCountAndSetTail()
        {
            var targetList = new SinglyLinkedList<string>();
            string item1 = "Test1";
            string item2 = "Test2";
            string item3 = "Test3";

            int expected = 3;
            targetList.Insert(item1);
            targetList.Insert(item2);
            int actual = targetList.Insert(item3);

            Assert.AreEqual(expected, actual);
            Assert.IsNotNull(targetList.Tail);
        }
        #endregion

        #region GetItemFromTail Tests

        [Test]
        public void GetItemFromTail_EmptyList_ThrowEmptyListException()
        {
            var target = new SinglyLinkedList<int>();
            int index = 5;
            Assert.Throws<EmptyListException>(() => target.GetItemFromTail(index));
        }

        [Test] 
        public void GetItemFromTail_GetFifthItemFromListWithOneItem_ThrowOutOfRangeException()
        {
            var target = new SinglyLinkedList<int>();
            target.Insert(1);
            int index = 5; 
            Assert.Throws<OutOfRangeException>(() => target.GetItemFromTail(index));
        }

        [Test]
        public void GetItemFromTail_GetFifthItemFromListWithFifeItems_ReturnTheFirstItem()
        {
            SinglyLinkedList<int> target = new SinglyLinkedList<int>();
            target.Insert(1);
            target.Insert(2);
            target.Insert(3);
            target.Insert(4);
            target.Insert(5);

            int index = 5;
            int expected = 1;
            int actual = target.GetItemFromTail(index);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetItemFromTail_GetFifthItemFromListWithMoreThanFiveItems_OutOfRangeException()
        {
            SinglyLinkedList<int> target = new SinglyLinkedList<int>();
            target.Insert(1);
            target.Insert(2);
            target.Insert(3);
            target.Insert(4);
            target.Insert(5);
            target.Insert(6);
            target.Insert(7);
            target.Insert(8);

            int index = 5;
            int expected = 4;
            int actual = target.GetItemFromTail(index);

            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region IsEmpty Tests

        [Test]
        public void IsEmptyTest_EmptyList_ReturnTrue()
        {
            var targetList = new SinglyLinkedList<int>();
            bool actual = targetList.IsEmpty;
            Assert.AreEqual(true, actual);
        }

        [Test]
        public void IsEmptyTest_ListWithOneItem_ReturnFalse()
        {
            var targetList = new SinglyLinkedList<int>();
            targetList.Insert(1);
            bool actual = targetList.IsEmpty;
            Assert.AreEqual(false, actual);
        }

        [Test]
        public void IsEmptyTest_ListWithMoreThanOneItem_ReturnFalse()
        {
            var targetList = new SinglyLinkedList<int>();
            targetList.Insert(1);
            targetList.Insert(2);
            targetList.Insert(3);
            targetList.Insert(4);
            bool actual = targetList.IsEmpty;
            Assert.AreEqual(false, actual);
        }

        #endregion

        #region Count Tests

        [Test]
        public void CountTest_EmptyList_ReturnZero()
        {
            var targetList = new SinglyLinkedList<int>();
            int expected = 0;
            int actual = targetList.Count;
            
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CountTest_ListWithOneElement_ReturnOne()
        {
            var targetList = new SinglyLinkedList<int>();
            targetList.Insert(1);
            int expected = 1;
            int actual = targetList.Count;
            
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void CountTest_ListWithFiveElements_ReturnFive()
        {
            var targetList = new SinglyLinkedList<int>();
            targetList.Insert(1);
            targetList.Insert(2);
            targetList.Insert(3);
            targetList.Insert(4);
            targetList.Insert(5);

            int expected = 5;
            int actual = targetList.Count;
            
            Assert.AreEqual(expected, actual);
        }

        #endregion

        #region Clear Tests

        [Test]
        public void ClearTest_EmptyList_DoNothing()
        {
            var targetList = new SinglyLinkedList<int>();
            targetList.Clear();

            Assert.IsTrue(targetList.Count == 0);
            Assert.IsTrue(targetList.IsEmpty);
        }

        [Test]
        public void ClearTest_NotEmptyList_ClearTheList()
        {
            var targetList = new SinglyLinkedList<int>();
            targetList.Insert(1);
            targetList.Insert(2);
            targetList.Insert(3);
            targetList.Clear();

            Assert.IsTrue(targetList.Count == 0);
            Assert.IsTrue(targetList.IsEmpty);

            targetList.Insert(10);
            targetList.Insert(12);

            Assert.IsTrue(targetList.GetItemFromTail(1) == 12); 
            Assert.IsTrue(targetList.GetItemFromTail(2) == 10);
        }

        #endregion
    }
}