using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
using System.Collections.Generic;

namespace UnitTestList
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void AddItemsToCustomList()
        {
            // Arrange 
            CustomList<int> list = new CustomList<int>();

            int addNumber = 10;

            int expectedInt = 10;
            int actualInt = 10;

           

            // Act 

            list.Add(addNumber);
            actualInt = list[0];

            // Assert 

            Assert.AreEqual(expectedInt, actualInt);




        }


        [TestMethod]
        public void Count_IntList_Match()
        {
            // Arrange
            CustomList<int> list = new CustomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            int expected = 3;

            // Act 
            int result = list.Count;

            // Assert 
            Assert.AreEqual(expected, result);


        }

        [TestMethod] 
        public void Compare_StringList_Match()
        {

            // Arrange
            CustomList<string> TestList = new CustomList<string>();
            string testString = "Test String";
        


            // Act
            string result = TestList[0];

            // Assert 
            Assert.AreEqual(testString, result);



        }

        [TestMethod]
        public void Add_StringItems_ToList()
        {
            // Arrange
            CustomList<string> TestList = new CustomList<string>();
            string testString = "Test String";
            TestList.Add(testString);




            // Act 
            TestList[0] = "Test String";


            // Assert 
            Assert.AreEqual(testString, TestList[0]);
        }

        [TestMethod]

        public void Add_StringArray_ToList()
        {
            // Arrange 
            CustomList<string> TestList = new CustomList<string>();
            string[] testArray = new string[10];
            TestList.Add(testArray[]);



            // Act 
            TestList[0] = testArray;

            // Assert 
            Assert.AreEqual(testArray, TestList[0]);
        }




    }
}

