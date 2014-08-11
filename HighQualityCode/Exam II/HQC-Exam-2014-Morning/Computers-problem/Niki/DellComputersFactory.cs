namespace ComputersApplication
{
    public class DellComputersFactory : ComputersAbstractFactory
    {
        private Computer[] products;

        public DellComputersFactory()
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
            DellBuildStrategy dell = new DellBuildStrategy();
            return dell.BuildComputers();
        }
    }
}
