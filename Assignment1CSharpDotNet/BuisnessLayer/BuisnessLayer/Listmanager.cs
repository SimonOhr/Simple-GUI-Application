using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EstateLogic
{
    /// <summary>
    /// handles calls to dal inherits from List<typeparamref name="T"/> and supplements the class with the calls needed for the 
    /// dal. I am somewhat confused by the assignemnt instructions as to if it was mandatory to write ones own List<typeparamref name="T"/> class
    /// which seems redundant to me. If so, let me know.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [Serializable()]
    public class ListManager<T> : List<T>// IListManager<T>
    {
        // we're using two lists for seperating the serialization process, because of simplicity.
        // It can be argued that it is safer to have the binary serialization as the prime collection
        // and the xml collection as a way to manually check the content of the collection 
        // (they contain the same stuff but the application uses the binary one)
        // so if changes are made outside the application to the xml file, the application won't be compromised (just for the sake of argument)
              
        public ListManager()
        {                 
        }                 
            
        /// <summary>
        ///  handles call to dal to serialize my list of buildings as binary
        /// </summary>
        /// <returns></returns>
        public List<T> BinarySerialize(string filePath)
        {
            return DataLayer.DataSerialization.BinarySerialize<List<T>>(filePath, this);
        }

        /// <summary>
        ///  handles call to dal to deserialize my list of buildings as binary
        /// </summary>
        /// <returns></returns>
        public List<T> BinaryDeSerialize(string filePath)
        {
            return DataLayer.DataSerialization.BinaryDeSerialize<List<T>>(filePath);
        }
        /// <summary>
        /// handles call to dal to serialize my xml list of buildings to a xml file
        /// </summary>
        /// <returns></returns>
        public List<T> XMLSerialize(string filePath)
        {
            return DataLayer.DataSerialization.XMLSerialize<List<T>>(filePath, this);
        }
        /// <summary>
        /// handles call to dal to deserialize my list of xml list buildings to a xml file
        /// </summary>
        /// <returns></returns>
        public List<T> XMLDeSerialize(string filePath)
        {
            return DataLayer.DataSerialization.XMLDESerialize<List<T>>(filePath);
        }
    }
}
