

namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private IMachine canEngageMachines;
        private IList<IMachine> assignedToPilot = new List<IMachine>();

        public Pilot(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
            set 
            {
                if (this.name != null)
                {
                    this.name = value;
                }
                else
                {
                    throw new NullReferenceException("Name cannot be null!");
                } 
            }   
        }
        
        public IMachine CanEngageMachines
        {
            get { return this.canEngageMachines; }
            set { this.canEngageMachines = value; }
        }

        public void AddMachine(IMachine machine)
        {
            assignedToPilot.Add(machine);
        }

        public string Report()
        {
            StringBuilder pilotReport = new StringBuilder();
            String machineReport = string.Empty;

            assignedToPilot.OrderBy((m => m.HealthPoints)).ThenBy(m => m.Name);

            StringBuilder ownedMachinesReport = new StringBuilder();
            foreach (var item in assignedToPilot)
            {
                ownedMachinesReport.Append(item.ToString());
            }
            
            if (assignedToPilot.Count == 0)
	        {
		        return String.Format("{0} – {1} machines", this.name, "No");
            }
            else if (assignedToPilot.Count == 1)
	        {
                return  String.Format("{0} – 1 machine {1} {2}", this.name, Environment.NewLine, ownedMachinesReport );
	        }
            else
	        {
                return String.Format("{0} – {1} machines {2} {3}", this.name, assignedToPilot.Count, Environment.NewLine, ownedMachinesReport);
	        }
        }

        
        
    }
}
