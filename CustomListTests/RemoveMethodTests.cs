using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class RemoveMethodTests
    {
        [TestMethod]

        public void RemoveMethod_CountDecreases_CountDecrementsWhenItemRemoved()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("hello");
            myList.Add("world");
            myList.Remove("hello");

            //Assert
            Assert.AreEqual(1, myList.Count);
        }
        [TestMethod]
        public void RemoveMethod_MethodTrue_MethodReturnedTrueWhenItemRemoved()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("hello");
            myList.Add("world");

            //Act
            bool removed = myList.Remove("hello");

            //Assert
            Assert.IsTrue(removed);
        }
        [TestMethod]
        public void RemoveMethod_CountAccurate_CountDoesNotDecrementWhenRemoveItemNotInList()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("hello");
            myList.Add("world");

            //Act
            myList.Remove("hi");

            //Assert
            Assert.AreEqual(2, myList.Count);
        }
        [TestMethod]
        public void RemoveMethod_ItemsShift_ItemsShiftDownInIndexFillingIndexOfRemovedItem()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            //Act
            myList.Remove(2);

            //Assert
            Assert.AreEqual(4, myList[2]);
            Assert.AreEqual(5, myList[3]);
            //Tested 2 Asserts to further ensure accuracy
        }
        [TestMethod]
        public void RemoveMethod_RemoveOne_OnlyFirstInstanceOfObjectRemoved()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(1);
            myList.Add(2);

            //Act
            myList.Remove(2);

            //Assert
            Assert.AreEqual(2, myList[5]);
            Assert.AreEqual(6, myList.Count);
            //Tested 2 Asserts to further ensure accuracy
        }
    }
}
