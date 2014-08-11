using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Reflection;
using ComputersApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ComputersTests
{
    [TestClass]
    public class UnitTests
    {
        //I couldn't install Moq or JustMock, so I'm using reflection
        internal static object GetInstanceField(Type type, object instance, string fieldName)
        {
            BindingFlags bindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
                | BindingFlags.Static;
            FieldInfo field = type.GetField(fieldName, bindFlags);
            return field.GetValue(instance);
        }

        //Cpu.SquareNumber() covered -> 100%
        [TestMethod]
        public void SquareNegativeNumber32BitTest()
        {
            DellBuildStrategy builder = new DellBuildStrategy();
            var computers = builder.BuildComputers();
            Computer server = computers[1];

            FieldInfo fieldInfo = server.Ram.GetType().GetField("value", BindingFlags.Instance | BindingFlags.NonPublic);
            fieldInfo.SetValue(server.Ram, -1);

            server.Cpu.SquareNumber();

            var originalConsoleOut = Console.Out; // preserve the original stream
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);
                server.Cpu.SquareNumber();
                writer.Flush(); // when you're done, make sure everything is written out

                var myString = writer.GetStringBuilder().ToString();
                Console.SetOut(originalConsoleOut); 
                Assert.AreEqual("Number too low.\r\n", myString);
            }

            Console.SetOut(originalConsoleOut); // restore Console.Out

        }

        [TestMethod]
        public void SquareNegativeNumber64BitTest()
        {
           HpBuildStrategy builder = new HpBuildStrategy();
            var computers = builder.BuildComputers();
            Computer server = computers[1];

            FieldInfo fieldInfo = server.Ram.GetType().GetField("value", BindingFlags.Instance | BindingFlags.NonPublic);
            fieldInfo.SetValue(server.Ram, -1);

            server.Cpu.SquareNumber();

            var originalConsoleOut = Console.Out; // preserve the original stream
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);
                server.Cpu.SquareNumber();
                writer.Flush(); // when you're done, make sure everything is written out

                var myString = writer.GetStringBuilder().ToString();
                Console.SetOut(originalConsoleOut);
                Assert.AreEqual("Number too low.\r\n", myString);
            }

            Console.SetOut(originalConsoleOut); // restore Console.Out

        }

        [TestMethod]
        public void SquareZeroNumber32BitTest()
        {
            DellBuildStrategy builder = new DellBuildStrategy();
            var computers = builder.BuildComputers();
            Computer server = computers[1];

            FieldInfo fieldInfo = server.Ram.GetType().GetField("value", BindingFlags.Instance | BindingFlags.NonPublic);
            fieldInfo.SetValue(server.Ram, 0);

            server.Cpu.SquareNumber();

            var originalConsoleOut = Console.Out; // preserve the original stream
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);
                server.Cpu.SquareNumber();
                writer.Flush(); // when you're done, make sure everything is written out

                var myString = writer.GetStringBuilder().ToString();
                Console.SetOut(originalConsoleOut);
                Assert.AreEqual("Square of 0 is 0.\r\n", myString);
            }

            Console.SetOut(originalConsoleOut); // restore Console.Out

        }

        [TestMethod]
        public void SquareZeroNumber64BitTest()
        {
            HpBuildStrategy builder = new HpBuildStrategy();
            var computers = builder.BuildComputers();
            Computer server = computers[1];

            FieldInfo fieldInfo = server.Ram.GetType().GetField("value", BindingFlags.Instance | BindingFlags.NonPublic);
            fieldInfo.SetValue(server.Ram, 0);

            server.Cpu.SquareNumber();

            var originalConsoleOut = Console.Out; // preserve the original stream
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);
                server.Cpu.SquareNumber();
                writer.Flush(); // when you're done, make sure everything is written out

                var myString = writer.GetStringBuilder().ToString();
                Console.SetOut(originalConsoleOut);
                Assert.AreEqual("Square of 0 is 0.\r\n", myString);
            }

            Console.SetOut(originalConsoleOut); // restore Console.Out

        }

        [TestMethod]
        public void SquareTooHighNumber32BitTest()
        {
            DellBuildStrategy builder = new DellBuildStrategy();
            var computers = builder.BuildComputers();
            Computer server = computers[1];

            FieldInfo fieldInfo = server.Ram.GetType().GetField("value", BindingFlags.Instance | BindingFlags.NonPublic);
            fieldInfo.SetValue(server.Ram, 501);

            server.Cpu.SquareNumber();

            var originalConsoleOut = Console.Out; // preserve the original stream
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);
                server.Cpu.SquareNumber();
                writer.Flush(); // when you're done, make sure everything is written out

                var myString = writer.GetStringBuilder().ToString();
                Console.SetOut(originalConsoleOut);
                Assert.AreEqual("Number too high.\r\n", myString);
            }

            Console.SetOut(originalConsoleOut); // restore Console.Out

        }

        [TestMethod]
        public void SquareTooHighNumber64BitTest()
        {
            HpBuildStrategy builder = new HpBuildStrategy();
            var computers = builder.BuildComputers();
            Computer server = computers[1];

            FieldInfo fieldInfo = server.Ram.GetType().GetField("value", BindingFlags.Instance | BindingFlags.NonPublic);
            fieldInfo.SetValue(server.Ram, 1001);

            server.Cpu.SquareNumber();

            var originalConsoleOut = Console.Out; // preserve the original stream
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);
                server.Cpu.SquareNumber();
                writer.Flush(); // when you're done, make sure everything is written out

                var myString = writer.GetStringBuilder().ToString();
                Console.SetOut(originalConsoleOut);
                Assert.AreEqual("Number too high.\r\n", myString);
            }

            Console.SetOut(originalConsoleOut); // restore Console.Out

        }

        [TestMethod]
        public void SquareFloatingNumber32BitTest()
        {
            DellBuildStrategy builder = new DellBuildStrategy();
            var computers = builder.BuildComputers();
            Computer server = computers[1];

            FieldInfo fieldInfo = server.Ram.GetType().GetField("value", BindingFlags.Instance | BindingFlags.NonPublic);

            bool isWoring = false;
            try
            {
                fieldInfo.SetValue(server.Ram, 1.11111d);
            }
            catch (ArgumentException)
            {
                isWoring = true;
            }

            Assert.AreEqual(true, isWoring);
        }

        [TestMethod]
        public void SquareFloatingNumber64BitTest()
        {
            HpBuildStrategy builder = new HpBuildStrategy();
            var computers = builder.BuildComputers();
            Computer server = computers[1];

            FieldInfo fieldInfo = server.Ram.GetType().GetField("value", BindingFlags.Instance | BindingFlags.NonPublic);

            bool isWoring = false;
            try
            {
                fieldInfo.SetValue(server.Ram, 1.11111d);
            }
            catch (ArgumentException)
            {
                isWoring = true;
            }

            Assert.AreEqual(true, isWoring);
        }

        [TestMethod]
        public void SquareMultiplyNumber32BitTest()
        {
            DellBuildStrategy builder = new DellBuildStrategy();
            var computers = builder.BuildComputers();
            Computer server = computers[1];

            FieldInfo fieldInfo = server.Ram.GetType().GetField("value", BindingFlags.Instance | BindingFlags.NonPublic);
            fieldInfo.SetValue(server.Ram, 10);

            server.Cpu.SquareNumber();

            var originalConsoleOut = Console.Out; // preserve the original stream
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);
                server.Cpu.SquareNumber();
                writer.Flush(); // when you're done, make sure everything is written out

                var myString = writer.GetStringBuilder().ToString();
                Console.SetOut(originalConsoleOut);
                Assert.AreEqual("Square of 10 is 100.\r\n", myString);
            }

            Console.SetOut(originalConsoleOut); // restore Console.Out

        }

        [TestMethod]
        public void SquareMultiplyNumber64BitTest()
        {
            HpBuildStrategy builder = new HpBuildStrategy();
            var computers = builder.BuildComputers();
            Computer server = computers[1];

            FieldInfo fieldInfo = server.Ram.GetType().GetField("value", BindingFlags.Instance | BindingFlags.NonPublic);
            fieldInfo.SetValue(server.Ram, 10);

            server.Cpu.SquareNumber();

            var originalConsoleOut = Console.Out; // preserve the original stream
            using (var writer = new StringWriter())
            {
                Console.SetOut(writer);
                server.Cpu.SquareNumber();
                writer.Flush(); // when you're done, make sure everything is written out

                var myString = writer.GetStringBuilder().ToString();
                Console.SetOut(originalConsoleOut);
                Assert.AreEqual("Square of 10 is 100.\r\n", myString);
            }

            Console.SetOut(originalConsoleOut); // restore Console.Out
        }

        //Cpu.rand() coverred -> 100%
        [TestMethod]
        public void RandomNegativeNumberTest()
        {
            HpBuildStrategy builder = new HpBuildStrategy();
            var computers = builder.BuildComputers();
            Computer pc = computers[0];
            
            CommandProcessor.ProcessCommand("Play -5", pc, null, null);
            var value = pc.Ram.LoadValue();

            Assert.AreEqual(null, value);
        }
        
        [TestMethod]
        public void RandomZeroNumberTest()
        {
            HpBuildStrategy builder = new HpBuildStrategy();
            var computers = builder.BuildComputers();
            Computer pc = computers[0];

            CommandProcessor.ProcessCommand("Play 0", pc, null, null);
            var value = pc.Ram.LoadValue();

            Assert.AreNotEqual(null, value);
        }

        [TestMethod]
        public void RandomTooBigNumberTest()
        {
            HpBuildStrategy builder = new HpBuildStrategy();
            var computers = builder.BuildComputers();
            Computer pc = computers[0];

            CommandProcessor.ProcessCommand("Play 11", pc, null, null);
            var value = pc.Ram.LoadValue();

            Assert.AreNotEqual(null, value);
        }

        [TestMethod]
        public void RandomNotANumberTest()
        {
            HpBuildStrategy builder = new HpBuildStrategy();
            var computers = builder.BuildComputers();
            Computer pc = computers[0];

            bool isProcessed = true;
            try
            {
                CommandProcessor.ProcessCommand("Play abc", pc, null, null);
            }
            catch (FormatException)
            {
                isProcessed = false;
            }

            Assert.AreEqual(false, isProcessed);
        }

        [TestMethod]
        public void RandomEmptyNumberTest()
        {
            HpBuildStrategy builder = new HpBuildStrategy();
            var computers = builder.BuildComputers();
            Computer pc = computers[0];

            bool isProcessed = true;
            try
            {
                CommandProcessor.ProcessCommand("Play  ", pc, null, null);
            }
            catch (InvalidArgumentException)
            {
                isProcessed = false;
            }

            Assert.AreEqual(false, isProcessed);
        }

        [TestMethod]
        public void RandomAllNumbersTest()
        {
            HpBuildStrategy builder = new HpBuildStrategy();
            var computers = builder.BuildComputers();
            Computer pc = computers[0];
            List<int> expected = new List<int>(){1,2,3,4,5,6,7,8,9,10};
            List<int> generated = new List<int>();
            bool allNumbersPresent = false;
 
            for (int i = 0; i < 100; i++)
            {
                CommandProcessor.ProcessCommand("Play  15", pc, null, null);
                var value = pc.Ram.LoadValue();
                if (!generated.Contains(value))
                {
                    generated.Add(value);
                }
            }
            List<int> result = expected.Except(generated).ToList();
            Assert.AreEqual(0, result.Count);
        }

        //LaptopBattery.Charge()
        [TestMethod]
        public void BatteryChargeNegativePercentTest()
        {
            DellBuildStrategy builder = new DellBuildStrategy();
            var computers = builder.BuildComputers();

            Computer laptop = computers[2];
            //reflection test object
            FieldInfo fieldInfo = laptop.GetType().GetField("battery", BindingFlags.Instance | BindingFlags.NonPublic);
            fieldInfo.SetValue(laptop, -1);

            var batteryPower = GetInstanceField(typeof(Computer), laptop, "battery");
            Assert.AreNotEqual(-1, batteryPower);
        }

    }
}
