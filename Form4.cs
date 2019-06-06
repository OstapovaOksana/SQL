using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FlatRent
{
    public partial class Form4 : Form
    {
        private Residential_ComplexDataSetTableAdapters.Realtors1TableAdapter qAdapter;
        public Form4()
        {
            InitializeComponent();
            qAdapter = new Residential_ComplexDataSetTableAdapters.Realtors1TableAdapter();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.Flats' table. You can move, or remove it, as needed.
            this.flatsTableAdapter.Fill(this.residential_ComplexDataSet.Flats);
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.GK' table. You can move, or remove it, as needed.
            this.gKTableAdapter.Fill(this.residential_ComplexDataSet.GK);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = qAdapter.GetData((int)comboBox1.SelectedValue, (int)comboBox2.SelectedValue);
            gKTableAdapter.Update(residential_ComplexDataSet);
            listBox1.DataSource = dataTable;
            listBox1.DisplayMember = dataTable.Columns["Name"].ToString();
            if (listBox1.Text == "")
            {
                MessageBox.Show("Збігів не знайдено!");
            }
        }
    }
}
