using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataLayer
{/// <summary>
/// handles persistant saving of data from the application
/// </summary>
    public class DataSerialization
    {
        static FileStream fileStream = null;
        static string errorMsg = null;
        /// <summary>
        /// Takes a path and an object and saves the object at the path in a binary format.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T BinaryDeSerialize<T>(string fileName)
        {
            fileStream = null;
           
            fileStream = new FileStream(fileName, FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            object obj = b.Deserialize(fileStream);

            if (fileStream != null)
                fileStream.Close();

            return (T)obj;
        }
        /// <summary>
        /// Takes a path and an object and deserializes the object at the path from a binary format and the returns the object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T BinarySerialize<T>(string fileName, object obj)
        {
            fileStream = new FileStream(fileName, FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(fileStream, obj);

            if (fileStream != null)
                fileStream.Close();

            return (T)obj;
        }
        /// <summary>
        /// serializes the object as a readable xml file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T XMLSerialize<T>(string fileName, object obj)
        {
            fileStream = null;          

            using (Stream stream = new FileStream("Buildings.xml", FileMode.Create, FileAccess.Write))
            {
                XmlSerializer s = new XmlSerializer(typeof(T));

                s.Serialize(stream, obj);
            }
            return (T)obj;
        }
        /// <summary>
        /// deserializes the xml file and returns the object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T XMLDESerialize<T>(string fileName)
        {
            fileStream = null;
            object obj;
            using (Stream stream = new FileStream("Buildings.xml", FileMode.Open, FileAccess.Read))
            {
                XmlSerializer s = new XmlSerializer(typeof(T));

                obj = s.Deserialize(stream);
            }
            return (T)obj;
        }
    }
}
