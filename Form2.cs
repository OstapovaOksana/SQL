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
    public partial class Form2 : Form
    {
        SqlConnection Connection = new SqlConnection("Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True");
        DataTable dt_gk;
        DataTable dt_flat;
        DataTable dt_class;
        DataTable dt_ow;
        DataTable dt_r;
        DataTable dt_comp;
        DataTable dt_tr;
        DataTable dt_ts;
        DataTable dt_s;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.Owners' table. You can move, or remove it, as needed.
            this.ownersTableAdapter.Fill(this.residential_ComplexDataSet.Owners);
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.R_Company' table. You can move, or remove it, as needed.
            this.r_CompanyTableAdapter.Fill(this.residential_ComplexDataSet.R_Company);
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.Realtors' table. You can move, or remove it, as needed.
            this.realtorsTableAdapter.Fill(this.residential_ComplexDataSet.Realtors);
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.Table_Realtors' table. You can move, or remove it, as needed.
            this.table_RealtorsTableAdapter.Fill(this.residential_ComplexDataSet.Table_Realtors);
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.Status' table. You can move, or remove it, as needed.
            this.statusTableAdapter.Fill(this.residential_ComplexDataSet.Status);
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.Table_Status' table. You can move, or remove it, as needed.
            this.table_StatusTableAdapter.Fill(this.residential_ComplexDataSet.Table_Status);
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.Flats' table. You can move, or remove it, as needed.
            this.flatsTableAdapter.Fill(this.residential_ComplexDataSet.Flats);
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.Class' table. You can move, or remove it, as needed.
            this.classTableAdapter.Fill(this.residential_ComplexDataSet.Class);
            // TODO: This line of code loads data into the 'residential_ComplexDataSet.GK' table. You can move, or remove it, as needed.
            this.gKTableAdapter.Fill(this.residential_ComplexDataSet.GK);

        }


        private void add_gk()
        {
            this.classTableAdapter.Fill(this.residential_ComplexDataSet.Class);
            try
            {
                using (Add_GK gkForm = new Add_GK())
                {
                    if (gkForm.ShowDialog() == DialogResult.OK)
                    {
                        this.gKTableAdapter.Fill(this.residential_ComplexDataSet.GK);
                    }
                }
            }
            catch { MessageBox.Show("smth wrong("); }
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
            {
                using (SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM dbo.GK", conn))
                {
                    dt_gk = new DataTable();
                    ad.Fill(dt_gk);
                    dgv_GK.DataSource = dt_gk;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_gk();
        }

        private void del_gk()
        {
            if (dgv_GK.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Ви впевнені у видаленні?", "Видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int gk_id = Convert.ToInt32(dgv_GK.CurrentRow.Cells[1].Value);
                    string query1 = @"SELECT COUNT(Flats_ID) FROM dbo.Flats WHERE GK_ID=@GK_ID";

                    SqlCommand flat = new SqlCommand();
                    flat.Connection = Connection;
                    flat.CommandType = CommandType.Text;
                    flat.CommandText = query1;

                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@GK_ID";
                    param1.SqlDbType = SqlDbType.Int;
                    param1.IsNullable = false;
                    param1.Value = gk_id;

                    flat.Parameters.Add(param1);
                    flat.Connection.Open();
                    var count1 = flat.ExecuteScalar();
                    flat.Connection.Close();

                    if ((int)count1 == 0)
                    {
                        string sql = "delete from dbo.GK where GK_ID = @GK_ID";

                        SqlCommand delete = new SqlCommand();
                        delete.Connection = Connection;
                        delete.CommandType = CommandType.Text;
                        delete.CommandText = sql;

                        SqlParameter Param = new SqlParameter();
                        Param.ParameterName = "@GK_ID";
                        Param.SqlDbType = SqlDbType.Int;
                        Param.IsNullable = false;
                        Param.Value = gk_id;

                        delete.Parameters.Add(Param);
                        delete.Connection.Open();
                        delete.ExecuteNonQuery();
                        delete.Connection.Close();

                        residential_ComplexDataSet.GetChanges();

                        using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
                        {
                            using (SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM dbo.GK", conn))
                            {
                                dt_gk = new DataTable();
                                ad.Fill(dt_gk);
                                dgv_GK.DataSource = dt_gk;
                            }
                        }
                        MessageBox.Show("Житловий комплекс було видалено!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if ((int)count1 != 0)
                    {
                        MessageBox.Show("До цього житлового комплексу прив'язана квартира", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Ви не вибрали рядок для видалення!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            del_gk();
        }

        private void add_flat()
        {
            this.gKTableAdapter.Fill(this.residential_ComplexDataSet.GK);
            this.ownersTableAdapter.Fill(this.residential_ComplexDataSet.Owners);
            try
            {
                using (Add_flat flatForm = new Add_flat())
                {
                    if (flatForm.ShowDialog() == DialogResult.OK)
                    {
                        this.flatsTableAdapter.Fill(this.residential_ComplexDataSet.Flats);
                    }
                }
            }
            catch { MessageBox.Show("smth wrong("); }
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
            {
                using (SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM dbo.Flats", conn))
                {
                    dt_flat = new DataTable();
                    ad.Fill(dt_flat);
                    dgv_flat.DataSource = dt_flat;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            add_flat();
        }

        private void del_flat()
        {
            if (dgv_flat.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Ви впевнені у видаленні?", "Видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int flat_id = Convert.ToInt32(dgv_flat.CurrentRow.Cells[1].Value);
                    string query1 = @"SELECT COUNT(TSTATUS_ID) FROM dbo.Table_Status WHERE Flats_ID=@Flats_ID";
                    string query2 = @"SELECT COUNT(TR_ID) FROM dbo.Table_Realtors WHERE Flats_ID=@Flats_ID";

                    SqlCommand ts = new SqlCommand();
                    ts.Connection = Connection;
                    ts.CommandType = CommandType.Text;
                    ts.CommandText = query1;

                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@Flats_ID";
                    param1.SqlDbType = SqlDbType.Int;
                    param1.IsNullable = false;
                    param1.Value = flat_id;

                    ts.Parameters.Add(param1);
                    ts.Connection.Open();
                    var count1 = ts.ExecuteScalar();
                    ts.Connection.Close();

                    SqlCommand tr = new SqlCommand();
                    tr.Connection = Connection;
                    tr.CommandType = CommandType.Text;
                    tr.CommandText = query2;

                    SqlParameter param2 = new SqlParameter();
                    param2.ParameterName = "@Flats_ID";
                    param2.SqlDbType = SqlDbType.Int;
                    param2.IsNullable = false;
                    param2.Value = flat_id;

                    tr.Parameters.Add(param2);
                    tr.Connection.Open();
                    var count2 = tr.ExecuteScalar();
                    tr.Connection.Close();

                    if ((int)count1 == 0 && (int)count2 == 0)
                    {
                        string sql = "delete from dbo.Flats where Flats_ID = @Flats_ID";

                        SqlCommand delete = new SqlCommand();
                        delete.Connection = Connection;
                        delete.CommandType = CommandType.Text;
                        delete.CommandText = sql;

                        SqlParameter Param = new SqlParameter();
                        Param.ParameterName = "@Flats_ID";
                        Param.SqlDbType = SqlDbType.Int;
                        Param.IsNullable = false;
                        Param.Value = flat_id;

                        delete.Parameters.Add(Param);
                        delete.Connection.Open();
                        delete.ExecuteNonQuery();
                        delete.Connection.Close();

                        residential_ComplexDataSet.GetChanges();

                        using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
                        {
                            using (SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM dbo.Flats", conn))
                            {
                                dt_flat = new DataTable();
                                ad.Fill(dt_flat);
                                dgv_flat.DataSource = dt_flat;
                            }
                        }
                        MessageBox.Show("Квартиру було видалено!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if ((int)count1 != 0 || (int)count2 != 0)
                    {
                        MessageBox.Show("Ця квартира використовується в іншій таблиці", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            else
            {
                MessageBox.Show("Ви не вибрали рядок для видалення!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            del_flat();
        }

        private void add_ts()
        {
            this.flatsTableAdapter.Fill(this.residential_ComplexDataSet.Flats);
            this.statusTableAdapter.Fill(this.residential_ComplexDataSet.Status);
            try
            {
                using (Add_status stForm = new Add_status())
                {
                    if (stForm.ShowDialog() == DialogResult.OK)
                    {
                        this.table_StatusTableAdapter.Fill(this.residential_ComplexDataSet.Table_Status);
                    }
                }
            }
            catch { MessageBox.Show("smth wrong("); }
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
            {
                using (SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM dbo.Table_Status", conn))
                {
                    dt_ts = new DataTable();
                    ad.Fill(dt_ts);
                    dgv_status.DataSource = dt_ts;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            add_ts();
        }

        private void del_ts()
        {
            if (dgv_status.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Ви впевнені у видаленні?", "Видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int ts_id = Convert.ToInt32(dgv_status.CurrentRow.Cells[1].Value);

                    string sql = "delete from dbo.Table_Status where TSTATUS_ID = @TSTATUS_ID";

                    SqlCommand delete = new SqlCommand();
                    delete.Connection = Connection;
                    delete.CommandType = CommandType.Text;
                    delete.CommandText = sql;

                    SqlParameter Param = new SqlParameter();
                    Param.ParameterName = "@TSTATUS_ID";
                    Param.SqlDbType = SqlDbType.Int;
                    Param.IsNullable = false;
                    Param.Value = ts_id;

                    delete.Parameters.Add(Param);
                    delete.Connection.Open();
                    delete.ExecuteNonQuery();
                    delete.Connection.Close();

                    residential_ComplexDataSet.GetChanges();

                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
                    {
                        using (SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM dbo.Table_Status", conn))
                        {
                            dt_ts = new DataTable();
                            ad.Fill(dt_ts);
                            dgv_status.DataSource = dt_ts;
                        }
                    }

                    MessageBox.Show("Видалення успішне!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Ви не вибрали рядок для видалення!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            del_ts();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Status st = new Status();
            this.Hide();
            st.ShowDialog();
            this.Show();
        }

        private void add_real()
        {
            this.flatsTableAdapter.Fill(this.residential_ComplexDataSet.Flats);
            this.realtorsTableAdapter.Fill(this.residential_ComplexDataSet.Realtors);
            this.r_CompanyTableAdapter.Fill(this.residential_ComplexDataSet.R_Company);
            try
            {
                using (Add_real realForm = new Add_real())
                {
                    if (realForm.ShowDialog() == DialogResult.OK)
                    {
                        this.table_RealtorsTableAdapter.Fill(this.residential_ComplexDataSet.Table_Realtors);
                    }
                }
            }
            catch { MessageBox.Show("smth wrong("); }
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
            {
                using (SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM dbo.Table_Realtors", conn))
                {
                    dt_tr = new DataTable();
                    ad.Fill(dt_tr);
                    dgv_realtor.DataSource = dt_tr;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            add_real();
        }

        private void del_real()
        {
            if (dgv_realtor.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Ви впевнені у видаленні?", "Видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int tr_id = Convert.ToInt32(dgv_realtor.CurrentRow.Cells[1].Value);

                    string sql = "delete from dbo.Table_Realtors where TR_ID = @TR_ID";

                    SqlCommand delete = new SqlCommand();
                    delete.Connection = Connection;
                    delete.CommandType = CommandType.Text;
                    delete.CommandText = sql;

                    SqlParameter Param = new SqlParameter();
                    Param.ParameterName = "@TR_ID";
                    Param.SqlDbType = SqlDbType.Int;
                    Param.IsNullable = false;
                    Param.Value = tr_id;

                    delete.Parameters.Add(Param);
                    delete.Connection.Open();
                    delete.ExecuteNonQuery();
                    delete.Connection.Close();

                    residential_ComplexDataSet.GetChanges();

                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
                    {
                        using (SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM dbo.Table_Realtors", conn))
                        {
                            dt_tr = new DataTable();
                            ad.Fill(dt_tr);
                            dgv_realtor.DataSource = dt_tr;
                        }
                    }

                    MessageBox.Show("Видалення успішне!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Ви не вибрали рядок для видалення!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            del_real();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Realtors r = new Realtors();
            this.Hide();
            r.ShowDialog();
            this.Show();
        }

        private void add_dir()
        {
            try
            {
                using (Add_dir dirForm = new Add_dir())
                {
                    if (dirForm.ShowDialog() == DialogResult.OK)
                    {
                        this.ownersTableAdapter.Fill(this.residential_ComplexDataSet.Owners);
                    }
                }
            }
            catch { MessageBox.Show("smth wrong("); }
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
            {
                using (SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM dbo.Owners", conn))
                {
                    dt_ow = new DataTable();
                    ad.Fill(dt_ow);
                    dgv_dir.DataSource = dt_ow;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            add_dir();
        }

        private void del_dir()
        {
            if (dgv_dir.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Ви впевнені у видаленні?", "Видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int ow_id = Convert.ToInt32(dgv_dir.CurrentRow.Cells[1].Value);

                    string sql = "delete from dbo.Owners where Owners_ID = @Owners_ID";

                    SqlCommand delete = new SqlCommand();
                    delete.Connection = Connection;
                    delete.CommandType = CommandType.Text;
                    delete.CommandText = sql;

                    SqlParameter Param = new SqlParameter();
                    Param.ParameterName = "@Owners_ID";
                    Param.SqlDbType = SqlDbType.Int;
                    Param.IsNullable = false;
                    Param.Value = ow_id;

                    delete.Parameters.Add(Param);
                    delete.Connection.Open();
                    delete.ExecuteNonQuery();
                    delete.Connection.Close();

                    residential_ComplexDataSet.GetChanges();

                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UM6VBB8;Initial Catalog=Residential_Complex;Integrated Security=True"))
                    {
                        using (SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM dbo.Owners", conn))
                        {
                            dt_ow = new DataTable();
                            ad.Fill(dt_ow);
                            dgv_dir.DataSource = dt_ow;
                        }
                    }

                    MessageBox.Show("Видалення успішне!", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Ви не вибрали рядок для видалення!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            del_dir();
        }
    }
}
