namespace Covid_19_Helping_management_System
{
    partial class patientDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // patientDetails
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "patientDetails";
            this.Load += new System.EventHandler(this.patientDetails_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.TextBox testnotb;
        private System.Windows.Forms.Label condition;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label testno;
        private System.Windows.Forms.TextBox addresstb;
        private System.Windows.Forms.TextBox contacttb;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label contect;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.Label pname;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.Label pid;
        private System.Windows.Forms.ComboBox conditioncb;
        private System.Windows.Forms.ComboBox gendercb;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.Button updateBt;
        private System.Windows.Forms.Button createBt;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Button viewBt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox Searchtb;
        private System.Windows.Forms.TextBox agetb;
    }
}