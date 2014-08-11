namespace ComputersApplication
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class HardDrive
    {
        //fields
        private bool isInRaid;
        private int hardDrivesInRaid;
        private int capacity;
        private List<HardDrive> hds;
        private Dictionary<int, string> data;
        
        //constructors
        internal HardDrive()
        {
        }
        
        internal HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid)
        {
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;
            this.data = new Dictionary<int, string>(capacity);
            this.hds = new List<HardDrive>();
        }

        internal HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid, List< HardDrive > hardDrives)
        {
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.capacity = capacity;
            this.data = new Dictionary<int, string>(capacity);
            this.hds = new List<HardDrive>();
            this.hds = hardDrives;
        }

        //properties
        public bool IsMonochrome { get; set; }

        public int Capacity
        {
            get
            {
                if (isInRaid)
                {
                    if (!this.hds.Any())
                    {
                        return 0;
                    }

                    return this.hds.First().Capacity;
                }
                else
                {
                    return capacity;
                }
            }
        }
        
        //methods
        public void SaveData(int addr, string newData)
        {
            if (isInRaid)
            {
                foreach (var hardDrive in this.hds)
                {
                    hardDrive.SaveData(addr, newData);
                }
            }
            else
            {
                this.data[addr] = newData;
            }
        }

        public string LoadData(int address)
        {
            if (isInRaid)
            {
                if (!this.hds.Any())
                {
                    throw new ArgumentException("No hard drive in the RAID array!");
                }

                return this.hds.First().LoadData(address);
            }
            
                return this.data[address];
        }

        public void Draw(string displayText)
        {
            if (this.IsMonochrome)
            {
                System.Console.ForegroundColor = ConsoleColor.Gray;
                System.Console.WriteLine(displayText);
                System.Console.ResetColor();
            }
            else
            {
                System.Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine(displayText);
                System.Console.ResetColor();
            }
        }
    }
}
