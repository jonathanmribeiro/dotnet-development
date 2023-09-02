namespace Builder.AnimalsExample.Builders
{
    internal class LionBuilder : IAnimalsBuilder
    {
        public Animal Animal { get; set; }

        public LionBuilder()
            => Animal = new();

        public void AddName()
            => Animal.Name = "Lion";

        public void AddWeight()
            => Animal.Weight = 400m;
    }
}
