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
            CustomList<string> result = myList1 + myListTwo;


            //Assert
            Assert.AreEqual("hi", result[0]);
            Assert.AreEqual("hello", result[1]);
            Assert.AreEqual("b", result[7]);
            //3 Asserts that show results in the index locations necessary
        }
        [TestMethod]
        public void OperatorOverload_ListLength_SecondListLongerThanFirstList()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myListTwo = new CustomList<int>();

            myList1.Add(2);
            myList1.Add(4);
            myList1.Add(6);
            myList1.Add(8);

            myListTwo.Add(1);
            myListTwo.Add(3);
            myListTwo.Add(5);
            myListTwo.Add(7);
            myListTwo.Add(9);
            myListTwo.Add(11);

            //Act
            CustomList<int> result = myList1 + myListTwo;


            //Assert
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(4, result[1]);
            Assert.AreEqual(7, result[7]);
            //3 Asserts that show results in the index locations necessary
        }
        [TestMethod]
        public void OperatorOverload_EmptyList_EmptyListYieldsSameResult()
        {
            //Arrange
            CustomList<int> myList1 = new CustomList<int>();
            CustomList<int> myListTwo = new CustomList<int>();

            myList1.Add(2);
            myList1.Add(4);
            myList1.Add(6);
            myList1.Add(8);


            //Act
            CustomList<int> result = myList1 + myListTwo;


            //Assert
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(4, result[1]);
            Assert.AreEqual(8, result[3]);
            //3 Asserts that show results in the index locations necessary
        }
    }
}
