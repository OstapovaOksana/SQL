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
    public partial class Add_flat : Form
    {
        private Residential_ComplexDataSetTableAdapters.FlatsTableAdapter flatAdapter;
        public Add_flat()
        {
            InitializeComponent();
            flatAdapter = new Residential_ComplexDataSetTableAdapters.FlatsTableAdapter();
        }

        private void Add_flat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.GK' table. You can move, or remove it, as needed.
            this.gKTableAdapter.Fill(this.residential_ComplexDataSet.GK);
        }

        private void add()
        {
            if ((int)numericUpDown1.Value == 0 || (double)numericUpDown3.Value == 0 || (int)numericUpDown2.Value == 0 || (int)numericUpDown4.Value == 0)
            {
                MessageBox.Show("Ви не заповнили всі поля!", "Помилка додавання");
            }
            else
            {
                var flatRow = residential_ComplexDataSet.Flats.AddFlatsRow((int)numericUpDown1.Value, null, (int)numericUpDown3.Value, (int)numericUpDown4.Value, (int)numericUpDown2.Value);
                int gkid = 0;
                var sql1 = string.Format("Select GK_ID from dbo.GK Where Name = N'" +
                    comboBox1.GetItemText(comboBox1.SelectedItem) + "'");
                using (var con = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
                {
                    var cmd1 = new SqlCommand(sql1, con);
                    try
                    {
                        con.Open();
                        gkid = (int)cmd1.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    MessageBox.Show("Квартиру було успішно додано!");
                }
                flatRow.GK_ID = gkid;
                flatAdapter.Update(residential_ComplexDataSet);
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();
        }
    }
}
