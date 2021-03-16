namespace BuilderPattern
{
    abstract class Builder
    {
        public abstract void MakeSweets();
        public abstract void MakeSavories();

        public abstract Product GetProduct();
    }
}
