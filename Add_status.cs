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
    public partial class Add_status : Form
    {
        private Residential_ComplexDataSetTableAdapters.Table_StatusTableAdapter TSAdapter;
        public Add_status()
        {
            InitializeComponent();
            TSAdapter = new Residential_ComplexDataSetTableAdapters.Table_StatusTableAdapter();
        }

        private void Add_status_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.residential_ComplexDataSet.Status);
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.Flats' table. You can move, or remove it, as needed.
            this.flatsTableAdapter.Fill(this.residential_ComplexDataSet.Flats);

        }

        private void add()
        {
            var tsRow = residential_ComplexDataSet.Table_Status.AddTable_StatusRow(null, null, dateTimePicker1.Value, dateTimePicker2.Value);
            int flatid = 0;
            int statusid = 0;
            var sql1 = string.Format("Select Flats_ID from dbo.Flats Where Number = N'" +
                comboBox1.GetItemText(comboBox1.SelectedItem) + "'");
            var sql2 = string.Format("Select Status_ID from dbo.Status Where Name = N'" +
                comboBox2.GetItemText(comboBox2.SelectedItem) + "'");
            using (var con = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
            {
                var cmd1 = new SqlCommand(sql1, con);
                var cmd2 = new SqlCommand(sql2, con);
                try
                {
                    con.Open();
                    flatid = (int)cmd1.ExecuteScalar();
                    statusid = (int)cmd2.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                MessageBox.Show("Додавання завершено!");
            }
            tsRow.Flats_ID = flatid;
            tsRow.Status_ID = statusid;
            TSAdapter.Update(residential_ComplexDataSet);
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();
        }
    }
}
