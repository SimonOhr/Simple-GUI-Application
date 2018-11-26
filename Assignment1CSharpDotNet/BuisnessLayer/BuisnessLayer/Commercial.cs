using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EstateLogic
{
    [Serializable(), XmlRoot("Commercial")]
    public class Commercial : Building
    {        
        public Commercial() { }

        /// <summary>
        /// construct residental
        /// currently no checks for id unique
        /// currently storing residentla type as string, considering an enum
        /// currently not using the country enum provided with assignment(aka countries needs to reference that enum)
        /// currently Legal form is used as a string deriving from parent, although this should be an enum
        /// </summary>
        /// <param name="_street"></param>
        /// <param name="_city"></param>
        /// <param name="_country"></param>
        /// <param name="_id"></param>
        /// <param name="_zipCode"></param>
        /// <param name="_residentalType"></param>
        public Commercial(string _street, string _city, string _country, string _id, string _zipCode, string _legalForm, string _typeOfBuilding) : base(_street, _city, _country, _id, _zipCode, _legalForm, _typeOfBuilding)
        {
            street = _street;
            city = _city;
            country = _country;
            id = _id;
            zipCode = _zipCode;
            
            typeOfBuilding = _typeOfBuilding;
        }
       
        public override string ListInformation()
        {
            return $"id:{id} street:{street} zip: {zipCode} country: {country} legalform: {legalForm} residentaltype:{typeOfBuilding}";
        }
    }
}
