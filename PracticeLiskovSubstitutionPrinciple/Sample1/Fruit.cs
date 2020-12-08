namespace PracticeLiskovSubstitutionPrinciple.Sample1
{
    public abstract class Fruit
    {
        protected string _color;

        public Fruit(string color)
        {
            _color = color;
        }

        public virtual string GetColor()
        {
            return _color;
        }
    }
}
