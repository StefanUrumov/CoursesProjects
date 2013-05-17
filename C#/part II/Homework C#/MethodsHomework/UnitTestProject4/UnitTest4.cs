using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _04.RepeatingCounter;

namespace UnitTestProject4
{
    [TestClass]
    public class UnitTest4
    {
        static decimal maxValue = decimal.MaxValue;
        static decimal minValue = decimal.MinValue;

        [TestMethod]
        public void TestMethod1()
        {
            //data to check
            decimal[] array = { maxValue, minValue, minValue, maxValue };

            //add test data
            CheckCounter.CountElements = minValue;
            CheckCounter.CountElements(numArray);
            

            //assert
            Assert.AreEqual(2, CheckCounter.CountElements.counter);
         

            //we  null the counter in order to reset the counter in the original class, because it's static and currently set to 2.
            CheckCounter.CountElements.counter = 0;
        }

        [TestMethod]
        public void TestWithMaxValue()
        {
            //data to check
            decimal[] array = { 17, 5212, 17, 5212, maxValue, maxValue, maxValue, 0 };

            //add test data
            CheckCounter.CountElements = maxValue;
            CheckCounter.CountElements(numArray);
            
            //assert
            Assert.AreEqual(3, CheckCounter.CountElements.counter);
        }
        
    }
}
