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
    public partial class Realtors : Form
    {
        SqlConnection Connection = new SqlConnection("Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True");
        DataTable dt_r;
        DataTable dt_comp;

        public Realtors()
        {
            InitializeComponent();
        }

        private void Realtors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.Realtors' table. You can move, or remove it, as needed.
            this.realtorsTableAdapter.Fill(this.residential_ComplexDataSet.Realtors);
        }

        private void add_r()
        {
            try
            {
                using (Add_r rForm = new Add_r())
                {
                    if (rForm.ShowDialog() == DialogResult.OK)
                    {
                        this.realtorsTableAdapter.Fill(this.residential_ComplexDataSet.Realtors);
                    }
                }
            }
            catch { MessageBox.Show("smth wrong("); }
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
            {
                using (SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM dbo.Realtors", conn))
                {
                    dt_r = new DataTable();
                    ad.Fill(dt_r);
                    dgv_realtor.DataSource = dt_r;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            add_r();
        }

        private void del_r()
        {
            if (dgv_realtor.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Ви впевнені у видаленні?", "Видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int r_id = Convert.ToInt32(dgv_realtor.CurrentRow.Cells[1].Value);
                    string query1 = @"SELECT COUNT(TR_ID) FROM dbo.Table_Realtors WHERE Realtors_ID=@Realtors_ID";

                    SqlCommand com = new SqlCommand();
                    com.Connection = Connection;
                    com.CommandType = CommandType.Text;
                    com.CommandText = query1;

                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@Realtors_ID";
                    param1.SqlDbType = SqlDbType.Int;
                    param1.IsNullable = false;
                    param1.Value = r_id;

                    com.Parameters.Add(param1);
                    com.Connection.Open();
                    var count1 = com.ExecuteScalar();
                    com.Connection.Close();

                    if ((int)count1 == 0)
                    {
                        string sql = "delete from dbo.Realtors where Realtors_ID = @Realtors_ID";

                        SqlCommand delete = new SqlCommand();
                        delete.Connection = Connection;
                        delete.CommandType = CommandType.Text;
                        delete.CommandText = sql;

                        SqlParameter Param = new SqlParameter();
                        Param.ParameterName = "@Realtors_ID";
                        Param.SqlDbType = SqlDbType.Int;
                        Param.IsNullable = false;
                        Param.Value = r_id;

                        delete.Parameters.Add(Param);
                        delete.Connection.Open();
                        delete.ExecuteNonQuery();
                        delete.Connection.Close();

                        residential_ComplexDataSet.GetChanges();

                        using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
                        {
                            using (SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM dbo.Realtors", conn))
                            {
                                dt_r = new DataTable();
                                ad.Fill(dt_r);
                                dgv_realtor.DataSource = dt_r;
                            }
                        }
                        MessageBox.Show("Рієлтора було видалено!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if ((int)count1 != 0)
                    {
                        MessageBox.Show("Цей рієлтор задіяний в іншій таблиці!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            del_r();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RComp rc = new RComp();
            this.Hide();
            rc.ShowDialog();
            this.Show();
        }
    }
}
