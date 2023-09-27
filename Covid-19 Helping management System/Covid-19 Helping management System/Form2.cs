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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

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
            h.ShowDialog();
            this.Hide();
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
            string Id = idtb.Text;
            string Name = nametb.Text;
            string Contact = contacttb.Text;
            string Age = agetb.Text;
            string Address = addresstb.Text;
            string Gender = gendercb.Text;
            string Testno = testnotb.Text;
            string Condition = conditioncb.Text;


            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-6P5IDMM\SQLEXPRESS;Initial Catalog=Covid19;Integrated Security=True");
                con.Open();
                string query = "insert into Patientrecord (Id, Name, Contact, Age, Address, Gender, Testno, Condition) VALUES (' " + Id + " ' , ' " + Name + "' , ' " + Contact + " ', '" + Age + "', '" + Address + " ', , '" + Gender + " ', , '" + Testno + " ', , '" + Condition + " ')";
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
        

        

        private void backBt_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.ShowDialog();
            this.Hide();
        }

        private void updateBt_Click(object sender, EventArgs e)
        {
            


            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-6P5IDMM\SQLEXPRESS;Initial Catalog=Covid19;Integrated Security=True");
                
                string query = "update Patientrecord set Id = @id, Name = @Name, Contact = @Contact, Age = @Age, Address = @Address, Gender = @Gender, Testno = @Testno, Condition = @Condition where Id = @Id";
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                string Id = idtb.Text;
                string Name = nametb.Text;
                string Contact = contacttb.Text;
                string Age = agetb.Text;
                string Address = addresstb.Text;
                string Gender = gendercb.Text;
                string Testno = testnotb.Text;
                string Condition = conditioncb.Text;

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
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ResetControls();

                //con.Close();
            }
        }

        /*void ResetControls()
        {
            idtb.Clear();
            nametb.Clear();
            contacttb.Clear();
            ageud.Value = 0;
            addresstb.Clear();
            gendercb.SelectedItem = null;
            testnotb.Clear();
            conditioncb.SelectedItem = null;
            teststatuscb.SelectedItem = null;

            idtb.Focus();
        }*/

        private void deleteBt_Click(object sender, EventArgs e)
        {
            string Id = idtb.Text;
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=DESKTOP-6P5IDMM\SQLEXPRESS;Initial Catalog=Covid19;Integrated Security=True");
                con.Open();
                string query = "DELETE FROM Patientrecord WHERE Id=" + Id;
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
                MessageBox.Show("Delete complete!");
                con.Close();
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Searchtb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void patientDetails_Load(object sender, EventArgs e)
        {

        }
    }
}

