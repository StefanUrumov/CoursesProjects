using System.Collections.Generic;

namespace ComputersApplication
{
    public class ComputersFactory
    {
        //fields
        private const int RamBits = 8;

        public static Computer BuildHpPc()
        {
            var currentRam = new ComputerRam(RamBits / 4);
            var videoCard = new HardDrive();
            videoCard.IsMonochrome = false;
            ComputerCpu currentPcCpu = new ComputerCpu(RamBits / 4, 32, currentRam, videoCard);
            HardDrive pcHardDrive = new HardDrive(500, false, 0);
            HardDrive[] pcHardDrives = new[] { pcHardDrive };

            return new Computer(ComputerTypes.Pc, currentPcCpu, currentRam, pcHardDrives, videoCard, null);
        }

        public static Computer BuildHpServer()
        {
            //build server
            var serverRam = new ComputerRam(RamBits * 4);
            var serverVideo = new HardDrive();
            ComputerCpu currentServerCpu = new ComputerCpu(RamBits / 2, 32, serverRam, serverVideo);
            HardDrive serverHardDrive = new HardDrive(1000, false, 0);
            HardDrive serverSecondHardDrive = new HardDrive(1000, false, 0);
            List<HardDrive> serverDrives = new List<HardDrive> { };
            serverDrives.Add(serverHardDrive);
            serverDrives.Add(serverSecondHardDrive);
            HardDrive serverClusterDrive = new HardDrive(0, true, 2, serverDrives);
            List<HardDrive> serverHardDrives = new List<HardDrive> { };
            serverHardDrives.Add(serverClusterDrive);
            return new Computer(ComputerTypes.Server, currentServerCpu, serverRam, serverHardDrives, serverVideo, null);
        }

        public static Computer BuildHpLaptop()
        {
            //build laptop
            var card = new HardDrive() { };
            card.IsMonochrome = false;
            var laptopRam = new ComputerRam(RamBits / 2);
            ComputerCpu laptopCpu = new ComputerCpu(RamBits / 4, 64, laptopRam, card);
            HardDrive[] laptopHardDrives = new[] { new HardDrive(500, false, 0) };
            LaptopBattery laptopBattery = new LaptopBattery();
            return new Computer(ComputerTypes.Laptop, laptopCpu, laptopRam, laptopHardDrives, card, laptopBattery);
        }

        public static Computer BuildDellPc()
        {
            //build pc
            var dellPcRam = new ComputerRam(RamBits);
            var dellPcVideoCard = new HardDrive() { };
            dellPcVideoCard.IsMonochrome = false;
            ComputerCpu dellPcCpu = new ComputerCpu(RamBits / 2, 64, dellPcRam, dellPcVideoCard);
            List<HardDrive> dellPcHardDrives = new List<HardDrive>();
            HardDrive dellPcHardDrive = new HardDrive(1000, false, 0);
            dellPcHardDrives.Add(dellPcHardDrive);
            return new Computer(ComputerTypes.Pc, dellPcCpu, dellPcRam, dellPcHardDrives, dellPcVideoCard, null);
        }

        public static Computer BuildDellServer()
        {
            //build server
            var dellServerRam = new ComputerRam(RamBits * RamBits);
            var dellServerVideoCard = new HardDrive();
            ComputerCpu dellServerCpu = new ComputerCpu(RamBits, 64, dellServerRam, dellServerVideoCard);
            HardDrive dellDrive = new HardDrive(2000, false, 0);
            HardDrive dellSecondDrive = new HardDrive(2000, false, 0);
            List<HardDrive> dellServerDrives = new List<HardDrive>();
            dellServerDrives.Add(dellDrive);
            dellServerDrives.Add(dellSecondDrive);
            HardDrive dellHardDrive = new HardDrive(0, true, 2, dellServerDrives);
            List<HardDrive> dellServerHardDrives = new List<HardDrive> { };
            dellServerHardDrives.Add(dellHardDrive);
            return new Computer(ComputerTypes.Server, dellServerCpu, dellServerRam, dellServerHardDrives, dellServerVideoCard, null);
        }

        public static Computer BuildDellLaptop()
        {
            //build laptop
            var dellLaptopRam = new ComputerRam(RamBits);
            var dellLaptopVideoCard = new HardDrive() { };
            dellLaptopVideoCard.IsMonochrome = false;
            List<HardDrive> dellLaptopDrives = new List<HardDrive>();
            HardDrive dellLaptopDrive = new HardDrive(1000, false, 0);
            dellLaptopDrives.Add(dellLaptopDrive);
            ComputerCpu dellLaptopCpu = new ComputerCpu(RamBits / 2, 32, dellLaptopRam, dellLaptopVideoCard);
            LaptopBattery dellLaptopBattery = new LaptopBattery();
            return new Computer(ComputerTypes.Laptop, dellLaptopCpu, dellLaptopRam, dellLaptopDrives, dellLaptopVideoCard, dellLaptopBattery);
        }
        
        internal static Computer BuildLenovoLaptop()
        {
            //build laptop
            var card = new HardDrive() { };
            card.IsMonochrome = false;
            var laptopRam = new ComputerRam(RamBits * 2);
            ComputerCpu laptopCpu = new ComputerCpu(RamBits, 128, laptopRam, card);
            HardDrive[] laptopHardDrives = new[] { new HardDrive(1000, false, 0) };
            LaptopBattery laptopBattery = new LaptopBattery();
            return new Computer(ComputerTypes.Laptop, laptopCpu, laptopRam, laptopHardDrives, card, laptopBattery);

        }

        internal static Computer BuildLenovoServer()
        {
            //build server
            var lenovoServerRam = new ComputerRam(RamBits * RamBits * 2);
            var lenovoServerVideoCard = new HardDrive();
            ComputerCpu lenovoServerCpu = new ComputerCpu(RamBits * 2, 128, lenovoServerRam, lenovoServerVideoCard);
            HardDrive lenovoDrive = new HardDrive(500, false, 0);
            HardDrive lenovoSecondDrive = new HardDrive(500, false, 0);
            List<HardDrive> lenovoServerDrives = new List<HardDrive>();
            lenovoServerDrives.Add(lenovoDrive);
            lenovoServerDrives.Add(lenovoSecondDrive);
            HardDrive lenovoHardDrive = new HardDrive(0, true, 2, lenovoServerDrives);
            List<HardDrive> lenovoServerHardDrives = new List<HardDrive> { };
            lenovoServerHardDrives.Add(lenovoHardDrive);
            return new Computer(ComputerTypes.Server, lenovoServerCpu, lenovoServerRam, lenovoServerHardDrives, lenovoServerVideoCard, null);
        }

        internal static Computer BuildLenovoPc()
        {
            var lenovoPcRam = new ComputerRam(RamBits * 2);
            var lenovoPcVideoCard = new HardDrive() { };
            lenovoPcVideoCard.IsMonochrome = true;
            ComputerCpu lenovoPcCpu = new ComputerCpu(RamBits / 2, 64, lenovoPcRam, lenovoPcVideoCard);
            List<HardDrive> lenovoPcHardDrives = new List<HardDrive>();
            HardDrive lenovoPcHardDrive = new HardDrive(2000, false, 0);
            lenovoPcHardDrives.Add(lenovoPcHardDrive);
            return new Computer(ComputerTypes.Pc, lenovoPcCpu, lenovoPcRam, lenovoPcHardDrives, lenovoPcVideoCard, null);
        }
    }
}
