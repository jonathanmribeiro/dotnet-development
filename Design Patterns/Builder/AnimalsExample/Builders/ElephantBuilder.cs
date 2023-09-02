namespace Builder.AnimalsExample.Builders
{
    internal class ElephantBuilder : IAnimalsBuilder
    {
        public Animal Animal { get; set; }

        public ElephantBuilder()
            => Animal = new();

        public void AddName()
            => Animal.Name = "Elephant";

        public void AddWeight()
            => Animal.Weight = 10000m;
    }
}
