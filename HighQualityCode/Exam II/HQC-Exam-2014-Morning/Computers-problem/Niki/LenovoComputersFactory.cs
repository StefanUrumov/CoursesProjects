namespace ComputersApplication
{
    public class LenovoComputersFactory : ComputersAbstractFactory
    {
        private Computer[] products;

        public LenovoComputersFactory()
        {
            this.products = GetProducts();
        }

        public override Computer BuildPc()
        {
            return products[0];
        }

        public override Computer BuildServer()
        {
            return products[1];
        }

        public override Computer BuildLaptop()
        {
            return products[2];
        }

        private Computer[] GetProducts()
        {
            LenovoBuildStrategy dell = new LenovoBuildStrategy();
            return dell.BuildComputers();
        }
    }
}
