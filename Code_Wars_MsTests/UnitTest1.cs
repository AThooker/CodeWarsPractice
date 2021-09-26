using Code_Wars_Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Code_Wars_MsTests
{
    [TestClass]
    public class UnitTest1
    {
        CodeWarsUI _console;
        [TestInitialize]
        public void TestInitialize()
        {
            _console = new CodeWarsUI();
        }

        //Testing Perfect Squares
        [TestMethod]
        public void ShouldReturnTrue()
        {
            Assert.AreEqual(true, _console.IsSquare(25), "Something went very wrong here");
            Assert.AreEqual(true, _console.IsSquare(36), "Something went very wrong here");
            Assert.AreEqual(true, _console.IsSquare(49), "Something went very wrong here");
            Assert.AreEqual(true, _console.IsSquare(64), "Something went very wrong here");
        }
        [TestMethod]
        public void ShouldReturnFalse()
        {
            Assert.AreEqual(false, _console.IsSquare(46), "Hazaa, we failed intentionally");
            Assert.AreEqual(false, _console.IsSquare(35), "Hazaa, we failed intentionally");
        }



        //Testing AddBinaryNum

        [TestMethod]
        public void TestDoesMatch()
        {
            Assert.AreEqual("1", _console.AddBinarySum(0, 1));
            Assert.AreEqual("1101", _console.AddBinarySum(6, 7));
            Assert.AreEqual("110010", _console.AddBinarySum(10, 40));
        }
        [TestMethod]
        public void TestDoesNotMatch()
        {
            Assert.AreNotEqual("1", _console.AddBinarySum(0, 2));
            Assert.AreNotEqual("101", _console.AddBinarySum(6, 0));
            Assert.AreNotEqual("110", _console.AddBinarySum(4, 3));
        }


        //Testing FriendOrFoe List of 4 letter names
        //[TestMethod]
        //public void NotEmptyList()
        //{
        //    string[] testArray = new string[] { "Erik", "Mike", "Sam", "Beth", "Sue" };
        //    string[] friends = { "Erik", "Mike", "Beth"};
        //    var friendList = _console.FriendOrFoe(testArray);
        //    Assert.
        //}


        //Test for triangle (just has to be greater than 0)

        [TestMethod]
        public void IsTriangle()
        {
            Assert.AreEqual(true, _console.IsTriangle(1, 2, 3));
            Assert.AreEqual(true, _console.IsTriangle(8, 9, -1));
        }

        [TestMethod]
        public void IsNotTriangle()
        {
            Assert.AreEqual(false, _console.IsTriangle(-1, 0, -2));
            Assert.AreEqual(false, _console.IsTriangle(-7, 5, -20));
        }

        //[TestMethod]
        //public void FailTriangleTest()
        //{
        //    Assert.AreEqual(true, _console.IsTriangle(-1, 0, -9), "You should see me pop up");
        //}

        [TestMethod]
        public void XandOTester()
        {
            Assert.IsTrue(_console.XorOTester("XXXooo"));
            Assert.IsTrue(_console.XorOTester("XxXjgkooo"));
            Assert.IsTrue(_console.XorOTester("fffff"));
        }


        //Isogram Tests
        [TestMethod]
        public void IsIsogramTestForFalse()
        {
            Assert.IsFalse(_console.IsIsogram("aaa"));
            Assert.IsFalse(_console.IsIsogram("    "));
            Assert.IsFalse(_console.IsIsogram("WonderIfThisWillwork"));
        }
        [TestMethod]
        public void TestIsogramForTrue()
        {
            Assert.IsTrue(_console.IsIsogram("asdfghjk"));
            Assert.IsTrue(_console.IsIsogram("mnvb"));
            Assert.IsTrue(_console.IsIsogram("mnb hjl"));
        }
    }
}
