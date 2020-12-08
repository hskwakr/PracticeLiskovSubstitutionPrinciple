using Xunit;
using PracticeLiskovSubstitutionPrinciple.Sample1;

namespace Test.Sample1
{
    public class TestOrange
    {
        public class GetColorMethod
        {
            [Fact]
            public void GetColor_Calculated()
            {
                string color = "orange";

                Fruit orange = new Orange(color);

                Assert.Equal(color, orange.GetColor());
            }
        }
    }
}
