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
    public partial class Add_r : Form
    {
        private Residential_ComplexDataSetTableAdapters.RealtorsTableAdapter rAdapter;
        public Add_r()
        {
            InitializeComponent();
            rAdapter = new Residential_ComplexDataSetTableAdapters.RealtorsTableAdapter();
        }
        private void add()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ви не заповнили всі поля!", "Помилка додавання");
            }
            else
            {
                var rRow = residential_ComplexDataSet.Realtors.AddRealtorsRow(textBox1.Text, textBox2.Text);                
                rAdapter.Update(residential_ComplexDataSet);
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();
        }
    }
}
