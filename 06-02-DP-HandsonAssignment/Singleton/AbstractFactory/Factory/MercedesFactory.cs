namespace AbstractFactory
{
    class MercedesFactory : Factory
    {
        public MercedesFactory()
        {

        }
        public override Headlight makeHeadlight()
        {
            MercedesHeadlight mercedesHeadlight = new MercedesHeadlight();
            return mercedesHeadlight;
        }

        public override Tire makeTire()
        {
            MercedesTire mercedesTire = new MercedesTire();
            return mercedesTire;
        }
    }
}
