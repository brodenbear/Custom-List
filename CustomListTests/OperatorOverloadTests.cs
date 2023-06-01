using CustomList;


namespace CustomListTests
{
    [TestClass]
    public class OperatorOverloadTests
    {
        [TestMethod]
        public void OperatorOverload_ListLength_FirstListLongerThanSecondList()
        {
            //Arrange
            CustomList<string> myList1 = new CustomList<string>();
            CustomList<string> myListTwo = new CustomList<string>();

            myList1.Add("hi");
            myList1.Add("hello");
            myList1.Add("today");
            myList1.Add("is");
            myList1.Add("a");
            myList1.Add("good");

            myListTwo.Add("a");
            myListTwo.Add("b");
            myListTwo.Add("c");
            myListTwo.Add("d");


            //Act
            CustomList<string> result = myList1+myListTwo;


            //Assert
            Assert.AreEqual("hi", result[0]);
            Assert.AreEqual("hello", result[1]);
            Assert.AreEqual("b", result[7]);
            //3 Asserts that show results in the index locations necessary
        }
    }
}
