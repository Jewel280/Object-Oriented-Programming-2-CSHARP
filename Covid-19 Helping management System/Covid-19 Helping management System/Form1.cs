using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid_19_Helping_management_System
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void CoronaRiskTest_Click(object sender, EventArgs e)
        { 

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void PatientRecord_Click(object sender, EventArgs e)
        {
            
        }

        private void QuarantineWards_Click(object sender, EventArgs e)
        {

        }

        private void wcorona_Click(object sender, EventArgs e)
        {

        }

        private void PatientRecord_Click_1(object sender, EventArgs e)
        {
            patientDetails pd = new patientDetails();
            pd.Show();
            //this.Close();
        }

        private void QuarantineWards_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void Symptoms_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void IsolationWards_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
