
namespace _1.CookingProgram
{
    using System;
    using System.Linq;

    class Carrot : IVegetable
    {
        //interface fields
        private string kind;
        private double size;
        private double weight;
        private bool isPeeled;
        private bool isGoodToEat;

        //properties
        public bool IsGoodToEat
        {
            get
            {
                return this.isGoodToEat;
            }
            set
            {
                this.isGoodToEat = value;
            }
        }

        public bool IsPeeled
        {
            get
            {
                return this.isPeeled;
            }
            set
            {
                this.isPeeled = value;
            }
        }

        public double Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
        public string Kind
        {
            get
            {
                return this.kind;
            }
            set
            {
                this.kind = value;
            }
        }
    }    
}
