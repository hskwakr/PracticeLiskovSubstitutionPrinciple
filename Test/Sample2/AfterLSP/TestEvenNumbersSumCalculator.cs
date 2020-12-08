using Xunit;
using PracticeLiskovSubstitutionPrinciple.Sample2.AfterLSP;

namespace Test.Sample2.AfterLSP
{
    public class TestEvenNumbersSumCalculator
    {
        public class CalculateMethod
        {
            private int[] data = new int[] {
                    5, 7, 9, 8, 1, 6, 4
            };

            [Fact]
            public void Calculate_OnProper_Calculated()
            {
                EvenNumbersSumCalculator calc = new EvenNumbersSumCalculator(data);

                int expected = 18;
                Assert.Equal(expected, calc.Calculate());
            }

            [Fact]
            public void Calculate_OnLiskov_Calculated()
            {
                Calculator calc = new EvenNumbersSumCalculator(data);

                int expected = 18;
                Assert.Equal(expected, calc.Calculate());
            }
        }
    }
}
