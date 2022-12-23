namespace ex_10
{
    internal class SystemSecurity : DecoratorOptions
    {
        public SystemSecurity(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Increased security";
            Description = p.Description + ". " + this.Title + ". Front side airbags, ESP - vehicle dynamic stabilization system";
        }

        public override double GetCost()
        {
            return AutoProperty.GetCost() + 20.99;
        }
    }
}
