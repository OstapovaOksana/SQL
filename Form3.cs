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
    public partial class Form3 : Form
    {
        private Residential_ComplexDataSetTableAdapters.DataTable1TableAdapter fAdapter;
        public Form3()
        {
            InitializeComponent();
            fAdapter = new Residential_ComplexDataSetTableAdapters.DataTable1TableAdapter();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.GK' table. You can move, or remove it, as needed.
            this.gKTableAdapter.Fill(this.residential_ComplexDataSet.GK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.Fill(residential_ComplexDataSet.DataTable1, (int)comboBox1.SelectedValue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.FillBy(residential_ComplexDataSet.DataTable1, (double)numericUpDown1.Value, (double)numericUpDown2.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.FillBy1(residential_ComplexDataSet.DataTable1, (int)numericUpDown3.Value, (int)numericUpDown4.Value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.dataTable1TableAdapter.FillBy2(residential_ComplexDataSet.DataTable1, (int)numericUpDown5.Value);
        }
    }
}
