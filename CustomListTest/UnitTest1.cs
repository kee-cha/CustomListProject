using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void Add_OnePositiveNumberToList()
        {
            //Arrange
            CustomList <int> items = new CustomList<int>();
            double expectedResult = 2;
            double actual;

            //Act
            items.Add(2);
            actual = items[0];

            //Assert
            Assert.AreEqual(expectedResult, actual); //Checking to see if added value is in list
        }
        [TestMethod]
        public void Add_MultiplePositiveNumbersToList()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            double expectedResult = 4;

            //Act
            items.Add(2);
            items.Add(4);
            items.Add(6);
            double actual = items[1];

            //Assert
            Assert.AreEqual(expectedResult, actual); //checking to see if certain value are in list when multiple values are added
        }

        [TestMethod]
        public void Add_CheckingAmountOfItemsInList()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            double expectedResult = 3;
            double actual;

            //Act
            items.Add(2);
            items.Add(4);
            items.Add(6);
            actual = items.Count;

            //Assert
            Assert.AreEqual(expectedResult, actual); //checking to see if the amount of items in list is counted
        }

        [TestMethod]
        public void Add_StringsToList()
        {
            //Arrange
            CustomList<string> items = new CustomList<string>();
            string expectedResult = "Kee";
            //Act
            items.Add("Kee");
            string actualResult = items[0];
            //Assert
            Assert.AreEqual(expectedResult, actualResult); //Checking to see if different data type added are the same in index position
        }

        [TestMethod]
        public void Add_CheckingToSeeIfCountInListGrow()
        {
            //Arrange
            CustomList<string> items = new CustomList<string>();
            int expected = 5;
            //Act
            items.Add("cha");
            items.Add("cha");
            items.Add("cha");
            items.Add("cha");
            items.Add("cha");
            int actual = items.Count;
            //Assert
            Assert.AreEqual(expected, actual); //checking to see if Count grow past the initial array
        }
    }
}
