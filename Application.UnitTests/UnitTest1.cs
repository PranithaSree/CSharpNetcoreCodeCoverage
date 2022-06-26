using Xunit;

namespace Application.UnitTests
{
    public class UnitTest1
    {
        private readonly DummyClass _dummyClass;

        public UnitTest1()
        {
            _dummyClass = new DummyClass();
        }

        [Fact]
        public void Test1()
        {
            Assert.Equal(0, _dummyClass.DummyMethodInt());
        }
        [Fact]
        public void Test2()
        {
            Assert.Equal("TEST", _dummyClass.DummyMethodString());
        }
    }
}