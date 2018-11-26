using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using EstateLogic;


namespace NETNon_beginnersAssignments
{
    public partial class Form1 : Form
    {
        List<Building> buildingList;
        ListManager<Building> buildings;
        BuildingManager bm;
        string BinaryPath, XMLPath;

        public Form1()
        {
            InitializeComponent();
            bm = new BuildingManager(CategoryListBox, TypeListBox, CountryListBox, CountryListBoxChange, OutPutWindowBox);
            buildings = new ListManager<Building>();
            XMLPath = "XMLinfo"; // defaults xml location
        }
        /// <summary>
        /// Get the proper building type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                bm.CheckType();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        ///  tries to assemble all the variables and save these to the custom collection, if it fails the application wont terminate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBuilding_Click(object sender, EventArgs e)
        {
            try
            {
                if (CategoryListBox.Text == "Residental")
                    buildings.Add(new Residental(StreetTextBox.Text, CityTextBox.Text, CountryListBox.SelectedItem.ToString(), IdTextBox.Text, ZipTextBox.Text, LeaseTypeListBox.Text, TypeListBox.Text));
                else if (CategoryListBox.Text == "Commercial")
                {
                    buildings.Add(new Commercial(StreetTextBox.Text, CityTextBox.Text, CountryListBox.SelectedItem.ToString(), IdTextBox.Text, ZipTextBox.Text, LeaseTypeListBox.Text, TypeListBox.Text));
                }
                else
                {
                    Console.WriteLine("Failed to Save building");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                ClearBoxes();
            }
        }
        /// <summary>
        /// shows all teh existing buildings to a richtextbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadSavedBuildings_Click(object sender, EventArgs e)
        {
            try
            {
                bm.ShowListed(buildings);
                ClearBoxes();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
        /// <summary>
        /// finds all instances containing the searchword then saves these to 2 lists, one listbox where the item is "coverted" to a string.
        /// The other list is an actual mirror list which saves the building items for use in the remove and change item functions.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeDeleteOutputList.Items.Clear();
                buildingList = new List<Building>();

                buildingList = bm.FindBuildings(SearchTextBox.Text, buildings);

                foreach (Building b in buildingList)
                {
                    string result = "";
                    foreach (string s in b.BuildingInfo)
                    {
                        result += s + "\t";
                    }
                    ChangeDeleteOutputList.Items.Add(result);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        /// <summary>
        /// changes the item with a special case for selection of countries which we pick out from a predefined list.
        /// Calls a change funtion in the manager located in the samplelibrary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplyChangeButton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i <= ChangeDeleteOutputList.Items.Count - 1; i++)
                {
                    if (buildingList[i] != null)
                    {
                        int p = ChangeDeleteOutputList.SelectedIndex;
                        Building b = buildingList[p];

                        if (b != null)
                        {
                            if (SelectVarableToChangeList.SelectedItem.ToString() == "Country")
                            {
                                newVariableTextbox.Text = CountryListBoxChange.SelectedItem.ToString();
                            }
                            bm.ChangeItem(b, SelectVarableToChangeList.SelectedIndex, newVariableTextbox.Text, buildings);
                            ChangeDeleteOutputList.Items.RemoveAt(p);
                        }
                    }
                }
                ClearBoxes();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
        /// <summary>
        /// After searching for an item, this item can be selected in its listbox and deleted through the button.
        /// Calls a remove funtion in the manager located in the samplelibrary
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i <= ChangeDeleteOutputList.Items.Count - 1; i++)
                {
                    if (buildingList[i] != null)
                    {
                        int p = ChangeDeleteOutputList.SelectedIndex;
                        Building b = buildingList[p];
                        buildings.Remove(b);
                        ChangeDeleteOutputList.Items.RemoveAt(p);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        /// <summary>
        /// opens save as dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.Title = "Save Binary File";
            saveFileDialog1.Filter = "Binary File (*.bin*)|*.bin";
            saveFileDialog1.RestoreDirectory = true;

            saveFileDialog1.ShowDialog();
        }
        /// <summary>
        /// upon selected a directiory, saves the binary info to that directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                string saveFile = saveFileDialog1.FileName;
                Save(saveFile);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        /// <summary>
        /// opens the dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void manuOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Binary File (*.bin*)|*.bin";
            openFileDialog1.ShowDialog();
        }
        /// <summary>
        /// open teh selected directory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            try
            {
                openFileDialog1.CheckFileExists = true;
                openFileDialog1.CheckPathExists = true;
                openFileDialog1.RestoreDirectory = true;
                string saveFile = openFileDialog1.FileName;
                Load1(saveFile);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (!Save())
                mnuSaveAs_Click(this, EventArgs.Empty);
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            ClearOutput();
            buildings.Clear();
            bm = new BuildingManager(CategoryListBox, TypeListBox, CountryListBox, CountryListBoxChange, OutPutWindowBox);
        }

        private void ClearBoxes()
        {
            CategoryListBox.ClearSelected();
            TypeListBox.ClearSelected();
            IdTextBox.Text = null;
            StreetTextBox.Text = null;
            ZipTextBox.Text = null;
            CityTextBox.Text = null;
            CountryListBox.ClearSelected();
            CountryListBoxChange.ClearSelected();
            SearchTextBox.Text = null;
            ChangeDeleteOutputList.ClearSelected();
            ChangeDeleteOutputList.Items.Clear();
            newVariableTextbox.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearOutput();
        }

        private void ClearOutput()
        {
            OutPutWindowBox.Text = null;
        }

        /// <summary>
        /// takes and sets a filepath tehn proceeds to serialize the information to that path, creating a file at the location.
        /// </summary>
        /// <param name="filePath"></param>
        void Save(string filePath)
        {
            BinaryPath = filePath;
            buildings.BinarySerialize(BinaryPath);
            buildings.XMLSerialize(XMLPath);
        }
        /// <summary>
        /// overload for the Save function. Doesn't set a new path. If no path is chosen, flags.
        /// </summary>
        bool Save()
        {
            if (BinaryPath == null)
                return false;
            buildings.BinarySerialize(BinaryPath);
            buildings.XMLSerialize(XMLPath);
            return true;
        }
        /// <summary>
        /// clears the previous collectionn then deserializes the file at the location and refills the collection with the new data
        /// </summary>
        /// <param name="filePath"></param>
        void Load1(string filePath)
        {
            buildings = (ListManager<Building>)buildings.BinaryDeSerialize(filePath);
            buildings.XMLDeSerialize(XMLPath);
            bm.ShowListed(buildings);
        }
    }
}
