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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {
            home f = new home();
            f.Show();
            this.Close();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewBt_Click(object sender, EventArgs e)
        {

            //BindGridView();


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

        private void backBt_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.ShowDialog();
            this.Hide();
        }

        private void createBt_Click(object sender, EventArgs e)
        {
            string Id = idtb.Text;
            string Capacity = capacitytb.Text;
            string Address = addresstb.Text;
            string Staffcount = staffcounttb.Text;
            string Totalroom = totalroomtb.Text;
            string Recoveredpatient = recovertb.Text;


            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"");
                con.Open();
                string query = "insert into  (Id, Capacity, Address, Staffcount, Totalroom, Recoveredpatient) VALUES (' " + Id + " ' , ' " + Capacity + "' , ' " + Address + " ', '" + Staffcount + "', '" + Totalroom + " ', , '" + Recoveredpatient + " ')";
                //SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            finally
            {
                MessageBox.Show("Insert complete!");
                con.Close();
            }
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            string Id = idtb.Text;
            string Capacity = capacitytb.Text;
            string Address = addresstb.Text;
            string Staffcount = staffcounttb.Text;
            string Totalroom = totalroomtb.Text;
            string Recoveredpatient = recovertb.Text;

            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"");
                con.Open();
                string query = "UPDATE Category SET Id = @Id, Capacity = @Capacity, Address = @Address, Staffcount = @Staffcount, Totalroom = @Totalroom, Recoveredpatient = @Recoveredpatient WHERE Id = Id";
                //SqlConnection conn = new SqlConnection();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //ResetControls();
            }
            finally
            {
                MessageBox.Show("Update complete!");
                con.Close();
            }
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            string Id = idtb.Text;
            try
            {
                SqlConnection con = new SqlConnection();

                string query = "DELETE from  where Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idtb.Text);
                cmd.Parameters.AddWithValue("@capacity", capacitytb.Text);
                cmd.Parameters.AddWithValue("@address", addresstb.Text);
                cmd.Parameters.AddWithValue("@staffcount", staffcounttb.Text);
                cmd.Parameters.AddWithValue("@totalroom", totalroomtb.Text);
                cmd.Parameters.AddWithValue("@recoverpatient", recovertb.Text);


                con.Open();

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Delete SuccessFully !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string query = "select * from QUARANTINEWARDS where name like @name + '%";
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
                string query = "select * from QUARANTINEWARDS where id like @name + '%";
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

        void ResetControls()
        {
            idtb.Clear();
            capacitytb.Clear();
            addresstb.Clear();
            staffcounttb.Clear();
            totalroomtb.Clear();
            recovertb.Clear();

            idtb.Focus();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idtb.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            capacitytb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            addresstb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            staffcounttb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            totalroomtb.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            recovertb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void quit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
