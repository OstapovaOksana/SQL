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
    public partial class Form7 : Form
    {
        private Residential_ComplexDataSetTableAdapters.Realtors3TableAdapter tableAdapter;
        public Form7()
        {
            InitializeComponent();
            tableAdapter = new Residential_ComplexDataSetTableAdapters.Realtors3TableAdapter();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.R_Company' table. You can move, or remove it, as needed.
            this.r_CompanyTableAdapter.Fill(this.residential_ComplexDataSet.R_Company);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable = tableAdapter.GetData((int)comboBox1.SelectedValue);
            r_CompanyTableAdapter.Update(residential_ComplexDataSet);
            listBox1.DataSource = dataTable;
            listBox1.DisplayMember = dataTable.Columns["Name"].ToString();
            if (listBox1.Text == "")
            {
                MessageBox.Show("Збігів не знайдено!");
            }
        }
    }
}
