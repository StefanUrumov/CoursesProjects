namespace ComputersApplication
{
    using System;

    public class Computers
    {
        //fields
        private static Computer pc;
        private static Computer laptop;
        private static Computer server;

        //methods
        public static void Main()
        {
            var manufacturer = Console.ReadLine();

            if (manufacturer == "HP")
            {
                LoadComputers(manufacturer);
            }
            else if (manufacturer == "Dell")
            {
                LoadComputers(manufacturer);
            }
            else if (manufacturer == "Lenovo")
            {
                LoadComputers(manufacturer);
            }
            else
            {
                throw new InvalidArgumentException("Invalid manufacturer!");
            }

            while (true)
            {
                var userInput = Console.ReadLine();

                if (userInput.StartsWith("Exit"))
                {
                    break;
                }

                CommandProcessor.ProcessCommand(userInput, pc, server, laptop);
            }
        }

        private static void LoadComputers(string manufacturerFactory)
        {
            ProductManager manager = new ProductManager();
            var products = manager.GetProducts(manufacturerFactory);

            pc = products[0];
            server = products[1];
            laptop = products[2];
        }
    }
}
