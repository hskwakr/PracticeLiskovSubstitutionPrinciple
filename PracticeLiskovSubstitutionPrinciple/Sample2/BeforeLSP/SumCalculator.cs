using System.Linq;

namespace PracticeLiskovSubstitutionPrinciple.Sample2.BeforeLSP
{
    public class SumCalculator
    {
        protected readonly int[] _numbers;

        public SumCalculator(int[] numbers)
        {
            _numbers = numbers;
        }

        public virtual int Calculate()
        {
            return _numbers.Sum();
        }
    }
}
