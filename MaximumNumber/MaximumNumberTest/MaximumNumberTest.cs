using MaximumNumber;
using NUnit.Framework;

namespace MaximumNumberTest
{
    public class Tests
    {
       
        [Test]
        public void Givendouble_AtFirstPosition_ReturnsMaximumNumber()
        {
            MaximumCheck maximum = new MaximumCheck();
            double max = maximum.MaxNumberof3(3.5, 2.3, 1.2);
            Assert.AreEqual(3.5, max);
        }
        [Test]
        public void Givendouble_AtSecondPosition_ReturnsMaximumNumber()
        {
            MaximumCheck maximum = new MaximumCheck();
            double max = maximum.MaxNumberof3(2.3, 3.5, 1.2);
            Assert.AreEqual(3.5, max);
        }
        [Test]
        public void Givendouble_AtThirdPosition_ReturnsMaximumNumber()
        {
            MaximumCheck maximum = new MaximumCheck();
            double max = maximum.MaxNumberof3(1.2, 2.3, 3.5);
            Assert.AreEqual(3.5, max);
        }
    }
}