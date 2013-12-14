
namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter
    {
         public bool StealthMode
        {
            get { return this.StealthMode; }
            set { this.StealthMode = value; }
        }

        public void ToggleStealthMode()
        {
            if (this.StealthMode = true)
            {
                this.StealthMode = false;
            }
            else
            {
                this.StealthMode = true;
            }
        }

        public Fighter()
        {
            this.HealthPoints = 200;

        }


        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            this.HealthPoints = 200;
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.StealthMode = stealthMode;
        }

        public override string ToString()
        {
            string stealthMode = "OFF";
            if (this.StealthMode == true)
	        {
                stealthMode = "ON";
	        }

            if (Targets.Count == 0)
	        {

		        return String.Format("- {0} {1} *Type: Fighter {2} *Health: {3} {4} *Attack: {5} {6} *Defense: {7} {8} *Targets: None {9} *Stealth: {10} {11}", this.Name, Environment.NewLine, 
                Environment.NewLine, 
                this.HealthPoints,  Environment.NewLine, 
                this.AttackPoints,  Environment.NewLine, 
                this.DefensePoints, Environment.NewLine, 
                Environment.NewLine, 
                stealthMode, Environment.NewLine
                );
	        }
            else
	        {
                return String.Format("- {0} {1} *Type: Fighter {2} *Health: {3} {4} *Attack: {5} {6} *Defense: {7} {8} *Targets: {9} {10} *Stealth: {11} {12}", this.Name, Environment.NewLine, 
                Environment.NewLine, 
                this.HealthPoints,  Environment.NewLine, 
                this.AttackPoints,  Environment.NewLine, 
                this.DefensePoints, Environment.NewLine, 
                this.Targets.First(), Environment.NewLine, 
                stealthMode, Environment.NewLine  
                );
	        }
            
        }

    }
}
