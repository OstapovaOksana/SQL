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
    public partial class Form9 : Form
    {
        private Residential_ComplexDataSetTableAdapters.Flats2TableAdapter tableAdapter;
        public Form9()
        {
            InitializeComponent();
            tableAdapter = new Residential_ComplexDataSetTableAdapters.Flats2TableAdapter();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.residential_ComplexDataSet.Status);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = tableAdapter.GetData((int)comboBox1.SelectedValue);
            statusTableAdapter.Update(residential_ComplexDataSet);
            listBox1.DataSource = dataTable;
            listBox1.DisplayMember = dataTable.Columns["Number"].ToString();
            if (listBox1.Text == "")
            {
                MessageBox.Show("Збігів не знайдено!");
            }
        }
    }
}
