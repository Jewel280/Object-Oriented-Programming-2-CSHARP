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
    public partial class patientDetails : Form
    {
        public patientDetails()
        {
            InitializeComponent();
        }

        private void patient_Load(object sender, EventArgs e)
        {

        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pSubmit_Click(object sender, EventArgs e)
        {

        }

        private void back_Click_1(object sender, EventArgs e)
        {
            home h = new home();
            h.Show();
            this.Close();
        }

        private void quit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void addnew_Click(object sender, EventArgs e)
        {

        }

        private void edit_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void gender_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void cnic_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void condition_Click(object sender, EventArgs e)
        {

        }

        private void age_Click(object sender, EventArgs e)
        {

        }

        private void testno_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void teststatus_Click(object sender, EventArgs e)
        {

        }

        private void paddress_Click(object sender, EventArgs e)
        {

        }

        private void contect_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pname_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pid_Click(object sender, EventArgs e)
        {

        }

        private void createBt_Click(object sender, EventArgs e)
        {
            /*string id = idtb.Text;
            string name = nametb.Text;
            int contact = contacttb.TabIndex;
            int age = ageud.TabIndex;
            string address = addresstb.Text;
            string gender = gendercb.Text;
            
            int testno = testnotb.TabIndex;
            string condition = conditioncb.Text;
            string teststatus = teststatuscb.Text;*/


            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"^^^^^^^^^");
                con.Open();
                string query2 = "select * from  ^^^^^^  where Id = @id";
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

                    string query = "insert into ^^^^^^^  values(@id,@name,@contact,@age,@address,@gender,@testno,@condition,@teststatus)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", idtb.Text);
                    cmd.Parameters.AddWithValue("@name", nametb.Text);
                    cmd.Parameters.AddWithValue("@contact", contacttb.Text);
                    cmd.Parameters.AddWithValue("@age", ageud.Value);
                    cmd.Parameters.AddWithValue("@address", addresstb.Text);
                    cmd.Parameters.AddWithValue("@gender", gendercb.SelectedItem);
                    cmd.Parameters.AddWithValue("@testno", testnotb.Text);
                    cmd.Parameters.AddWithValue("@condition", conditioncb.SelectedItem);
                    cmd.Parameters.AddWithValue("@teststatus", teststatuscb.SelectedItem);


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

                //string query = "insert into PatientRecord(Id, Name, Contact, Age, Address, Gender, Test_NO, Condition, Test_Status) VALUES (' " + id + "', ' " + name + "', ' " + contact + "', ' " + age + "', ' " + address + "', ' " + gender + "', '" + teststatus + "', '" + condition + "', '" + teststatus + "')";
                //SqlCommand cmd = new SqlCommand(query, con);
                //cmd.ExecuteNonQuery();
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
        void BindGridView()
        {
            SqlConnection con = new SqlConnection();
            string query = "Select * from ^^^^^^^^^^^^^ ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
        }

        private void viewBt_Click(object sender, EventArgs e)
        {
            BindGridView();

            //SqlConnection con = null;

            /*con = new SqlConnection(@"  ");
            con.Open();

            string query = "select * from     ";
            SqlCommand cmd = new SqlCommand(query, con);
            DataSet ds = new DataSet();
            SqlDataAdapter ada = new SqlDataAdapter(cmd);
            ada.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();*/
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.ShowDialog();
            this.Hide();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idtb.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nametb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            contacttb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            agetb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            addresstb.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            gendercb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            testnotb.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            conditioncb.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        

        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            
        }

        void ResetControls()
        {
            idtb.Clear();
            nametb.Clear();
            contacttb.Clear();
            agetb.Clear();
            addresstb.Clear();
            gendercb.SelectedItem = null;
            testnotb.Clear();
            conditioncb.SelectedItem = null;

            idtb.Focus();
        }

        private void deleteBt_Click(object sender, EventArgs e)
        {
            
                SqlConnection conn = new SqlConnection(@"");
                conn.Open();
                string query = "delte from  ^^^^^^^ where Id ="+idtb.Text;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                cmd.Parameters.AddWithValue("@id", idtb.Text);
                cmd.Parameters.AddWithValue("@name", nametb.Text);
                cmd.Parameters.AddWithValue("@contact", contacttb.Text);
                cmd.Parameters.AddWithValue("@age", agetb.Text);
                cmd.Parameters.AddWithValue("@address", addresstb.Text);
                cmd.Parameters.AddWithValue("@gender", gendercb.SelectedItem);
                cmd.Parameters.AddWithValue("@testno", testnotb.Text);
                cmd.Parameters.AddWithValue("@condition", conditioncb.SelectedItem);
 


             
            }
            
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            string query = "select * from ^^^^^^^^^^ where id like @name + '%";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void Searchtb_TextChanged(object sender, EventArgs e)
        {
            
                
                
                
                
        }
    }
}
