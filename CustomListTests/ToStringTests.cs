using CustomList;

namespace CustomListTests
{
    [TestClass]
    public class ToStringTests
    {
        [TestMethod]
        public void ToString_ReturnsExpectedResult_ForListOfStrings()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("Item 1");
            myList.Add("Item 2");
            myList.Add("Item 3");

            //Act
            string listAsString = myList.ToString();

            //Assert
            string expectedResult = "[Item 1, Item 2, Item 3]";
            Assert.AreEqual(listAsString, expectedResult);
        }
        [TestMethod]
        public void ToString_ReturnsExpectedResult_ForListOfInts()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.Add(3);
            myList.Add(5);

            //Act
            string listAsString = myList.ToString();

            //Assert
            string expectedResult = "[1, 3, 5]";
            Assert.AreEqual(listAsString, expectedResult);

        }
        [TestMethod]
        public void ToString_ReturnsExpectedResult_ForEmptyList()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();

            //Act
            string listAsString = myList.ToString();

            //Assert
            string expectedResult = "[]";
            Assert.AreEqual(listAsString, expectedResult);

        }
    }
}
