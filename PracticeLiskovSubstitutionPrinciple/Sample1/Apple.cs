namespace PracticeLiskovSubstitutionPrinciple.Sample1
{
    public class Apple : Fruit
    {
        public Apple(string color) : base(color)
        { }

        public override string GetColor()
        {
            return _color;
        }
    }
}
