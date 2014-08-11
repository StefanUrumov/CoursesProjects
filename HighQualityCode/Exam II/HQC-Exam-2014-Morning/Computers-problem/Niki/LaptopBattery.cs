namespace ComputersApplication
{
    public class LaptopBattery
    {
        //constructors
        internal LaptopBattery()
        {
            this.Percentage = 100 / 2;
        }

        //properties
        internal int Percentage { get; set; }

        //methods
        internal void Charge(int percentLeft)
        {
            Percentage += percentLeft;

            if (Percentage > 100)
            {
                Percentage = 100;
            }

            if (Percentage < 0)
            {
                Percentage = 0;
            }
        }
    }
}
