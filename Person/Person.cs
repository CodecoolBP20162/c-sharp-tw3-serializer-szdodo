using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Person
{
    [Serializable]
    public class Person : ISerializable, IDeserializationCallback
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime DateOfRecording { get; set; }
        [NonSerialized] private static int serialNumber = 0;

        public Person() { }

        public Person(string name, string address, int phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            DateOfRecording = DateTime.Now;
            serialNumber = getSerialNumber();
        }

        public Person(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Address = (string)info.GetValue("Address", typeof(string));
            PhoneNumber = (int)info.GetValue("PhoneNumber", typeof(int));
            DateOfRecording = (DateTime)info.GetValue("DateOfRecording", typeof(DateTime));
            serialNumber = getSerialNumber();
        }

        void IDeserializationCallback.OnDeserialization(Object sender)
        {
            serialNumber = getSerialNumber();
        }

        private int getSerialNumber()
        {
            serialNumber++;
            return serialNumber;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Use the AddValue method to specify serialized values.
            info.AddValue("Name", Name, typeof(string));
            info.AddValue("Address", Address, typeof(string));
            info.AddValue("PhoneNumber", PhoneNumber, typeof(int));
            info.AddValue("DateOfRecording", DateOfRecording, typeof(DateTime));
        }

        public void Serialize()
        {
            string fileName = "person" + getSerialNumber() + ".dat";
            FileStream fs = new FileStream(fileName, FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, this);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                Console.Read();
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        public static Person Deserialize(string fileName)
        {
            Person person = new Person();

            FileStream fs = new FileStream(fileName, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                person = (Person)formatter.Deserialize(fs);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                Console.Read();
                throw;
            }
            finally
            {
                fs.Close();
            }
            return person;
        }

    }
}
