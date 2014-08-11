using System;
using System.Linq;
using System.Reflection;
using System.Text;
using CalendarSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wintellect.PowerCollections;

namespace CalendarSystemUnitTests
{
    [TestClass]
    public class CalendarUnitTests
    {
        internal static object GetInstanceField(Type type, object instance, string fieldName)
        {
            BindingFlags bindFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
                | BindingFlags.Static;
            FieldInfo field = type.GetField(fieldName, bindFlags);
            return field.GetValue(instance);
        }

        //Command class-> covered 91.30%
        [TestMethod]
        public void ParsingCommandsValidFormatTest()
        {
            Command command = Command.Parse("AddEvent 2012-01-21T20:20:20 | party Viki | home");
            Assert.AreEqual("AddEvent", command.CommandName);
            Assert.AreEqual(3, command.Arguments.Count());
        }
        
        [TestMethod]
        public void ParsingCommandsInvalidDateFormatTest()
        {
            Command command = Command.Parse("AddEvent 2012-01-21T20 | party Viki | home");
            Assert.AreEqual(null, command);
        }

        [TestMethod]
        public void ParsingCommandsNoDateTest()
        {
            Command command = Command.Parse("AddEvent | party Viki | home");
            Assert.AreEqual(null, command);
        }

        [TestMethod]
        public void ParsingCommandsNoTitleTest()
        {
            Command command = Command.Parse("AddEvent 2012-01-21T20:20:20 | | home");
            Assert.AreEqual(null, command);
        }

        [TestMethod]
        public void ParsingCommandsNoLocationTest()
        {
            Command command = Command.Parse("AddEvent 2012-01-21T20:20:20 | party Viki |");
            Assert.AreNotEqual(null, command);
        }

        [TestMethod]
        public void ParsingCommandsInvalidFormatTest()
        {
            Command command = null;
            try
            {
                command = Command.Parse("AddEvent2012-01-21T20:20:20|partyViki|home");
            }
            catch (IndexOutOfRangeException iore)
            {
                Assert.AreEqual(null, command);                
            }
        }

        [TestMethod]
        public void ParsingCommandsEarlyDateTest()
        {
            Command command = Command.Parse("AddEvent 1012-01-21T20 | party Viki | home");
            Assert.AreEqual(null, command);
        }

        [TestMethod]
        public void ParsingCommandsFutureDateTest()
        {
            Command command = Command.Parse("AddEvent 2112-01-21T20 | party Viki | home");
            Assert.AreEqual(null, command);
        }

        [TestMethod]
        public void ParsingCommandsInvalidFormatPipeTest()
        {
            Command command = Command.Parse("AddEvent|2112-01-21T20 |party Vi|ki | home| \n ");
            Assert.AreEqual(null, command);
        }

        //Events manager -> covered 100%
        //AddEvent
        [TestMethod]
        public void AddEventValidFormatTest()
        {
            EventsManager manager = new EventsManager();
            Event occasion = new Event("title", "location", DateTime.Now);
            manager.AddEvent(occasion);
            Console.WriteLine();
        }

        [TestMethod]
        public void AddEventEmptyTitleTest()
        {
            EventsManager manager = new EventsManager();
            Event occasion = new Event("", "location", DateTime.Now);
            manager.AddEvent(occasion);

            var testObj = (MultiDictionary<string, Event>)GetInstanceField(typeof(EventsManager), manager, "_eventsDictionary");
            Assert.AreNotEqual(1, testObj.Count);
        }

        [TestMethod]
        public void AddEventTooLongTitleTest()
        {
            EventsManager manager = new EventsManager();
            StringBuilder title = new StringBuilder();
            for (int i = 0; i <= 200; i++)
            {
                title.Append("title");
            }
            Event occasion = new Event(title.ToString(), "location", DateTime.Now);
            manager.AddEvent(occasion);

            var testObj = (MultiDictionary<string, Event>) GetInstanceField(typeof(EventsManager), manager, "_eventsDictionary");
           Assert.AreNotEqual(1, testObj.Count); 
        }

