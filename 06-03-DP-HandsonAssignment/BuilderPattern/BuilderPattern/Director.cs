namespace BuilderPattern
{
    class Director
    {
        public void GiveOrder(Builder builder)
        {
            builder.MakeSweets();
            builder.MakeSavories();

        }

    }
}
