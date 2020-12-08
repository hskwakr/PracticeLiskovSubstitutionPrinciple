using Xunit;
using PracticeLiskovSubstitutionPrinciple.Sample2.BeforeLSP;

namespace Test.Sample2.BeforeLSP
{
    public class TestEvenNumbersSumCalculator
    {
        public class CalculateMethod
        {
            [Fact]
            public void Calculate_OnProper_Calculated()
            {
                int[] data = new int[] {
                    5, 7, 9, 8, 1, 6, 4
                };

                EvenNumbersSumCalculator calc = new EvenNumbersSumCalculator(data);

                int expected = 18;
                Assert.Equal(expected, calc.Calculate());
            }

            [Fact]
            public void Calculate_OnLiskov_Calculated()
            {
                int[] data = new int[] {
                    5, 7, 9, 8, 1, 6, 4
                };

                SumCalculator calc = new EvenNumbersSumCalculator(data);

                int expected = 18;
                Assert.Equal(expected, calc.Calculate());
            }
        }
    }
}
