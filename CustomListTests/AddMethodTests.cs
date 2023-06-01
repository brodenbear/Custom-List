using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}