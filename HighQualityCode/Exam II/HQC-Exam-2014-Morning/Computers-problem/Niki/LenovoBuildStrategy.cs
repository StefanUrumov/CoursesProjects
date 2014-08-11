namespace ComputersApplication
{
    using System.Collections.Generic;

    public class LenovoBuildStrategy : ComputersBuildStrategy
    {
        public override Computer[] BuildComputers()
        {
            List<Computer> listComputers = new List<Computer>();

            listComputers.Add(ComputersFactory.BuildLenovoPc());
            listComputers.Add(ComputersFactory.BuildLenovoServer());
            listComputers.Add(ComputersFactory.BuildLenovoLaptop());

            return listComputers.ToArray();
        }
    }
}
