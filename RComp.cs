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
    public partial class RComp : Form
    {
        SqlConnection Connection = new SqlConnection("Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True");
        DataTable dt_comp;

        public RComp()
        {
            InitializeComponent();
        }

        private void RComp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.R_Company' table. You can move, or remove it, as needed.
            this.r_CompanyTableAdapter.Fill(this.residential_ComplexDataSet.R_Company);
        }

        private void add_rc()
        {
            try
            {
                using (Add_comp rcForm = new Add_comp())
                {
                    if (rcForm.ShowDialog() == DialogResult.OK)
                    {
                        this.r_CompanyTableAdapter.Fill(this.residential_ComplexDataSet.R_Company);
                    }
                }
            }
            catch { MessageBox.Show("smth wrong("); }
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
            {
                using (SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM dbo.R_Company", conn))
                {
                    dt_comp = new DataTable();
                    ad.Fill(dt_comp);
                    dgv_comp.DataSource = dt_comp;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            add_rc();
        }

        private void del_rc()
        {
            if (dgv_comp.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Ви впевнені у видаленні?", "Видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int rc_id = Convert.ToInt32(dgv_comp.CurrentRow.Cells[1].Value);
                    string query1 = @"SELECT COUNT(TR_ID) FROM dbo.Table_Realtors WHERE RC_ID=@RC_ID";

                    SqlCommand command = new SqlCommand();
                    command.Connection = Connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = query1;

                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@RC_ID";
                    param1.SqlDbType = SqlDbType.Int;
                    param1.IsNullable = false;
                    param1.Value = rc_id;

                    command.Parameters.Add(param1);
                    command.Connection.Open();
                    var count1 = command.ExecuteScalar();
                    command.Connection.Close();

                    if ((int)count1 == 0)
                    {
                        string sql = "delete from dbo.R_Company where RC_ID = @RC_ID";

                        SqlCommand delete = new SqlCommand();
                        delete.Connection = Connection;
                        delete.CommandType = CommandType.Text;
                        delete.CommandText = sql;

                        SqlParameter Param = new SqlParameter();
                        Param.ParameterName = "@RC_ID";
                        Param.SqlDbType = SqlDbType.Int;
                        Param.IsNullable = false;
                        Param.Value = rc_id;

                        delete.Parameters.Add(Param);
                        delete.Connection.Open();
                        delete.ExecuteNonQuery();
                        delete.Connection.Close();

                        residential_ComplexDataSet.GetChanges();

                        using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
                        {
                            using (SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM dbo.R_Company", conn))
                            {
                                dt_comp = new DataTable();
                                ad.Fill(dt_comp);
                                dgv_comp.DataSource = dt_comp;
                            }
                        }
                        MessageBox.Show("Агентство було видалено!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if ((int)count1 != 0)
                    {
                        MessageBox.Show("Є рієлтор з цього агентства!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Ви не вибрали рядок для видалення!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            del_rc();
        }
    }
}
