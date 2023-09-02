namespace Builder.AnimalsExample
{
    internal interface IAnimalsBuilder
    {
        Animal Animal { get; set; }
        void AddName();
        void AddWeight();
    }
}
