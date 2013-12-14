

namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;

    public class Tank : Machine, ITank
    {
        public bool DefenseMode
        {
            get { return defenseMode; }
            set { this.defenseMode = value; }
        }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode == true)
            {
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }
            else
            {
                this.DefenseMode = false;
                this.DefensePoints -= 30;
                this.AttackPoints += 40;
            }

        }

        public Tank()
        {
            this.HealthPoints = 100;
            this.DefenseMode = true;
            this.DefensePoints += 30;
            this.AttackPoints -= 40;
        }

        public Tank(string name, double attackPoints, double defensePoints)
        {
            this.HealthPoints = 100;
            this.DefenseMode = true;
            this.DefensePoints += 30;
            this.AttackPoints -= 40;           
        }

        public override string ToString()
        {
            string defMode = "ON";
            if (this.DefenseMode == true)
	        {
		        defMode = "OFF";
            }

            if (Targets.Count == 0)
	        {
		        return String.Format("- {0} {1} *Type: Tank {2} *Health: {3} {4} *Attack: {5} *Defense: {6} {7} *Targets: None {8} *Defense: {9} {10}", this.Name, Environment.NewLine, 
                Environment.NewLine, 
                this.HealthPoints,  Environment.NewLine, 
                this.AttackPoints,  Environment.NewLine, 
                this.DefensePoints, Environment.NewLine, 
                Environment.NewLine, 
                defMode, Environment.NewLine 
                );
	        }
            else
	        {
                return String.Format("- {0} {1} *Type: Tank {2} *Health: {3} {4} *Attack: {5} *Defense: {6} {7} *Targets: {8} {9} *Defense: {10} {11}", this.Name, Environment.NewLine, 
                Environment.NewLine, 
                this.HealthPoints,  Environment.NewLine, 
                this.AttackPoints,  Environment.NewLine, 
                this.DefensePoints, Environment.NewLine, 
                this.Targets.First(), Environment.NewLine, 
                defMode, Environment.NewLine 
                );
	        }
            
        }

        public bool defenseMode { get; set; }
    }
}
