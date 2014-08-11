namespace ComputersApplication
{
    public class HpComputersFactory : ComputersAbstractFactory
    {
         private Computer[] products;

        public HpComputersFactory()
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
            HpBuildStrategy hp = new HpBuildStrategy();
            return hp.BuildComputers();
        }
    }
}
