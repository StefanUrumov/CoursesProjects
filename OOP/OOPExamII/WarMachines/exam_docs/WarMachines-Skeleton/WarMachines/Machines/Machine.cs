
namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;
        private IList<string> targets = new List<string>();

        public string Name
        {
            get
            {
                return this.name;
            }
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

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get { return this.attackPoints; }
            set { this.attackPoints = value; }
        }

        public double DefensePoints
        {
            get { return this.defensePoints; }
            set { this.defensePoints = value; }
        }

        public IList<string> Targets
        {
            get { return this.targets; }
            set {
                    try 
	                {	        
	                	this.targets = value; 
	                }
	                catch (NullReferenceException nre)
	                {	                	
	                	Console.WriteLine(nre.Message);
                    }
                }
        }

        public void Attack(string target)
        {
             targets.Add(target);
        }
    }
}
