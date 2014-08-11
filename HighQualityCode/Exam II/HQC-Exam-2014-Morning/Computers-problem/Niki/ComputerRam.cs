namespace ComputersApplication
{
    public class ComputerRam
    {
        //fields
        private int value;

        //constructors
        internal ComputerRam(int a)
        {
            Amount = a;
        }

        //properties
        public int Amount { get; set; }

        //methods
        public void SaveValue(int newValue)
        {
            value = newValue;
        }

        public int LoadValue()
        {
            return value;
        }
    }
}