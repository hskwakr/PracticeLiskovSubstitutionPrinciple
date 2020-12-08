using Xunit;
using PracticeLiskovSubstitutionPrinciple.Sample1;

namespace Test.Sample1
{
    public class TestApple
    {
        public class GetColorMethod
        {
            [Fact]
            public void GetColor_Calculated()
            {
                string color = "red";

                Fruit apple = new Apple(color);

                Assert.Equal(color, apple.GetColor());
            }
        }
    }
}
