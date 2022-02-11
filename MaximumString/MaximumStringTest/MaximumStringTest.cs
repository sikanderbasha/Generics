using MaximumString;
using NUnit.Framework;

namespace MaximumStringTest
{
    public class Tests
    {
       
        [Test]
        public void Givenstring_AtFirstPosition_ReturnsMaximumNumber()
        {
            MaximumCheck maximum = new MaximumCheck();
            string max = maximum.MaxStringof3("third", "first", "second");
            Assert.AreEqual("third", max);
        }
        [Test]
        public void Givenstring_AtSecondPosition_ReturnsMaximumNumber()
        {
            MaximumCheck maximum = new MaximumCheck();
            string max = maximum.MaxStringof3("second", "first", "third");
            Assert.AreEqual("third", max);
        }
        [Test]
        public void Givenstring_AtThirdPosition_ReturnsMaximumNumber()
        {
            MaximumCheck maximum = new MaximumCheck();
            string max = maximum.MaxStringof3("first", "second", "third");
            Assert.AreEqual("third", max);
        }
    }
}