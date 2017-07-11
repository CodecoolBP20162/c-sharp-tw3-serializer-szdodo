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
        public string PhoneNumber { get; set; }
        public DateTime DateOfRecording { get; set; }
        //public int privateNumb { get; set; }
        [NonSerialized] public static int serialNumber = 0;

        public Person() { }

        public Person(string name, string address, string phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
            DateOfRecording = DateTime.Now;
        }

        public Person(SerializationInfo info, StreamingContext context)
        {
            Name = (string)info.GetValue("Name", typeof(string));
            Address = (string)info.GetValue("Address", typeof(string));
            PhoneNumber = (string)info.GetValue("PhoneNumber", typeof(string));
            DateOfRecording = (DateTime)info.GetValue("DateOfRecording", typeof(DateTime));
        }

        void IDeserializationCallback.OnDeserialization(Object sender)
        {
            serialNumber = getSerialNumber();
        }

        public static int getSerialNumber()
        {
            int fileCount = 0;
            foreach (var file in Directory.GetFiles(@"C:\Users\Dodo\Source\Repos\c-sharp-tw3-serializer-szdodo\Serializer\bin\Debug", "*.dat"))
            {
                fileCount++;
            }
            return fileCount-1;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", Name, typeof(string));
            info.AddValue("Address", Address, typeof(string));
            info.AddValue("PhoneNumber", PhoneNumber, typeof(string));
            info.AddValue("DateOfRecording", DateOfRecording, typeof(DateTime));
        }

        public void Serialize()
        {
            string fileName = "person" + (getSerialNumber()+1) + ".dat";
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

            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);

                BinaryFormatter formatter = new BinaryFormatter();
                person = (Person)formatter.Deserialize(fs);
                fs.Close();
            }
            catch (FileNotFoundException) { }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                Console.Read();
                throw;
            }
            
            return person;
        }

    }
}
