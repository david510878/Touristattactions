namespace Tourist_Attractions
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label restaurantsLabel;
            System.Windows.Forms.Label storesLabel;
            System.Windows.Forms.Label sightseeingLabel;
            System.Windows.Forms.Label toursLabel;
            System.Windows.Forms.Label hotelsLabel;
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label travel_TimeLabel;
            System.Windows.Forms.Label currencyLabel;
            System.Windows.Forms.Label pictureLabel;
            System.Windows.Forms.Label iD2Label;
            this.placesStuffDataSet = new Tourist_Attractions.PlacesStuffDataSet();
            this.stuff_to_do_in_placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stuff_to_do_in_placeTableAdapter = new Tourist_Attractions.PlacesStuffDataSetTableAdapters.Stuff_to_do_in_placeTableAdapter();
            this.tableAdapterManager = new Tourist_Attractions.PlacesStuffDataSetTableAdapters.TableAdapterManager();
            this.restaurantsTextBox = new System.Windows.Forms.TextBox();
            this.storesTextBox = new System.Windows.Forms.TextBox();
            this.sightseeingTextBox = new System.Windows.Forms.TextBox();
            this.toursTextBox = new System.Windows.Forms.TextBox();
            this.hotelsTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.travel_TimeTextBox = new System.Windows.Forms.TextBox();
            this.currencyTextBox = new System.Windows.Forms.TextBox();
            this.pictureTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Backbutton = new System.Windows.Forms.Button();
            this.Firstbutton = new System.Windows.Forms.Button();
            this.Lastbutton = new System.Windows.Forms.Button();
            this.Nextbutton = new System.Windows.Forms.Button();
            this.Previousbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iD2TextBox = new System.Windows.Forms.TextBox();
            restaurantsLabel = new System.Windows.Forms.Label();
            storesLabel = new System.Windows.Forms.Label();
            sightseeingLabel = new System.Windows.Forms.Label();
            toursLabel = new System.Windows.Forms.Label();
            hotelsLabel = new System.Windows.Forms.Label();
            locationLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            travel_TimeLabel = new System.Windows.Forms.Label();
            currencyLabel = new System.Windows.Forms.Label();
            pictureLabel = new System.Windows.Forms.Label();
            iD2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.placesStuffDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuff_to_do_in_placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // restaurantsLabel
            // 
            restaurantsLabel.AutoSize = true;
            restaurantsLabel.Location = new System.Drawing.Point(431, 292);
            restaurantsLabel.Name = "restaurantsLabel";
            restaurantsLabel.Size = new System.Drawing.Size(67, 13);
            restaurantsLabel.TabIndex = 3;
            restaurantsLabel.Text = "Restaurants:";
            // 
            // storesLabel
            // 
            storesLabel.AutoSize = true;
            storesLabel.Location = new System.Drawing.Point(458, 188);
            storesLabel.Name = "storesLabel";
            storesLabel.Size = new System.Drawing.Size(40, 13);
            storesLabel.TabIndex = 5;
            storesLabel.Text = "Stores:";
            // 
            // sightseeingLabel
            // 
            sightseeingLabel.AutoSize = true;
            sightseeingLabel.Location = new System.Drawing.Point(433, 214);
            sightseeingLabel.Name = "sightseeingLabel";
            sightseeingLabel.Size = new System.Drawing.Size(65, 13);
            sightseeingLabel.TabIndex = 7;
            sightseeingLabel.Text = "Sightseeing:";
            // 
            // toursLabel
            // 
            toursLabel.AutoSize = true;
            toursLabel.Location = new System.Drawing.Point(461, 240);
            toursLabel.Name = "toursLabel";
            toursLabel.Size = new System.Drawing.Size(37, 13);
            toursLabel.TabIndex = 9;
            toursLabel.Text = "Tours:";
            // 
            // hotelsLabel
            // 
            hotelsLabel.AutoSize = true;
            hotelsLabel.Location = new System.Drawing.Point(458, 266);
            hotelsLabel.Name = "hotelsLabel";
            hotelsLabel.Size = new System.Drawing.Size(40, 13);
            hotelsLabel.TabIndex = 11;
            hotelsLabel.Text = "Hotels:";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(447, 136);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(51, 13);
            locationLabel.TabIndex = 13;
            locationLabel.Text = "Location:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(464, 318);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(34, 13);
            priceLabel.TabIndex = 15;
            priceLabel.Text = "Price:";
            // 
            // travel_TimeLabel
            // 
            travel_TimeLabel.AutoSize = true;
            travel_TimeLabel.Location = new System.Drawing.Point(432, 344);
            travel_TimeLabel.Name = "travel_TimeLabel";
            travel_TimeLabel.Size = new System.Drawing.Size(66, 13);
            travel_TimeLabel.TabIndex = 17;
            travel_TimeLabel.Text = "Travel Time:";
            // 
            // currencyLabel
            // 
            currencyLabel.AutoSize = true;
            currencyLabel.Location = new System.Drawing.Point(446, 370);
            currencyLabel.Name = "currencyLabel";
            currencyLabel.Size = new System.Drawing.Size(52, 13);
            currencyLabel.TabIndex = 19;
            currencyLabel.Text = "Currency:";
            // 
            // pictureLabel
            // 
            pictureLabel.AutoSize = true;
            pictureLabel.Location = new System.Drawing.Point(572, 474);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new System.Drawing.Size(43, 13);
            pictureLabel.TabIndex = 21;
            pictureLabel.Text = "Picture:";
            // 
            // placesStuffDataSet
            // 
            this.placesStuffDataSet.DataSetName = "PlacesStuffDataSet";
            this.placesStuffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stuff_to_do_in_placeBindingSource
            // 
            this.stuff_to_do_in_placeBindingSource.DataMember = "Stuff to do in place";
            this.stuff_to_do_in_placeBindingSource.DataSource = this.placesStuffDataSet;
            // 
            // stuff_to_do_in_placeTableAdapter
            // 
            this.stuff_to_do_in_placeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlaceTableAdapter = null;
            this.tableAdapterManager.Stuff_to_do_in_placeTableAdapter = this.stuff_to_do_in_placeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Tourist_Attractions.PlacesStuffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // restaurantsTextBox
            // 
            this.restaurantsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuff_to_do_in_placeBindingSource, "Restaurants", true));
            this.restaurantsTextBox.Location = new System.Drawing.Point(504, 289);
            this.restaurantsTextBox.Name = "restaurantsTextBox";
            this.restaurantsTextBox.Size = new System.Drawing.Size(100, 20);
            this.restaurantsTextBox.TabIndex = 4;
            // 
            // storesTextBox
            // 
            this.storesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuff_to_do_in_placeBindingSource, "Stores", true));
            this.storesTextBox.Location = new System.Drawing.Point(504, 185);
            this.storesTextBox.Name = "storesTextBox";
            this.storesTextBox.Size = new System.Drawing.Size(100, 20);
            this.storesTextBox.TabIndex = 6;
            // 
            // sightseeingTextBox
            // 
            this.sightseeingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuff_to_do_in_placeBindingSource, "Sightseeing", true));
            this.sightseeingTextBox.Location = new System.Drawing.Point(504, 211);
            this.sightseeingTextBox.Name = "sightseeingTextBox";
            this.sightseeingTextBox.Size = new System.Drawing.Size(100, 20);
            this.sightseeingTextBox.TabIndex = 8;
            // 
            // toursTextBox
            // 
            this.toursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuff_to_do_in_placeBindingSource, "Tours", true));
            this.toursTextBox.Location = new System.Drawing.Point(504, 237);
            this.toursTextBox.Name = "toursTextBox";
            this.toursTextBox.Size = new System.Drawing.Size(100, 20);
            this.toursTextBox.TabIndex = 10;
            // 
            // hotelsTextBox
            // 
            this.hotelsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuff_to_do_in_placeBindingSource, "Hotels", true));
            this.hotelsTextBox.Location = new System.Drawing.Point(504, 263);
            this.hotelsTextBox.Name = "hotelsTextBox";
            this.hotelsTextBox.Size = new System.Drawing.Size(100, 20);
            this.hotelsTextBox.TabIndex = 12;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuff_to_do_in_placeBindingSource, "Location", true));
            this.locationTextBox.Location = new System.Drawing.Point(504, 133);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(100, 20);
            this.locationTextBox.TabIndex = 14;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuff_to_do_in_placeBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(504, 315);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.priceTextBox.TabIndex = 16;
            // 
            // travel_TimeTextBox
            // 
            this.travel_TimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuff_to_do_in_placeBindingSource, "Travel Time", true));
            this.travel_TimeTextBox.Location = new System.Drawing.Point(504, 341);
            this.travel_TimeTextBox.Name = "travel_TimeTextBox";
            this.travel_TimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.travel_TimeTextBox.TabIndex = 18;
            // 
            // currencyTextBox
            // 
            this.currencyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuff_to_do_in_placeBindingSource, "Currency", true));
            this.currencyTextBox.Location = new System.Drawing.Point(504, 367);
            this.currencyTextBox.Name = "currencyTextBox";
            this.currencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.currencyTextBox.TabIndex = 20;
            // 
            // pictureTextBox
            // 
            this.pictureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuff_to_do_in_placeBindingSource, "Picture", true));
            this.pictureTextBox.Location = new System.Drawing.Point(621, 471);
            this.pictureTextBox.Name = "pictureTextBox";
            this.pictureTextBox.Size = new System.Drawing.Size(100, 20);
            this.pictureTextBox.TabIndex = 22;
            this.pictureTextBox.TextChanged += new System.EventHandler(this.pictureTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(55, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.Location = new System.Drawing.Point(12, 27);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(75, 23);
            this.Backbutton.TabIndex = 24;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Firstbutton
            // 
            this.Firstbutton.Location = new System.Drawing.Point(34, 395);
            this.Firstbutton.Name = "Firstbutton";
            this.Firstbutton.Size = new System.Drawing.Size(75, 23);
            this.Firstbutton.TabIndex = 25;
            this.Firstbutton.Text = "First";
            this.Firstbutton.UseVisualStyleBackColor = true;
            this.Firstbutton.Click += new System.EventHandler(this.Firstbutton_Click);
            // 
            // Lastbutton
            // 
            this.Lastbutton.Location = new System.Drawing.Point(115, 395);
            this.Lastbutton.Name = "Lastbutton";
            this.Lastbutton.Size = new System.Drawing.Size(75, 23);
            this.Lastbutton.TabIndex = 26;
            this.Lastbutton.Text = "Last";
            this.Lastbutton.UseVisualStyleBackColor = true;
            this.Lastbutton.Click += new System.EventHandler(this.Lastbutton_Click);
            // 
            // Nextbutton
            // 
            this.Nextbutton.Location = new System.Drawing.Point(196, 395);
            this.Nextbutton.Name = "Nextbutton";
            this.Nextbutton.Size = new System.Drawing.Size(75, 23);
            this.Nextbutton.TabIndex = 27;
            this.Nextbutton.Text = "Next";
            this.Nextbutton.UseVisualStyleBackColor = true;
            this.Nextbutton.Click += new System.EventHandler(this.Nextbutton_Click);
            // 
            // Previousbutton
            // 
            this.Previousbutton.Location = new System.Drawing.Point(277, 395);
            this.Previousbutton.Name = "Previousbutton";
            this.Previousbutton.Size = new System.Drawing.Size(75, 23);
            this.Previousbutton.TabIndex = 28;
            this.Previousbutton.Text = "Previous";
            this.Previousbutton.UseVisualStyleBackColor = true;
            this.Previousbutton.Click += new System.EventHandler(this.Previousbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(479, 12);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 29;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(560, 12);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(75, 23);
            this.Deletebutton.TabIndex = 30;
            this.Deletebutton.Text = "Delete";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(641, 12);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 31;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // iD2Label
            // 
            iD2Label.AutoSize = true;
            iD2Label.Location = new System.Drawing.Point(471, 162);
            iD2Label.Name = "iD2Label";
            iD2Label.Size = new System.Drawing.Size(21, 13);
            iD2Label.TabIndex = 31;
            iD2Label.Text = "ID:";
            // 
            // iD2TextBox
            // 
            this.iD2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.stuff_to_do_in_placeBindingSource, "ID2", true));
            this.iD2TextBox.Location = new System.Drawing.Point(504, 159);
            this.iD2TextBox.Name = "iD2TextBox";
            this.iD2TextBox.Size = new System.Drawing.Size(100, 20);
            this.iD2TextBox.TabIndex = 32;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(741, 511);
            this.Controls.Add(iD2Label);
            this.Controls.Add(this.iD2TextBox);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Previousbutton);
            this.Controls.Add(this.Nextbutton);
            this.Controls.Add(this.Lastbutton);
            this.Controls.Add(this.Firstbutton);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(pictureLabel);
            this.Controls.Add(this.pictureTextBox);
            this.Controls.Add(currencyLabel);
            this.Controls.Add(this.currencyTextBox);
            this.Controls.Add(travel_TimeLabel);
            this.Controls.Add(this.travel_TimeTextBox);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(hotelsLabel);
            this.Controls.Add(this.hotelsTextBox);
            this.Controls.Add(toursLabel);
            this.Controls.Add(this.toursTextBox);
            this.Controls.Add(sightseeingLabel);
            this.Controls.Add(this.sightseeingTextBox);
            this.Controls.Add(storesLabel);
            this.Controls.Add(this.storesTextBox);
            this.Controls.Add(restaurantsLabel);
            this.Controls.Add(this.restaurantsTextBox);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.placesStuffDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuff_to_do_in_placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlacesStuffDataSet placesStuffDataSet;
        private System.Windows.Forms.BindingSource stuff_to_do_in_placeBindingSource;
        private PlacesStuffDataSetTableAdapters.Stuff_to_do_in_placeTableAdapter stuff_to_do_in_placeTableAdapter;
        private PlacesStuffDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox restaurantsTextBox;
        private System.Windows.Forms.TextBox storesTextBox;
        private System.Windows.Forms.TextBox sightseeingTextBox;
        private System.Windows.Forms.TextBox toursTextBox;
        private System.Windows.Forms.TextBox hotelsTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox travel_TimeTextBox;
        private System.Windows.Forms.TextBox currencyTextBox;
        private System.Windows.Forms.TextBox pictureTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.Button Firstbutton;
        private System.Windows.Forms.Button Lastbutton;
        private System.Windows.Forms.Button Nextbutton;
        private System.Windows.Forms.Button Previousbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox iD2TextBox;
    }
}