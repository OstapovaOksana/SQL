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
    public partial class Add_GK : Form
    {
        private Residential_ComplexDataSetTableAdapters.GKTableAdapter gkAdapter;   
        public Add_GK()
        {
            InitializeComponent();
            gkAdapter = new Residential_ComplexDataSetTableAdapters.GKTableAdapter();
        }

        private void Add_GK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.residential_ComplexDataSet.Class);
        }

        private void add()
        {
            if (textBox1.Text == "" || (int)numericUpDown1.Value == 0 || textBox2.Text == "")
            {
                MessageBox.Show("Ви не заповнили всі поля!", "Помилка додавання");
            }
            else
            {
                var gkRow = residential_ComplexDataSet.GK.AddGKRow(textBox1.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, textBox2.Text, null);
                int classid = 0;
                var sql = string.Format("Select Class_ID from dbo.Class Where Name = N'" +
                    comboBox1.GetItemText(comboBox1.SelectedItem) + "'");
                using (var con = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
                {
                    var cmd = new SqlCommand(sql, con);
                    try
                    {
                        con.Open();
                        classid = (int)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    MessageBox.Show("Житловий комплекс було успішно додано!");
                }
                gkRow.Class_ID = classid;
                gkAdapter.Update(residential_ComplexDataSet);
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();
        }
    }
}
