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

        [TestMethod]
        public void Remove_OnePositiveNumberInList()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>() { 1, 2, 3 }; 
            int expected = 2;

            //Act
            items.Remove(1);
            int actual = items[0];

            //Assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_FirstOccuranceOfSameNumberInList()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>() { 2, 3, 5, 3, 7 };
            int expected = 5;
            //Act
            items.Remove(3);
            int actual = items[1];
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_CheckListOrderAfterRemovingOneNumber()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>() { 2, 6, 5, 6, 7 };
            int expected = 2;
            int expected1 = 5;
            int expected2 = 6;
            int expected3 = 7;
            //Act
            items.Remove(6);
            int actual = items[0];
            int actual1 = items[1];
            int actual2 = items[2];
            int actual3 = items[3];

            //Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }

        [TestMethod]
        public void Remove_CheckCountAfterOneNumberIsRemove()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int expected = 4;
            //Act
            items.Remove(1);
            int actual = items.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Remove_CheckToSeeIfLastNumberRemoveIfIndexExist()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>() { 1, 2, 3, 4, 5 };

            //Act
            items.Remove(5);
            int actual = items[5];
            //Assert
        }
    }
}
