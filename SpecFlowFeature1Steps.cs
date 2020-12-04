using System;
using System.Globalization;
using TechTalk.SpecFlow;
using Xunit;

namespace XUnitTestProject1
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private int num1;
        private int num2;
        private float outp;

        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {
            num1 = p0;
        }
        
        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            num2 = p0;
        }
        
        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            outp = num1 + num2;
        }
        
        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            outp = num1 - num2;
        }
        
        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            outp = num1 * num2;
        }
        
        [When(@"the first number is divided by the second")]
        public void WhenTheFirstNumberIsDividedByTheSecond()
        {
            outp = num1 / num2;
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            float expected = p0;
            float actual = outp;
            Assert.Equal(expected, actual);
        }
    }
}
