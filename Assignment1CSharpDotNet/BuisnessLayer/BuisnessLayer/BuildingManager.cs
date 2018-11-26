using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;



namespace EstateLogic
{
    [Serializable()]
    public class BuildingManager
    {
        // List<Building> buildings = new List<Building>(); // if this demo program were to be deployed, addition function to increase array size would be needed
        ListBox buildingTypeSelector, typeOfspecifiedBuildingList;
        RichTextBox output;      

        /// <summary>
        /// Due to the scope of this assignment I haven't made the print and search functions look nice or incorperate special functionality such as search by Country,
        /// or represent the values an item prints. NO regard to efficiency, I could break this class into several classes which deal with updating listboxes searching collections etc.
        /// I am just saying this to let anyone reading know. That I know it's not pretty.
        /// </summary>
        /// <param name="_buildingTypeSelector"></param>
        /// <param name="_typeOfSpecifiedBuildingList"></param>
        /// <param name="_addNewPorpoertyCountryList"></param>
        /// <param name="_changeItemCountryList"></param>
        /// <param name="_outputWindow"></param>
        public BuildingManager(ListBox _buildingTypeSelector, ListBox _typeOfSpecifiedBuildingList, ListBox _addNewPorpoertyCountryList,
            ListBox _changeItemCountryList, RichTextBox _outputWindow)
        {
            buildingTypeSelector = _buildingTypeSelector;
            typeOfspecifiedBuildingList = _typeOfSpecifiedBuildingList;
            
            output = _outputWindow;
            FillCountryList(_addNewPorpoertyCountryList);
            FillCountryList(_changeItemCountryList);              
        }               

        /// <summary>
        /// Fills out the listbox containing the countries
        /// </summary>
        void FillCountryList(ListBox countriesList)
        {
            countriesList.Items.Clear();
            foreach (CountryCollection.Countries c in Enum.GetValues(typeof(CountryCollection.Countries)))
            {
                countriesList.Items.Add(c);
            }
        }
        /// <summary>
        /// Checks which type of building, then changes the data in the next listbox (so that if resident is selected, residental types are presented in the next listbox) gets called everytime you select an item in the type list box
        /// </summary>
        public void CheckType()
        {
            typeOfspecifiedBuildingList.Items.Clear();
            if (buildingTypeSelector.SelectedItem != null)
            {
                if ((string)buildingTypeSelector.SelectedItem == "Commercial")
                {
                    Console.WriteLine("Success");
                    BuildCommercialCollection();
                }
                else
                {
                    BuildResidentalCollection();
                }
            }
        }
        /// <summary>
        /// sets ListValues as Commercial values
        /// </summary>
        void BuildCommercialCollection()
        {
            typeOfspecifiedBuildingList.Items.Clear();
            typeOfspecifiedBuildingList.Items.Add("Shop");
            typeOfspecifiedBuildingList.Items.Add("Warehouse");
        }
        /// <summary>
        /// sets list values as residental types
        /// </summary>
        void BuildResidentalCollection()
        {
            typeOfspecifiedBuildingList.Items.Clear();
            typeOfspecifiedBuildingList.Items.Add("House");
            typeOfspecifiedBuildingList.Items.Add("Villa");
            typeOfspecifiedBuildingList.Items.Add("Apartment");
            typeOfspecifiedBuildingList.Items.Add("Townhouse");
        }

        public ListManager<Building> FindBuildings(string searchWord, ListManager<Building> buildings)
        {
            ListManager<Building> searchResults = new ListManager<Building>();

            for (int i = 0; i < buildings.Count; i++)
            {
                if (buildings[i] != null)
                {
                    for (int j = 0; j < buildings[i].BuildingInfo.Count; j++)
                    {
                        if (buildings[i].BuildingInfo[j] == searchWord)
                            searchResults.Add(buildings[i]);
                    }
                }
            }
            return searchResults;
        }

        /// <summary>
        /// Removes the old item and adds a new item with the altered values
        /// </summary>
        /// <param name="item"></param>
        /// <param name="variableIndex"></param>
        /// <param name="newValue"></param>
        public void ChangeItem(Building item, int variableIndex, string newValue, ListManager<Building> buildings)
        {
            buildings.Remove(item);
            item.BuildingInfo[variableIndex] = newValue;
            buildings.Add(item);

            if (output.InvokeRequired)
            {
                output.Invoke(new Action(() => output.Update()));
            }
            ShowListed(buildings);
        }
        /// <summary>
        /// presents all the compressed info of the buildings in the collection, one building per line each attribute seperated by a tab.      
        /// </summary>
        public void ShowListed(ListManager<Building> buildings)
        {
            output.Invoke(new Action(() => output.Clear()));
            // GetSerializedInfo();
            foreach (Building s in buildings)
            {
                if (s != null)
                {
                    for (int i = 0; i < s.BuildingInfo.Count; i++)
                    {
                        output.Text += s.BuildingInfo[i] + "\t";
                    }
                    output.Text += "\n\n";
                }
            }
            output.Invoke(new Action(() => output.Update()));
        }     
    }
}
