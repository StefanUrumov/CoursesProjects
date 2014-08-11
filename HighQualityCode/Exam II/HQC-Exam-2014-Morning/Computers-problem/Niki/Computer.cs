namespace ComputersApplication
{
    using System.Collections.Generic;

   public class Computer
    {
        //fields
        private readonly LaptopBattery battery;

        //constructors
        internal Computer(ComputerTypes type, ComputerCpu cpu, ComputerRam ram, IEnumerable<HardDrive> hardDrives, HardDrive videoCard, LaptopBattery battery)
        {
            this.Cpu = cpu;
            this.Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
            if (type != ComputerTypes.Laptop && type != ComputerTypes.Pc)
            {
                this.VideoCard.IsMonochrome = true;
            }

            this.battery = battery;
        }

        //properties
        public IEnumerable<HardDrive> HardDrives { get; set; }

        public HardDrive VideoCard { get; set; }

        public ComputerCpu Cpu { get; set; }

        public ComputerRam Ram { get; set; }
       
        //methods
        public void Play(int guessNumber)
        {
            this.Cpu.RandomNumber(1, 11);
            var randNumber = Ram.LoadValue();

            if (randNumber + 1 != guessNumber + 1)
            {
                this.VideoCard.Draw(string.Format("You didn't guess the number {0}.", randNumber));
            }
            else
            {
                this.VideoCard.Draw("You win!");
            }
        }

        internal void ChargeBattery(int percentage)
        {
            battery.Charge(percentage);
            VideoCard.Draw(string.Format("Battery status: {0}%", battery.Percentage));
        }

        internal void Process(int inputData)
        {
            //Number 1000 is too high for HP, but not for Dell. Manifacturers' logic is corrected, because of their RAM.
            Ram.SaveValue(inputData);
            Cpu.SquareNumber();
        }
    }
}
