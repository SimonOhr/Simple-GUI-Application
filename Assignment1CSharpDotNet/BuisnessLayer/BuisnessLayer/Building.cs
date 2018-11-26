using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EstateLogic
{
    //making the class serialisable, also setting the xml root and including the derived classes.
    [Serializable(), XmlRoot("Building"), XmlInclude(typeof(Commercial)), XmlInclude(typeof(Residental))]

    public abstract class Building : IBuilding
    {
        // the only reason I changed these from protected to public was to achieve a nicer look to the xml file.
        public string street, city, country, legalForm, typeOfBuilding, zipCode, id;

        // I would like to make this [NonSerialized] but if I then retrieve that data, it will lack the compressed info. Could rewrite but feels like scopecreep
        ListManager<string> buildingInfo;

        public ListManager<string> BuildingInfo { get { return buildingInfo; } set { buildingInfo = value; } }

        public Building() { }

        public Building(string _street, string _city, string _country, string _id, string _zipCode, string _legalForm, string _typeOfBuilding)
        {
            street = _street;
            city = _city;
            country = _country;
            id = _id;
            zipCode = _zipCode;
            legalForm = _legalForm;
            typeOfBuilding = _typeOfBuilding;

            BuildingInfo = new ListManager<string>();
            Compressinfo();
        }
        /// <summary>
        /// Prints out building information
        /// </summary>
        /// <returns></returns>
        public abstract string ListInformation();

        /// <summary>
        /// stores all building info in a traversable collection not "compressed" as such but compressed for quick access
        /// </summary>   
        public void Compressinfo()
        {
            buildingInfo.Add(id);
            buildingInfo.Add(typeOfBuilding);
            buildingInfo.Add(legalForm);
            buildingInfo.Add(country);
            buildingInfo.Add(city);
            buildingInfo.Add(street);
            buildingInfo.Add(zipCode);
        }
    }
}
