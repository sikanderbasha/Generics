using MaximumNumber;
using NUnit.Framework;

namespace MaximumNumberTest
{
    public class Tests
    {
        [Test]
        public void GivenIntegerValue()
        {
            MaximumCheck maximum = new MaximumCheck();
            int max = maximum.MaxNumberof3(1, 2, 3);
            Assert.AreEqual(3, max);
        }
    }
}