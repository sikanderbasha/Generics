using MaximumNumber;
using NUnit.Framework;

namespace MaximumNumberTest
{
    public class Tests
    {
       
        [Test]
        public void GivenInteger_AtFirstPosition_ReturnsMaximumNumber()
        {
            MaximumCheck maximum = new MaximumCheck();
            int max = maximum.MaxNumberof3(3, 2, 1);
            Assert.AreEqual(3, max);
        }
        [Test]
        public void GivenInteger_AtSecondPosition_ReturnsMaximumNumber()
        {
            MaximumCheck maximum = new MaximumCheck();
            int max = maximum.MaxNumberof3(2, 3, 1);
            Assert.AreEqual(3, max);
        }
        [Test]
        public void GivenInteger_AtThirdPosition_ReturnsMaximumNumber()
        {
            MaximumCheck maximum = new MaximumCheck();
            int max = maximum.MaxNumberof3(1, 2, 3);
            Assert.AreEqual(3, max);
        }
    }
}