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
    public partial class Add_dir : Form
    {
        private Residential_ComplexDataSetTableAdapters.OwnersTableAdapter owAdapter;
        public Add_dir()
        {
            InitializeComponent();
            owAdapter = new Residential_ComplexDataSetTableAdapters.OwnersTableAdapter();
        }

        private void add()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ви не заповнили всі поля!", "Помилка додавання");
            }
            else
            {
                var dirRow = residential_ComplexDataSet.Owners.AddOwnersRow(textBox1.Text, textBox2.Text);

                owAdapter.Update(residential_ComplexDataSet);
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();
        }
    }
}
