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
            CustomList<int> items = new CustomList<int>();
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

            Assert.AreEqual(expected, actual); //Checking to see if one integer is removed

        }

        [TestMethod]
        public void Remove_FirstOccuranceOfSameNumberInList()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>() { 2, 3, 5, 3, 7 };
            int expected = 3;

            //Act
            items.Remove(3);
            int actual = items[2];

            //Assert
            Assert.AreEqual(expected, actual); //Checking to see first occurrance is removed only

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
            Assert.AreEqual(expected, actual); //Checking to see if the older of list remains the same after removing one number
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
            Assert.AreEqual(expected, actual); //Checking to see if count changes after removing one number
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Remove_CheckToSeeIfLastNumberRemoveIfIndexExist()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>() { 1, 2, 3, 4, 5 };

            //Act
            items.Remove(5);
            int actual = items[4];

            //Assert Checking to see if index range changes after removing last number

        }

        [TestMethod]
        public void Remove_OnePositiveNumberNotInList()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>() { 1, 2, 3, 4, 5 };
            int expected = 1;
            int expected1 = 2;
            int expected2 = 3;
            int expected3 = 4;
            int expected4 = 5;

            //Act
            items.Remove(100);
            int actual = items[0];
            int actual1 = items[1];
            int actual2 = items[2];
            int actual3 = items[3];
            int actual4 = items[4];

            //Assert
            Assert.AreEqual(expected,actual);
            Assert.AreEqual(expected1,actual1);
            Assert.AreEqual(expected2,actual2);
            Assert.AreEqual(expected3,actual3);
            Assert.AreEqual(expected4,actual4);
        }

        [TestMethod]
        public void ToString_CheckToSeeIfOnePosisitiveNumberIsString()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>() { 1 };
            string expected = "1";
            //Act
            string actual = items.ToString();
            //Assert
            Assert.AreEqual(expected, actual); //Checking to see if integer is converted to string
        }

        [TestMethod]
        public void ToString_CheckToSeeIfCountIsSameWhenConvertList()
        {
            //Arrange
            CustomList<string> items1 = new CustomList<string>() { "kee", "cha" };
            int expected = 2;

            //Act
            items1.ToString();
            int actual = items1.Count;

            //Assert
            Assert.AreEqual(expected, actual); //Checking to see if count remains the same after converting list to string
        }

        [TestMethod]
        public void ToString_ListWithNoElementsInside()
        {
            //Arrange
            CustomList<string> items = new CustomList<string>();
            string expected = "";

            //Act

            string actual = items.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Plus_OneListToAnotherList()
        {
            //Arrange
            CustomList<string> items1 = new CustomList<string>() { "kee", "cha" };
            CustomList<string> items2 = new CustomList<string>() { "houa", "Cha" };
            CustomList<string> items = new CustomList<string>();
            string expected = "cha";
            string expected1 = "houa";


            //Act
            items = items1 + items2;
            string actual1 = items[1];
            string actual2 = items[2];


            //Assert

            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected1, actual2);

        }

        [TestMethod]
        public void Plus_CheckTotalCountOfNewList()
        {
            {
                //Arrange
                CustomList<string> items1 = new CustomList<string>() { "kee", "cha" };
                CustomList<string> items2 = new CustomList<string>() { "houa", "Cha" };
                CustomList<string> items = new CustomList<string>();
                int expected = 4;

                //Act
                items = items1 + items2;
                int actual = items.Count;

                //Assert
                Assert.AreEqual(expected, actual);
            }
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void Plus_CheckToSeeIfIndexDoesNotExist()
        {
            //Arrange
            CustomList<string> items1 = new CustomList<string>() { "kee", "cha" };
            CustomList<string> items2 = new CustomList<string>() { "houa", "Cha" };
            CustomList<string> items = new CustomList<string>();

            //Act
            items = items1 + items2;
            string actual = items[4];

            //Assert
        }

        [TestMethod]
        public void Plus_CheckOrderOfCombineList()
        {
            //Arrange
            CustomList<string> items1 = new CustomList<string>() { "kee", "cha" };
            CustomList<string> items2 = new CustomList<string>() { "houa", "Cha" };
            CustomList<string> items = new CustomList<string>();
            string expected = "kee";
            string expected1 = "cha";
            string expected2 = "houa";
            string expected3 = "Cha";

            //Act
            items = items1 + items2;
            string actual = items[0];
            string actual1 = items[1];
            string actual2 = items[2];
            string actual3 = items[3];

            //Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
    }
}

