namespace ex_10
{
    internal class MediaNAV : DecoratorOptions
    {

        public MediaNAV(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Modern";
            Description = p.Description + ". " + this.Title + ". Updated multimedia navigation system";
        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 15.99;
        }
    }
}
