using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1.Tests
{
    [TestClass()]
    public class myFuncTests
    {
        [TestMethod()]
        public void mullTest()
        {
            //arrange
            int[] array = { 1, 2, 0, 5, 0, 4 };
            int[] indArray = { 0, 1, 2, 3, 4, 5 };
            int expected = 40;

            //act 
            int result = myFunc.mull(indArray, array);

            //assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]
        public void minElementTest()
        {
            //arrange
            int[] array = { -2, 4, 5, -23, 1 };
            int index;
            int expectedIndex = 3;
            int expectedValue = -23;

            //act 
            int resultValue = myFunc.minElement(array, out index);

            //assert
            Assert.AreEqual(expectedValue, resultValue);
            Assert.AreEqual(expectedIndex, index);
        }

        [TestMethod()]
        public void reverseElementTest()
        {
            //arrange
            float[] array = { 1.0f, 2.0f, 3.0f, 4.0f };
            float[] expected = { 4.0f, 3.0f, 2.0f, 1.0f };

            //act
            myFunc.reverseElement(ref array);

            //Assert
            for(int i = 0; i < array.Length; ++i)
            {
                if (array[i] == expected[i]) continue;
                else Assert.Fail();
            }
        }
    }
}