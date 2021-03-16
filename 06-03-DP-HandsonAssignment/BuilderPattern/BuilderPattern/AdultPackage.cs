namespace BuilderPattern
{
    class AdultPackage : Builder
    {
        private Product product = new Product("Adult Package");

        public override Product GetProduct()
        {
            return product;
        }

        public override void MakeSavories()
        {
            product.Add("2 Savories");
        }

        public override void MakeSweets()
        {
            product.Add("2 Sweets");
        }
    }
}
