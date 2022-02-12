using MaximumNumber;
using NUnit.Framework;

namespace MaximumNumberTest
{
    public class Tests
    {
       

        [Test]
        public void GivenNumber_AtFirstPosition_ReturnsMaximumNumber()
        {
            MaximumCheck<int> maximum = new MaximumCheck<int>();
            int max = maximum.Maximumof3(3,2,1);
            Assert.AreEqual(3, max);
        }
        [Test]
        public void GivenFloat_AtSecondPosition_ReturnsMaximumNumber()
        {
            MaximumCheck<double> maximum = new MaximumCheck<double>();
            double max = maximum.Maximumof3(2.1,3.5,1.3);
            Assert.AreEqual(3.5, max);
        }
        [Test]
        public void Givenstring_AtThirdPosition_ReturnsMaximumNumber()
        {
            MaximumCheck<string> maximum = new MaximumCheck<string>();
            string max = maximum.Maximumof3("first", "second", "third");
            Assert.AreEqual("third", max);
        }
    }
}