using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tourist_Attractions
{
    public partial class Form1 : Form
    {
        int time = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            String bruh = textBox2.Text;
            String selected = comboBox1.Text;

            this.Hide();
            Form2 form1 = new Form2(bruh, selected);
            form1.Closed += (s, args) => this.Close();
            form1.ShowDialog();
            
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            this.stuff_to_do_in_placeTableAdapter.Fill(this.placesStuffDataSet.Stuff_to_do_in_place);

            BackGround();
        }
        private void BackGround()
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ++time;
            if (time % 1 == 0)
            {
                this.BackgroundImage = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "\\car.PNG");
                
            }

            if (time % 2 == 0)
            {
                this.BackgroundImage = System.Drawing.Image.FromFile(Environment.CurrentDirectory + "\\CoolBeans.jpg");
            }

        }

        private void placeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.placeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.placesStuffDataSet);

        }

    }
}
/*
    String bruh = textBox2.Text;
            try
            {
                var contactDetails =
                   from c in placesStuffDataSet.Stuff_to_do_in_place
                   where c.Location == bruh
                   select c;
                   stuff_to_do_in_placeDataGridView.DataSource = contactDetails.AsDataView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
*/
