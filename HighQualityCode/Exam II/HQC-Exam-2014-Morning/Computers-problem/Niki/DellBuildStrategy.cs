namespace ComputersApplication
{
    using System.Collections.Generic;

    public class DellBuildStrategy : ComputersBuildStrategy
    {
        //list works & adds faster
        public override Computer[] BuildComputers()
        {
            List<Computer> listComputers = new List<Computer>();

            listComputers.Add(ComputersFactory.BuildHpPc());
            listComputers.Add(ComputersFactory.BuildHpServer());
            listComputers.Add(ComputersFactory.BuildHpLaptop());

            return listComputers.ToArray();
        }
    }
}
