namespace Tests1.SuperNameSpace;

public class UnitTest1
{
    [Fact]
    [Trait("Var1", "2")]
    public void ABCTest()
    {
        throw new ArgumentException("abc");
    }

    public class MySupertest
    {
        [Theory]
        [InlineData("""(1.2.3.4)""", 123)]
        [InlineData("""(127.0.0.1)""", 123)]
        public void CD(string myip, int smth)
        {
            throw new ArgumentException(myip);
        }
        
        [Fact]
        [Trait("Var1", "2")]
        public void FE()
        {
        }
    }
}