using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_19_Helping_management_System
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Close();
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Close();
        }

        private void viewBt_Click(object sender, EventArgs e)
        {

            BindGridView();

            /*SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"");
                con.Open();

                string query = "select * from ";
                SqlCommand cmd = new SqlCommand(query, con);
                DataSet ds = new DataSet();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(ds);
                DataTable dt = ds.Tables[0];
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }*/
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idtb.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            capacitytb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            addresstb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            staffcounttb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            totalroomtb.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            recovertb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            availablebedstb.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void createBt_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-6P5IDMM\SQLEXPRESS;Initial Catalog=oop2;Integrated Security=True");
                con.Open();
                string query2 = "select * from ISOLATIONWARDS where Id = @id";
                SqlConnection conn = new SqlConnection();
                SqlCommand cmd2 = new SqlCommand(query2, conn);
                cmd2.Parameters.AddWithValue("@id", idtb.Text);
                conn.Open();
                SqlDataReader dr = cmd2.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show(idtb.Text + " ID already Exists !", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                else
                {
                    con.Close();

                    string query = "insert into ISOLATIONWARDS values(@id,@capacity,@address,@staffcount,@totalroom,@recoverpatient, @availablebeds)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", idtb.Text);
                    cmd.Parameters.AddWithValue("@capacity", capacitytb.Text);
                    cmd.Parameters.AddWithValue("@address", addresstb.Text);
                    cmd.Parameters.AddWithValue("@staffcount", staffcounttb.Text);
                    cmd.Parameters.AddWithValue("@totalroom", totalroomtb.Text);
                    cmd.Parameters.AddWithValue("@recoverpatient", recovertb.Text);
                    cmd.Parameters.AddWithValue("@availablebeds", availablebedstb.Text);



                    con.Open();

                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Inserted SuccessFully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BindGridView();
                    }
                    else
                    {
                        MessageBox.Show("Please check data again");
                        //con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                ResetControls();
            }
            finally
            {
                con.Close();
            }
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();

                string query = "update ISOLATIONWARDS set Id = @id, capacity = @capacity, address = @address, staffcount = @staffcount, totalroom = @totalroom, recoverpatient = @recoverpatient, availablebeds = @availablebeds where Id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idtb.Text);
                cmd.Parameters.AddWithValue("@capacity", capacitytb.Text);
                cmd.Parameters.AddWithValue("@address", addresstb.Text);
                cmd.Parameters.AddWithValue("@staffcount", staffcounttb.Text);
                cmd.Parameters.AddWithValue("@totalroom", totalroomtb.Text);
                cmd.Parameters.AddWithValue("@recoverpatient", recovertb.Text);
                cmd.Parameters.AddWithValue("@availablebeds", availablebedstb.Text);


                con.Open();

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Update SuccessFully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGridView();
                }
                else
                {
                    MessageBox.Show("Please check data !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResetControls();

                //con.Close();
            }
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();

                string query = "delte from ISOLATIONWARDS where Id = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idtb.Text);
                cmd.Parameters.AddWithValue("@capacity", capacitytb.Text);
                cmd.Parameters.AddWithValue("@address", addresstb.Text);
                cmd.Parameters.AddWithValue("@staffcount", staffcounttb.Text);
                cmd.Parameters.AddWithValue("@totalroom", totalroomtb.Text);
                cmd.Parameters.AddWithValue("@recoverpatient", recovertb.Text);
                cmd.Parameters.AddWithValue("@availablebeds", availablebedstb.Text);


                con.Open();

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Delete SuccessFully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BindGridView();
                }
                else
                {
                    MessageBox.Show("Please check data !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //con.Close();
                ResetControls();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                string query = "select * from ISOLATIONWARDS where name like @name + '%";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@name", Searchtb.Text.Trim());
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                    dataGridView1.DataSource = data;
                }
                else
                {
                    MessageBox.Show("No data found");
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Searchtb_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                string query = "select * from ISOLATIONWARDS where id like @name + '%";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@name", Searchtb.Text.Trim());
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                    dataGridView1.DataSource = data;
                }
                else
                {
                    MessageBox.Show("No data found! ");
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection();
            string query = "Select * from ISOLATIONWARDS ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }


        void ResetControls()
        {
            idtb.Clear();
            capacitytb.Clear();
            addresstb.Clear();
            staffcounttb.Clear();
            totalroomtb.Clear();
            recovertb.Clear();
            availablebedstb.Clear();

            idtb.Focus();
        }

        private void quit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void availablebedstb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
