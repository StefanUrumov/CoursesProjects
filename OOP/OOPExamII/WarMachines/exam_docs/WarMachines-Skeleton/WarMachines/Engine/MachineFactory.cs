namespace WarMachines.Engine
{
    using System;
    using System.Collections.Generic;
    using WarMachines.Interfaces;
    using WarMachines.Machines;
    

    public class MachineFactory : IMachineFactory
    {
        //implement and use Singleton desing pattern for the MachineFactory
        //private static MachineFactory instance;
   
        private IList<string> alreadyHired = new List<string>();
        private IList<ITank> tanks = new List<ITank>();
        private IList<IFighter> fighters = new List<IFighter>();        
        private IList<IPilot> alreadyHiredPilots = new List<IPilot>();
        

        //private MachineFactory() { }

        //public static MachineFactory MFInstance
        //{
        //   get 
        //   {
        //      if (instance == null)
        //      {
        //         instance = new MachineFactory();
        //      }
        //      return instance;
        //   }
        //}


        public IPilot HirePilot(string name)
        {
            IPilot newPilot = new Pilot(name);
            
            foreach (var pilot in alreadyHired)
            {
                if (name == pilot)
                {
                    string pilotString = String.Format("Pilot {0} hired", name);
                  throw new IndexOutOfRangeException(pilotString);
                }
            }
            alreadyHiredPilots.Add(newPilot);
           alreadyHired.Add(name);
           return newPilot;
           
        }

        public string Report(string name)
        {
            foreach (var pilot in alreadyHiredPilots)
            {
                if (name == pilot.Name)
                {
                    return pilot.Report();
                }
            }


        }

        public ITank ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            ITank newTank = new Tank( name, attackPoints, defensePoints);
            tanks.Add(newTank);
            return newTank;
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            IFighter newFighter = new Fighter(name, attackPoints,defensePoints, stealthMode);
            fighters.Add(newFighter);
            return newFighter;
        }
    }
}