        [TestMethod]
        public void AddEventInvalidFormatTitleTest()
        {
            EventsManager manager = new EventsManager();
            string title = "  t| \n itle  ";
            
            Event occasion = new Event(title.ToString(), "location", DateTime.Now);
            manager.AddEvent(occasion);

            var testObj = (MultiDictionary<string, Event>)GetInstanceField(typeof(EventsManager), manager, "_eventsDictionary");
            Assert.AreNotEqual(1, testObj.Count);
        }
        
        [TestMethod]
        public void AddEventEmptyLocationTest()
        {
            EventsManager manager = new EventsManager();
            Event occasion = new Event("title", "", DateTime.Now);
            manager.AddEvent(occasion);

            var testObj = (MultiDictionary<string, Event>)GetInstanceField(typeof(EventsManager), manager, "_eventsDictionary");
            Assert.AreNotEqual(1, testObj.Count);
        }

        [TestMethod]
        public void AddEventTooLongLocationTest()
        {
            EventsManager manager = new EventsManager();
            StringBuilder location = new StringBuilder();
            for (int i = 0; i <= 150; i++)
            {
                location.Append("location");
            }
            Event occasion = new Event("title", location.ToString(), DateTime.Now);
            manager.AddEvent(occasion);

            var testObj = (MultiDictionary<string, Event>)GetInstanceField(typeof(EventsManager), manager, "_eventsDictionary");
            Assert.AreNotEqual(1, testObj.Count);
        }

        [TestMethod]
        public void AddEventInvalidFormatLocationTest()
        {
            EventsManager manager = new EventsManager();
            string location = "  l| \n ocation  ";

            Event occasion = new Event("title", location, DateTime.Now);
            manager.AddEvent(occasion);

            var testObj = (MultiDictionary<string, Event>)GetInstanceField(typeof(EventsManager), manager, "_eventsDictionary");
            Assert.AreNotEqual(1, testObj.Count);
        }

