namespace PracticeLiskovSubstitutionPrinciple.Sample1
{
    public class Orange : Fruit
    {
        public Orange(string color) : base(color)
        { }

        public override string GetColor()
        {
            return _color;
        }
    }
}
