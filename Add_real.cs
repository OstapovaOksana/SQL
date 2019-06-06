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
    public partial class Add_real : Form
    {
        private Residential_ComplexDataSetTableAdapters.Table_RealtorsTableAdapter TRAdapter;
        public Add_real()
        {
            InitializeComponent();
            TRAdapter = new Residential_ComplexDataSetTableAdapters.Table_RealtorsTableAdapter();
        }

        private void Add_real_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.R_Company' table. You can move, or remove it, as needed.
            this.r_CompanyTableAdapter.Fill(this.residential_ComplexDataSet.R_Company);
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.Realtors' table. You can move, or remove it, as needed.
            this.realtorsTableAdapter.Fill(this.residential_ComplexDataSet.Realtors);
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.Flats' table. You can move, or remove it, as needed.
            this.flatsTableAdapter.Fill(this.residential_ComplexDataSet.Flats);
        }

        private void add()
        {
            var trRow = residential_ComplexDataSet.Table_Realtors.AddTable_RealtorsRow(null, null,null);
            int flatid = 0;
            int rid = 0;
            int rcid = 0;
            var sql1 = string.Format("Select Flats_ID from dbo.Flats Where Number = N'" +
                comboBox1.GetItemText(comboBox1.SelectedItem) + "'");
            var sql2 = string.Format("Select Realtors_ID from dbo.Realtors Where Name = N'" +
                comboBox2.GetItemText(comboBox2.SelectedItem) + "'");
            var sql3 = string.Format("Select RC_ID from dbo.R_Company Where Name = N'" +
                comboBox3.GetItemText(comboBox3.SelectedItem) + "'");
            using (var con = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
            {
                var cmd1 = new SqlCommand(sql1, con);
                var cmd2 = new SqlCommand(sql2, con);
                var cmd3 = new SqlCommand(sql3, con);
                try
                {
                    con.Open();
                    flatid = (int)cmd1.ExecuteScalar();
                    rid = (int)cmd2.ExecuteScalar();
                    rcid = (int)cmd3.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                MessageBox.Show("Додавання завершено!");
            }
            trRow.Flats_ID = flatid;
            trRow.Realtors_ID = rid;
            trRow.RC_ID = rcid;
            TRAdapter.Update(residential_ComplexDataSet);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();
        }
    }
}