        //DeleteEvent
        [TestMethod]
        public void DeleteValidEventTest()
        {
            EventsManager manager = new EventsManager();
            //reflection test object
            Event occasion = new Event("title", "location", DateTime.Now);
            MultiDictionary<string, Event> dummyDictionary = new MultiDictionary<string,Event>(true);
            dummyDictionary.Add("title", occasion);
            FieldInfo fieldInfo = manager.GetType().GetField("_eventsDictionary", BindingFlags.Instance | BindingFlags.NonPublic);
            fieldInfo.SetValue(manager, dummyDictionary);

            int result = manager.DeleteEventsByTitle("title");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void DeleteNotExistingEventTest()
        {
            EventsManager manager = new EventsManager();
            
            int result = manager.DeleteEventsByTitle("title");
            Assert.AreEqual(0, result);
        }

        //ListEvents
        [TestMethod]
        public void ListValidEventsTest()
        {
            EventsManager manager = new EventsManager();
            //reflection test object
            Event occasion = new Event("title", "location", DateTime.Now.AddDays(1));
            Event occasion1 = new Event("title1", "location1", DateTime.Now.AddDays(2));
            Event occasion2 = new Event("title2", "location2", DateTime.Now.AddDays(3));
            Event occasion3 = new Event("title3", "location3", DateTime.Now.AddDays(4));

            OrderedMultiDictionary<DateTime, Event> dummyOrderedDictionary = new OrderedMultiDictionary<DateTime, Event>(true);
            dummyOrderedDictionary.Add(DateTime.Now.AddDays(1), occasion);
            dummyOrderedDictionary.Add(DateTime.Now.AddDays(2), occasion1);
            dummyOrderedDictionary.Add(DateTime.Now.AddDays(3), occasion2);
            dummyOrderedDictionary.Add(DateTime.Now.AddDays(4), occasion3);
            FieldInfo fieldInfo = manager.GetType().GetField("_orderedEvents", BindingFlags.Instance | BindingFlags.NonPublic);
            fieldInfo.SetValue(manager, dummyOrderedDictionary);

            var result = manager.ListEvents(DateTime.Now, 4);
            Assert.AreEqual(4, result.Count());
        }

        [TestMethod]
        public void ListEventsZeroCountTest()
        {
            EventsManager manager = new EventsManager();
            //reflection test object
            Event occasion = new Event("title", "location", DateTime.Now.AddDays(1));
            Event occasion1 = new Event("title1", "location1", DateTime.Now.AddDays(2));
            Event occasion2 = new Event("title2", "location2", DateTime.Now.AddDays(3));
            Event occasion3 = new Event("title3", "location3", DateTime.Now.AddDays(4));

            OrderedMultiDictionary<DateTime, Event> dummyOrderedDictionary = new OrderedMultiDictionary<DateTime, Event>(true);
            dummyOrderedDictionary.Add(DateTime.Now.AddDays(1), occasion);
            dummyOrderedDictionary.Add(DateTime.Now.AddDays(2), occasion1);
            dummyOrderedDictionary.Add(DateTime.Now.AddDays(3), occasion2);
            dummyOrderedDictionary.Add(DateTime.Now.AddDays(4), occasion3);
            FieldInfo fieldInfo = manager.GetType().GetField("_orderedEvents", BindingFlags.Instance | BindingFlags.NonPublic);
            fieldInfo.SetValue(manager, dummyOrderedDictionary);

            var result = manager.ListEvents(DateTime.Now, 0);
            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        public void ListEventsNegativeCountTest()
        {
            EventsManager manager = new EventsManager();
            //reflection test object
            Event occasion = new Event("title", "location", DateTime.Now.AddDays(1));
            Event occasion1 = new Event("title1", "location1", DateTime.Now.AddDays(2));
            Event occasion2 = new Event("title2", "location2", DateTime.Now.AddDays(3));
            Event occasion3 = new Event("title3", "location3", DateTime.Now.AddDays(4));

            OrderedMultiDictionary<DateTime, Event> dummyOrderedDictionary = new OrderedMultiDictionary<DateTime, Event>(true);
            dummyOrderedDictionary.Add(DateTime.Now.AddDays(1), occasion);
            dummyOrderedDictionary.Add(DateTime.Now.AddDays(2), occasion1);
            dummyOrderedDictionary.Add(DateTime.Now.AddDays(3), occasion2);
            dummyOrderedDictionary.Add(DateTime.Now.AddDays(4), occasion3);
            FieldInfo fieldInfo = manager.GetType().GetField("_orderedEvents", BindingFlags.Instance | BindingFlags.NonPublic);
            fieldInfo.SetValue(manager, dummyOrderedDictionary);

            var result = manager.ListEvents(DateTime.Now, -1);
            Assert.AreEqual(0, result.Count());
        }

        [TestMethod]
        public void ListEventsTooBigCountTest()
        {
            EventsManager manager = new EventsManager();
            //reflection test object
            Event occasion = null;
            OrderedMultiDictionary<DateTime, Event> dummyOrderedDictionary = new OrderedMultiDictionary<DateTime, Event>(true);
            
            for (int i = 0; i < 105; i++)
            {
                occasion = new Event("title" + i, "location" + i, DateTime.Now.AddHours(i));
                dummyOrderedDictionary.Add(DateTime.Now.AddHours(i), occasion);
                occasion = null;
            }

            FieldInfo fieldInfo = manager.GetType().GetField("_orderedEvents", BindingFlags.Instance | BindingFlags.NonPublic);
            fieldInfo.SetValue(manager, dummyOrderedDictionary);

            var result = manager.ListEvents(DateTime.Now, 101);
            Assert.AreEqual(0, result.Count());
        }

    }
}
