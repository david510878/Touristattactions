namespace Tourist_Attractions
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.placesStuffDataSet = new Tourist_Attractions.PlacesStuffDataSet();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placeTableAdapter = new Tourist_Attractions.PlacesStuffDataSetTableAdapters.PlaceTableAdapter();
            this.tableAdapterManager = new Tourist_Attractions.PlacesStuffDataSetTableAdapters.TableAdapterManager();
            this.stuff_to_do_in_placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stuff_to_do_in_placeTableAdapter = new Tourist_Attractions.PlacesStuffDataSetTableAdapters.Stuff_to_do_in_placeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.placesStuffDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuff_to_do_in_placeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(310, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 45);
            this.button2.TabIndex = 11;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Location",
            "ID",
            "Restaurants",
            "Stores",
            "Sightseeing",
            "Tours",
            "Hotels"});
            this.comboBox1.Location = new System.Drawing.Point(244, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 30);
            this.comboBox1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 43);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tourist Attractions";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(395, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 29);
            this.textBox2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Search by:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // placesStuffDataSet
            // 
            this.placesStuffDataSet.DataSetName = "PlacesStuffDataSet";
            this.placesStuffDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataMember = "Place";
            this.placeBindingSource.DataSource = this.placesStuffDataSet;
            // 
            // placeTableAdapter
            // 
            this.placeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PlaceTableAdapter = this.placeTableAdapter;
            this.tableAdapterManager.Stuff_to_do_in_placeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Tourist_Attractions.PlacesStuffDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.placesStuffDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuff_to_do_in_placeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private PlacesStuffDataSet placesStuffDataSet;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private PlacesStuffDataSetTableAdapters.PlaceTableAdapter placeTableAdapter;
        private PlacesStuffDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource stuff_to_do_in_placeBindingSource;
        private PlacesStuffDataSetTableAdapters.Stuff_to_do_in_placeTableAdapter stuff_to_do_in_placeTableAdapter;
    }
}

