namespace NETNon_beginnersAssignments
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SaveBuildingTab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoadSavedBuildings = new System.Windows.Forms.Button();
            this.OutPutWindowBox = new System.Windows.Forms.RichTextBox();
            this.SaveBuilding = new System.Windows.Forms.Button();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.ZipTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CountryListBox = new System.Windows.Forms.ListBox();
            this.LeaseTypeListBox = new System.Windows.Forms.ListBox();
            this.TypeListBox = new System.Windows.Forms.ListBox();
            this.CategoryListBox = new System.Windows.Forms.ListBox();
            this.ChangeSavedBuildingTab = new System.Windows.Forms.TabPage();
            this.CountryListBoxChange = new System.Windows.Forms.ListBox();
            this.RemoveSelectedButton = new System.Windows.Forms.Button();
            this.ApplyChangeButton = new System.Windows.Forms.Button();
            this.newVariableTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SelectVarableToChangeList = new System.Windows.Forms.ListBox();
            this.ChangeDeleteOutputList = new System.Windows.Forms.ListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.manuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SaveBuildingTab.SuspendLayout();
            this.ChangeSavedBuildingTab.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SaveBuildingTab);
            this.tabControl1.Controls.Add(this.ChangeSavedBuildingTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 424);
            this.tabControl1.TabIndex = 3;
            // 
            // SaveBuildingTab
            // 
            this.SaveBuildingTab.Controls.Add(this.button1);
            this.SaveBuildingTab.Controls.Add(this.label4);
            this.SaveBuildingTab.Controls.Add(this.label3);
            this.SaveBuildingTab.Controls.Add(this.label2);
            this.SaveBuildingTab.Controls.Add(this.label1);
            this.SaveBuildingTab.Controls.Add(this.LoadSavedBuildings);
            this.SaveBuildingTab.Controls.Add(this.OutPutWindowBox);
            this.SaveBuildingTab.Controls.Add(this.SaveBuilding);
            this.SaveBuildingTab.Controls.Add(this.CityTextBox);
            this.SaveBuildingTab.Controls.Add(this.ZipTextBox);
            this.SaveBuildingTab.Controls.Add(this.StreetTextBox);
            this.SaveBuildingTab.Controls.Add(this.IdTextBox);
            this.SaveBuildingTab.Controls.Add(this.CountryListBox);
            this.SaveBuildingTab.Controls.Add(this.LeaseTypeListBox);
            this.SaveBuildingTab.Controls.Add(this.TypeListBox);
            this.SaveBuildingTab.Controls.Add(this.CategoryListBox);
            this.SaveBuildingTab.Location = new System.Drawing.Point(4, 22);
            this.SaveBuildingTab.Name = "SaveBuildingTab";
            this.SaveBuildingTab.Padding = new System.Windows.Forms.Padding(3);
            this.SaveBuildingTab.Size = new System.Drawing.Size(639, 398);
            this.SaveBuildingTab.TabIndex = 0;
            this.SaveBuildingTab.Text = "Save New Building";
            this.SaveBuildingTab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "city";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "zip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Street";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id";
            // 
            // LoadSavedBuildings
            // 
            this.LoadSavedBuildings.Location = new System.Drawing.Point(8, 226);
            this.LoadSavedBuildings.Name = "LoadSavedBuildings";
            this.LoadSavedBuildings.Size = new System.Drawing.Size(75, 23);
            this.LoadSavedBuildings.TabIndex = 11;
            this.LoadSavedBuildings.Text = "ShowAll";
            this.LoadSavedBuildings.UseVisualStyleBackColor = true;
            this.LoadSavedBuildings.Click += new System.EventHandler(this.LoadSavedBuildings_Click);
            // 
            // OutPutWindowBox
            // 
            this.OutPutWindowBox.Location = new System.Drawing.Point(3, 255);
            this.OutPutWindowBox.Name = "OutPutWindowBox";
            this.OutPutWindowBox.Size = new System.Drawing.Size(630, 180);
            this.OutPutWindowBox.TabIndex = 10;
            this.OutPutWindowBox.Text = "";
            // 
            // SaveBuilding
            // 
            this.SaveBuilding.Location = new System.Drawing.Point(532, 107);
            this.SaveBuilding.Name = "SaveBuilding";
            this.SaveBuilding.Size = new System.Drawing.Size(75, 23);
            this.SaveBuilding.TabIndex = 9;
            this.SaveBuilding.Text = "Save";
            this.SaveBuilding.UseVisualStyleBackColor = true;
            this.SaveBuilding.Click += new System.EventHandler(this.SaveBuilding_Click);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(214, 107);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityTextBox.TabIndex = 8;
            // 
            // ZipTextBox
            // 
            this.ZipTextBox.Location = new System.Drawing.Point(426, 107);
            this.ZipTextBox.Name = "ZipTextBox";
            this.ZipTextBox.Size = new System.Drawing.Size(100, 20);
            this.ZipTextBox.TabIndex = 7;
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(320, 107);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(100, 20);
            this.StreetTextBox.TabIndex = 6;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(6, 107);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 5;
            // 
            // CountryListBox
            // 
            this.CountryListBox.FormattingEnabled = true;
            this.CountryListBox.Location = new System.Drawing.Point(112, 107);
            this.CountryListBox.Name = "CountryListBox";
            this.CountryListBox.Size = new System.Drawing.Size(96, 95);
            this.CountryListBox.TabIndex = 3;
            // 
            // LeaseTypeListBox
            // 
            this.LeaseTypeListBox.FormattingEnabled = true;
            this.LeaseTypeListBox.Items.AddRange(new object[] {
            "Ownership",
            "Tenement",
            "Rental"});
            this.LeaseTypeListBox.Location = new System.Drawing.Point(187, 6);
            this.LeaseTypeListBox.Name = "LeaseTypeListBox";
            this.LeaseTypeListBox.Size = new System.Drawing.Size(86, 43);
            this.LeaseTypeListBox.TabIndex = 2;
            // 
            // TypeListBox
            // 
            this.TypeListBox.FormattingEnabled = true;
            this.TypeListBox.Location = new System.Drawing.Point(95, 6);
            this.TypeListBox.Name = "TypeListBox";
            this.TypeListBox.Size = new System.Drawing.Size(86, 43);
            this.TypeListBox.TabIndex = 1;
            // 
            // CategoryListBox
            // 
            this.CategoryListBox.FormattingEnabled = true;
            this.CategoryListBox.Items.AddRange(new object[] {
            "Commercial",
            "Residental"});
            this.CategoryListBox.Location = new System.Drawing.Point(3, 6);
            this.CategoryListBox.Name = "CategoryListBox";
            this.CategoryListBox.Size = new System.Drawing.Size(86, 43);
            this.CategoryListBox.TabIndex = 0;
            this.CategoryListBox.SelectedIndexChanged += new System.EventHandler(this.CategoryListBox_SelectedIndexChanged);
            // 
            // ChangeSavedBuildingTab
            // 
            this.ChangeSavedBuildingTab.Controls.Add(this.CountryListBoxChange);
            this.ChangeSavedBuildingTab.Controls.Add(this.RemoveSelectedButton);
            this.ChangeSavedBuildingTab.Controls.Add(this.ApplyChangeButton);
            this.ChangeSavedBuildingTab.Controls.Add(this.newVariableTextbox);
            this.ChangeSavedBuildingTab.Controls.Add(this.label6);
            this.ChangeSavedBuildingTab.Controls.Add(this.SelectVarableToChangeList);
            this.ChangeSavedBuildingTab.Controls.Add(this.ChangeDeleteOutputList);
            this.ChangeSavedBuildingTab.Controls.Add(this.SearchButton);
            this.ChangeSavedBuildingTab.Controls.Add(this.label5);
            this.ChangeSavedBuildingTab.Controls.Add(this.SearchTextBox);
            this.ChangeSavedBuildingTab.Location = new System.Drawing.Point(4, 22);
            this.ChangeSavedBuildingTab.Name = "ChangeSavedBuildingTab";
            this.ChangeSavedBuildingTab.Padding = new System.Windows.Forms.Padding(3);
            this.ChangeSavedBuildingTab.Size = new System.Drawing.Size(639, 398);
            this.ChangeSavedBuildingTab.TabIndex = 1;
            this.ChangeSavedBuildingTab.Text = "Change or Delete Building";
            this.ChangeSavedBuildingTab.UseVisualStyleBackColor = true;
            // 
            // CountryListBoxChange
            // 
            this.CountryListBoxChange.FormattingEnabled = true;
            this.CountryListBoxChange.Location = new System.Drawing.Point(139, 179);
            this.CountryListBoxChange.Name = "CountryListBoxChange";
            this.CountryListBoxChange.Size = new System.Drawing.Size(96, 95);
            this.CountryListBoxChange.TabIndex = 10;
            // 
            // RemoveSelectedButton
            // 
            this.RemoveSelectedButton.Location = new System.Drawing.Point(7, 88);
            this.RemoveSelectedButton.Name = "RemoveSelectedButton";
            this.RemoveSelectedButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveSelectedButton.TabIndex = 9;
            this.RemoveSelectedButton.Text = "Remove";
            this.RemoveSelectedButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // ApplyChangeButton
            // 
            this.ApplyChangeButton.Location = new System.Drawing.Point(246, 153);
            this.ApplyChangeButton.Name = "ApplyChangeButton";
            this.ApplyChangeButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyChangeButton.TabIndex = 8;
            this.ApplyChangeButton.Text = "Apply Change";
            this.ApplyChangeButton.UseVisualStyleBackColor = true;
            this.ApplyChangeButton.Click += new System.EventHandler(this.ApplyChangeButton_Click);
            // 
            // newVariableTextbox
            // 
            this.newVariableTextbox.Location = new System.Drawing.Point(139, 153);
            this.newVariableTextbox.Name = "newVariableTextbox";
            this.newVariableTextbox.Size = new System.Drawing.Size(100, 20);
            this.newVariableTextbox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Select what to change and enter new in textbox";
            // 
            // SelectVarableToChangeList
            // 
            this.SelectVarableToChangeList.FormattingEnabled = true;
            this.SelectVarableToChangeList.Items.AddRange(new object[] {
            "Id",
            "Type of building",
            "ResidentalType ",
            "Country",
            "City",
            "ZipCode",
            "Street",
            "",
            ""});
            this.SelectVarableToChangeList.Location = new System.Drawing.Point(12, 153);
            this.SelectVarableToChangeList.Name = "SelectVarableToChangeList";
            this.SelectVarableToChangeList.Size = new System.Drawing.Size(120, 95);
            this.SelectVarableToChangeList.TabIndex = 5;
            // 
            // ChangeDeleteOutputList
            // 
            this.ChangeDeleteOutputList.FormattingEnabled = true;
            this.ChangeDeleteOutputList.Location = new System.Drawing.Point(7, 39);
            this.ChangeDeleteOutputList.Name = "ChangeDeleteOutputList";
            this.ChangeDeleteOutputList.Size = new System.Drawing.Size(421, 43);
            this.ChangeDeleteOutputList.TabIndex = 4;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(136, 11);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 1;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(7, 13);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(123, 20);
            this.SearchTextBox.TabIndex = 0;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(639, 24);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.manuOpen,
            this.mnuSave,
            this.mnuSaveAs});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuNew
            // 
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(180, 22);
            this.mnuNew.Text = "New";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // manuOpen
            // 
            this.manuOpen.Name = "manuOpen";
            this.manuOpen.Size = new System.Drawing.Size(180, 22);
            this.manuOpen.Text = "Open...";
            this.manuOpen.Click += new System.EventHandler(this.manuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(180, 22);
            this.mnuSave.Text = "Save";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSaveAs
            // 
            this.mnuSaveAs.Name = "mnuSaveAs";
            this.mnuSaveAs.Size = new System.Drawing.Size(180, 22);
            this.mnuSaveAs.Text = "Save as...";
            this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "ClearOutput";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 457);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.SaveBuildingTab.ResumeLayout(false);
            this.SaveBuildingTab.PerformLayout();
            this.ChangeSavedBuildingTab.ResumeLayout(false);
            this.ChangeSavedBuildingTab.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SaveBuildingTab;
        private System.Windows.Forms.ListBox CountryListBox;
        private System.Windows.Forms.ListBox LeaseTypeListBox;
        private System.Windows.Forms.ListBox TypeListBox;
        private System.Windows.Forms.ListBox CategoryListBox;
        private System.Windows.Forms.TabPage ChangeSavedBuildingTab;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox ZipTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button SaveBuilding;
        private System.Windows.Forms.Button LoadSavedBuildings;
        private System.Windows.Forms.RichTextBox OutPutWindowBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.ListBox ChangeDeleteOutputList;
        private System.Windows.Forms.ListBox SelectVarableToChangeList;
        private System.Windows.Forms.TextBox newVariableTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ApplyChangeButton;
        private System.Windows.Forms.Button RemoveSelectedButton;
        private System.Windows.Forms.ListBox CountryListBoxChange;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem manuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveAs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}

