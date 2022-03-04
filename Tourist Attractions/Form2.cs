using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tourist_Attractions
{
    public partial class Form2 : Form
    {
        String Bruh;
        String Selected;
        public Form2(String m_bruh, String m_Selected)
        {
            InitializeComponent();
            Bruh = m_bruh;
            Selected = m_Selected;
        }

       public void filter()
        {
            /*
            var conactDetails =
                from c in placesStuffDataSet.Stuff_to_do_in_place
                where c.Urban == 
                */
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Selected == "Location")
            {
                try
                {
                    var contactDetails =
                       from c in placesStuffDataSet.Stuff_to_do_in_place
                       where c.Location == Bruh
                       select c;
                    stuff_to_do_in_placeBindingSource.DataSource = contactDetails.AsDataView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (Selected == "ID")
            {
                try
                {
                    var contactDetails =
                       from c in placesStuffDataSet.Stuff_to_do_in_place
                       where c.ID2 == Bruh
                       select c;
                    stuff_to_do_in_placeBindingSource.DataSource = contactDetails.AsDataView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            else  if (Selected == "Restaurants")
            {
                try
                {
                    var contactDetails =
                       from c in placesStuffDataSet.Stuff_to_do_in_place
                       where c.Restaurants == Bruh
                       select c;
                    stuff_to_do_in_placeBindingSource.DataSource = contactDetails.AsDataView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (Selected == "Stores")
            {
                try
                {
                    var contactDetails =
                       from c in placesStuffDataSet.Stuff_to_do_in_place
                       where c.Stores == Bruh
                       select c;
                    stuff_to_do_in_placeBindingSource.DataSource = contactDetails.AsDataView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (Selected == "Sightseeing")
            {
                try
                {
                    var contactDetails =
                       from c in placesStuffDataSet.Stuff_to_do_in_place
                       where c.Sightseeing == Bruh
                       select c;
                    stuff_to_do_in_placeBindingSource.DataSource = contactDetails.AsDataView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (Selected == "Tours")
            {
                try
                {
                    var contactDetails =
                       from c in placesStuffDataSet.Stuff_to_do_in_place
                       where c.Tours == Bruh
                       select c;
                    stuff_to_do_in_placeBindingSource.DataSource = contactDetails.AsDataView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            if (Selected == "Hotels")
            {
                try
                {
                    var contactDetails =
                       from c in placesStuffDataSet.Stuff_to_do_in_place
                       where c.Hotels == Bruh
                       select c;
                    stuff_to_do_in_placeBindingSource.DataSource = contactDetails.AsDataView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            // TODO: This line of code loads data into the 'placesStuffDataSet.Stuff_to_do_in_place' table. You can move, or remove it, as needed.
            this.stuff_to_do_in_placeTableAdapter.Fill(this.placesStuffDataSet.Stuff_to_do_in_place);            
            try
            {
                pictureBox1.Load(pictureTextBox.Text);
            }
            catch (Exception ex)
            {

            }
          
        }
        
        private void Backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form2 = new Form1();
            form2.Closed += (s, args) => this.Close();
            form2.ShowDialog();
        }

        private void Firstbutton_Click(object sender, EventArgs e)
        {
            stuff_to_do_in_placeBindingSource.MoveFirst();
        }

        private void Lastbutton_Click(object sender, EventArgs e)
        {
            stuff_to_do_in_placeBindingSource.MoveLast();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            stuff_to_do_in_placeBindingSource.MoveNext();
        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            stuff_to_do_in_placeBindingSource.MovePrevious();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            stuff_to_do_in_placeBindingSource.AddNew();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            stuff_to_do_in_placeBindingSource.RemoveCurrent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.stuff_to_do_in_placeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.placesStuffDataSet);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            pictureTextBox.Text = openFileDialog1.FileName;
        }

        private void pictureTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Load(pictureTextBox.Text);
            }
            catch (Exception ex)
            {

            }
        }

        private void iDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
