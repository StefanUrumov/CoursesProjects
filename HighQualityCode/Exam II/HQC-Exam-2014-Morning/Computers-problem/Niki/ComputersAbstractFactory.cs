namespace ComputersApplication
{
    public abstract class ComputersAbstractFactory
    {
        public abstract Computer BuildPc();

        public abstract Computer BuildServer();

        public abstract Computer BuildLaptop();
    }
}
