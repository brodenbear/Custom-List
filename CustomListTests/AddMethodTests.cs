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
    }
}