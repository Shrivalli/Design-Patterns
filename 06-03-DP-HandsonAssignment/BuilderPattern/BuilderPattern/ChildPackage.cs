namespace BuilderPattern
{
    class ChildPackage : Builder
    {
        private Product product = new Product("Child Package");
        public override Product GetProduct()
        {
            return product;
        }

        public override void MakeSavories()
        {
            product.Add("1 Savory");
        }

        public override void MakeSweets()
        {
            product.Add("2 sweets");
        }
    }
}
