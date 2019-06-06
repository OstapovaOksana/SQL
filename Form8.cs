using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatRent
{
    public partial class Form8 : Form
    {
        private Residential_ComplexDataSetTableAdapters.Flats1TableAdapter adapter;
        public Form8()
        {
            InitializeComponent();
            adapter = new Residential_ComplexDataSetTableAdapters.Flats1TableAdapter();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.Realtors' table. You can move, or remove it, as needed.
            this.realtorsTableAdapter.Fill(this.residential_ComplexDataSet.Realtors);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = adapter.GetData((int)comboBox1.SelectedValue);
            realtorsTableAdapter.Update(residential_ComplexDataSet);
            listBox1.DataSource = dataTable;
            listBox1.DisplayMember = dataTable.Columns["Number"].ToString();
            if (listBox1.Text == "")
            {
                MessageBox.Show("Збігів не знайдено!");
            }
        }
    }
}
