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
    public partial class Form6 : Form
    {
        private Residential_ComplexDataSetTableAdapters.Realtors2TableAdapter realtors2TableAdapter;
        public Form6()
        {
            InitializeComponent();
            realtors2TableAdapter = new Residential_ComplexDataSetTableAdapters.Realtors2TableAdapter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dataTable = realtors2TableAdapter.GetData((int) comboBox1.SelectedValue);
            realtorsTableAdapter.Update(residential_ComplexDataSet);
            listBox1.DataSource = dataTable;
            listBox1.DisplayMember = dataTable.Columns["Name"].ToString();
            if (listBox1.Text == "")
            {
                MessageBox.Show("Збігів не знайдено!");
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.Realtors' table. You can move, or remove it, as needed.
            this.realtorsTableAdapter.Fill(this.residential_ComplexDataSet.Realtors);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dataTable = realtors2TableAdapter.GetDataBy();
            realtorsTableAdapter.Update(residential_ComplexDataSet);
            listBox1.DataSource = dataTable;
            listBox1.DisplayMember = dataTable.Columns["Name"].ToString();
            if (listBox1.Text == "")
            {
                MessageBox.Show("Збігів не знайдено!");
            }
        }
    }
}
