using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EstateLogic
{
    [Serializable(), XmlRoot("Residental")]
    public class Residental : Building
    {

        public Residental() { }
        /// <summary>
        /// construct residental
        /// currently no checks for id unique
        /// currently storing residentla type as string, could be an enum
        /// currently not using the country enum provided with assignment as the user is restricted to use the input from a listbox which does use the country enum.
        /// currently Legal form is used as a string deriving from parent, although this coul be an enum
        /// As what passes in here is restricted by the form design there can never be a country stored that does not exist in the country collection,
        /// neither can there exist residental types or types of ownership which isn't specified in the form listboxes. Which means that the use of strings isn't a risk.
        /// </summary>
        /// <param name="_street"></param>
        /// <param name="_city"></param>
        /// <param name="_country"></param>
        /// <param name="_id"></param>
        /// <param name="_zipCode"></param>
        /// <param name="_residentalType"></param>
        public Residental(string _street, string _city, string _country, string _id, string _zipCode, string _legalForm, string _typeOfBuilding) : base(_street, _city, _country, _id, _zipCode, _legalForm, _typeOfBuilding)
        {
            street = _street;
            city = _city;
            country = _country;
            id = _id;
            zipCode = _zipCode;            
            typeOfBuilding = _typeOfBuilding;
        }

        

        /// <summary>
        /// returns the ListInformation, old function not used new function is compressed all variables into a list which can be passed to relevant objects
        /// </summary>
        /// <returns></returns>
       
        public override string ListInformation()
        {
            return $"id:{id} street:{street} zip: {zipCode} country: {country} legalform: {legalForm} residentaltype:{typeOfBuilding}";
        }
    }
}
