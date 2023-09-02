namespace Builder.AnimalsExample
{
    internal class AnimalsDirector
    {
        private readonly IAnimalsBuilder _builder;
        
        public AnimalsDirector(IAnimalsBuilder builder)
            => _builder = builder;

        public void BuildNamelessAnimal()
        {
            _builder.AddWeight();
        }

        public void BuildFullAnimal()
        {
            _builder.AddName();
            _builder.AddWeight();
        }
    }
}
