using CustomList;

namespace CustomListTests

{

    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]
        public void AddMethod_AddTwoItems_SecondItemAtIndexOne()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("hello");
            myList.Add("world");

            //Assert
            Assert.AreEqual("world", myList[1]);
        }

        [TestMethod]
        public void AddMethod_AddCountIncreases_CountIncrementsAsItemsAdded()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);

            //Assert
            Assert.AreEqual(3, customList.Count);


        }
        [TestMethod]
        public void AddMethod_AddTwoItems_FirstItemAddedFoundAtZeroIndex()
        {
            CustomList<double> myList = new CustomList<double>();
            //Arrange

            //Act
            myList.Add(1.4);
            myList.Add(2.3);
            myList.Add(3.7);

            //Assert
            Assert.AreEqual(1.4, myList[0]);
        }
        [TestMethod]
        public void AddMethod_CapacityIncrease_CapacityDoublesWhenExceeded()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("hello");
            myList.Add("world");
            myList.Add("How");
            myList.Add("Are");
            myList.Add("You");
            myList.Add("Today");
            //Assert
            Assert.AreEqual(8, myList.Capacity);

        }
        [TestMethod]
        public void AddMethod_ItemsStillInIndex_OneOriginalItemPersistsInSameIndex()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("hello");
            myList.Add("world");
            myList.Add("How");
            myList.Add("Are");
            myList.Add("You");
            myList.Add("Today");
            //Assert
            Assert.AreEqual("world", myList[1]);
        }

    }

}

