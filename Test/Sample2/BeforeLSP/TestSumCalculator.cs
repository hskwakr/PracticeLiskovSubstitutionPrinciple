using Xunit;
using PracticeLiskovSubstitutionPrinciple.Sample2.BeforeLSP;

namespace Test.Sample2.BeforeLSP
{
    public class TestSumCalculator
    {
        public class CalculateMethod
        {
            [Fact]
            public void Calculate_Calculated()
            {
                int[] data = new int[] {
                    5, 7, 9, 8, 1, 6, 4
                };

                SumCalculator calc = new SumCalculator(data);

                int expected = 40;
                Assert.Equal(expected, calc.Calculate());
            }
        }
    }
}
