namespace ComputersApplication
{
    using System;

    public class ComputerCpu
    {
        //fields
        private static readonly Random Random = new Random();
        private readonly byte numberOfBits;
        private readonly ComputerRam ram;
        private readonly HardDrive videoCard;

        //constructors
        internal ComputerCpu(byte numberOfCores, byte numberOfBits, ComputerRam ram, HardDrive videoCard) 
        {
            this.numberOfBits = numberOfBits;
            this.ram = ram;
            this.NumberOfCores = numberOfCores;
            this.videoCard = videoCard;
        }

        //properties
        public byte NumberOfCores { get; set; }

        //methods
        public void SquareNumber()
        {
            if (this.numberOfBits == 32)
            {
                SquareNumber32();
            }

            if (this.numberOfBits == 64)
            {
                SquareNumber64();
            }

            if (this.numberOfBits == 128)
            {
                SquareNumber128();
            }
        }

        public void SquareNumber32()
        {
            var data = this.ram.LoadValue();

            if (data < 0)
            {
                this.videoCard.Draw("Number too low.");
            }
            else if (data > 500)
            {
                this.videoCard.Draw("Number too high.");
            }
            else
            {
                int value = 0;

                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                this.videoCard.Draw(string.Format("Square of {0} is {1}.", data, value));
            }
        }

        public void SquareNumber64()
        {
            var data = this.ram.LoadValue();

            if (data < 0)
            {
                this.videoCard.Draw("Number too low.");
            }
            else if (data > 1000)
            {
                this.videoCard.Draw("Number too high.");
            }
            else
            {
                int value = 0;
                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                this.videoCard.Draw(string.Format("Square of {0} is {1}.", data, value));
            }
        }

        internal void RandomNumber(int min, int max)
        {
            int randomNumber;
            do
            {
                randomNumber = Random.Next(min, max);
            }
            while (randomNumber <= min && randomNumber >= max); 
            this.ram.SaveValue(randomNumber);
        }

        private void SquareNumber128()
        {
            var data = this.ram.LoadValue();

            if (data < 0)
            {
                this.videoCard.Draw("Number too low.");
            }
            else if (data > 2000)
            {
                this.videoCard.Draw("Number too high.");
            }
            else
            {
                int value = 0;
                for (int i = 0; i < data; i++)
                {
                    value += data;
                }

                this.videoCard.Draw(string.Format("Square of {0} is {1}.", data, value));
            }
        }
    }
}
