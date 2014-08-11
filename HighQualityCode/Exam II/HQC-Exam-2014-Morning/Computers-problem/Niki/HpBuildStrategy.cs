namespace ComputersApplication
{
    using System.Collections.Generic;

    public class HpBuildStrategy : ComputersBuildStrategy
    {
        //list works & adds faster
        public override Computer[] BuildComputers()
        {
            List<Computer> listComputers = new List<Computer>();

            listComputers.Add(ComputersFactory.BuildDellPc());
            listComputers.Add(ComputersFactory.BuildDellServer());
            listComputers.Add(ComputersFactory.BuildDellLaptop());

            return listComputers.ToArray();
        }
    }
}
