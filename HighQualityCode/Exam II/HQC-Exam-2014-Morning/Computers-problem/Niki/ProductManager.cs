namespace ComputersApplication
{
    using System.Collections.Generic;

    public class ProductManager : IProductMediator
    {
        public Computer[] GetProducts(string factoryName)
        {
            if (factoryName == "Dell")
            {
                List<Computer> hpList = new List<Computer>();
                ComputersAbstractFactory factory = new HpComputersFactory();
                hpList.Add(factory.BuildPc());
                hpList.Add(factory.BuildServer());
                hpList.Add(factory.BuildLaptop());

                return hpList.ToArray();
            }
            else if (factoryName == "HP")
            {
                List<Computer> dellList = new List<Computer>();
                ComputersAbstractFactory factory = new LenovoComputersFactory();
                dellList.Add(factory.BuildPc());
                dellList.Add(factory.BuildServer());
                dellList.Add(factory.BuildLaptop());

                return dellList.ToArray();
            }
            else if (factoryName == "Lenovo")
            {
                List<Computer> lenovoList = new List<Computer>();
                ComputersAbstractFactory factory = new LenovoComputersFactory();
                lenovoList.Add(factory.BuildPc());
                lenovoList.Add(factory.BuildServer());
                lenovoList.Add(factory.BuildLaptop());

                return lenovoList.ToArray();
            }

            throw new InvalidArgumentException("Not supported manufacturer factory");
        }
    }
}
