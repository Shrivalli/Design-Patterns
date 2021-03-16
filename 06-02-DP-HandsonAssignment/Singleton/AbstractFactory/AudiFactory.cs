namespace AbstractFactory
{
    class AudiFactory : Factory
    {
        public override Headlight makeHeadlight()
        {
            AudiHeadlight audiHeadlight = new AudiHeadlight();
            return audiHeadlight;
        }

        public override Tire makeTire()
        {
            AudiTire audiTire = new AudiTire();
            return audiTire;
        }
    }
}
