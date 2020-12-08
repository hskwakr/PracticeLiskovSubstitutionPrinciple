using Xunit;
using PracticeLiskovSubstitutionPrinciple.Sample2.AfterLSP;

namespace Test.Sample2.AfterLSP
{
    public class TestSumCalculator
    {
        public class CalculateMethod
        {
            private int[] data = new int[] {
                    5, 7, 9, 8, 1, 6, 4
            };

            [Fact]
            public void Calculate_Calculated()
            {
                SumCalculator calc = new SumCalculator(data);

                int expected = 40;
                Assert.Equal(expected, calc.Calculate());
            }

            [Fact]
            public void Calculate_OnLiskov_Calculated()
            {
                Calculator calc = new SumCalculator(data);

                int expected = 40;
                Assert.Equal(expected, calc.Calculate());
            }
        }
    }
}
