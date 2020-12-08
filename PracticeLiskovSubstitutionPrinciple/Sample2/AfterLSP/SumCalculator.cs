﻿using System.Linq;

namespace PracticeLiskovSubstitutionPrinciple.Sample2.AfterLSP
{
    public class SumCalculator : Calculator
    {
        public SumCalculator(int[] numbers) : base(numbers)
        { }

        public override int Calculate()
        {
            return _numbers.Sum();
        }
    }
}
