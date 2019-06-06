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
    public partial class Add_comp : Form
    {
        private Residential_ComplexDataSetTableAdapters.R_CompanyTableAdapter rcAdapter;

        public Add_comp()
        {
            InitializeComponent();
            rcAdapter = new Residential_ComplexDataSetTableAdapters.R_CompanyTableAdapter();
        }

        private void add()
        {
            if (textBox1.Text == "" || textBox2.Text == "" || (int)numericUpDown1.Value == 0 || textBox3.Text == "")
            {
                MessageBox.Show("Ви не заповнили всі поля!", "Помилка додавання");
            }
            else
            {
                var rcRow = residential_ComplexDataSet.R_Company.AddR_CompanyRow(textBox1.Text, textBox2.Text, (int)numericUpDown1.Value, textBox3.Text);

                rcAdapter.Update(residential_ComplexDataSet);
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();
        }
    }
}
