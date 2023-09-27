namespace Covid_19_Helping_management_System
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.Searchtb = new System.Windows.Forms.TextBox();
            this.recovertb = new System.Windows.Forms.TextBox();
            this.recoverpatient = new System.Windows.Forms.Label();
            this.deleteBt = new System.Windows.Forms.Button();
            this.updateBt = new System.Windows.Forms.Button();
            this.createBt = new System.Windows.Forms.Button();
            this.backBt = new System.Windows.Forms.Button();
            this.viewBt = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quit = new System.Windows.Forms.Button();
            this.totalroomtb = new System.Windows.Forms.TextBox();
            this.totalroom = new System.Windows.Forms.Label();
            this.addresstb = new System.Windows.Forms.TextBox();
            this.staffcounttb = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.staffcount = new System.Windows.Forms.Label();
            this.capacitytb = new System.Windows.Forms.TextBox();
            this.capacity = new System.Windows.Forms.Label();
            this.idtb = new System.Windows.Forms.TextBox();
            this.pid = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.recovertb);
            this.groupBox1.Controls.Add(this.recoverpatient);
            this.groupBox1.Controls.Add(this.deleteBt);
            this.groupBox1.Controls.Add(this.updateBt);
            this.groupBox1.Controls.Add(this.createBt);
            this.groupBox1.Controls.Add(this.backBt);
            this.groupBox1.Controls.Add(this.viewBt);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.quit);
            this.groupBox1.Controls.Add(this.totalroomtb);
            this.groupBox1.Controls.Add(this.totalroom);
            this.groupBox1.Controls.Add(this.addresstb);
            this.groupBox1.Controls.Add(this.staffcounttb);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Controls.Add(this.staffcount);
            this.groupBox1.Controls.Add(this.capacitytb);
            this.groupBox1.Controls.Add(this.capacity);
            this.groupBox1.Controls.Add(this.idtb);
            this.groupBox1.Controls.Add(this.pid);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(894, 642);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quarantine Wards";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchBtn);
            this.groupBox2.Controls.Add(this.Searchtb);
            this.groupBox2.Location = new System.Drawing.Point(47, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 92);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Gray;
            this.SearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchBtn.BackgroundImage")));
            this.SearchBtn.Location = new System.Drawing.Point(238, 38);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(41, 35);
            this.SearchBtn.TabIndex = 45;
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // Searchtb
            // 
            this.Searchtb.Location = new System.Drawing.Point(39, 39);
            this.Searchtb.Name = "Searchtb";
            this.Searchtb.Size = new System.Drawing.Size(173, 34);
            this.Searchtb.TabIndex = 0;
            this.Searchtb.TextChanged += new System.EventHandler(this.Searchtb_TextChanged);
            // 
            // recovertb
            // 
            this.recovertb.BackColor = System.Drawing.Color.Gray;
            this.recovertb.Location = new System.Drawing.Point(571, 488);
            this.recovertb.Name = "recovertb";
            this.recovertb.Size = new System.Drawing.Size(100, 34);
            this.recovertb.TabIndex = 5;
            // 
            // recoverpatient
            // 
            this.recoverpatient.AutoSize = true;
            this.recoverpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recoverpatient.Location = new System.Drawing.Point(329, 498);
            this.recoverpatient.Name = "recoverpatient";
            this.recoverpatient.Size = new System.Drawing.Size(210, 20);
            this.recoverpatient.TabIndex = 5;
            this.recoverpatient.Text = "RECOVERED_PATIENT";
            // 
            // deleteBt
            // 
            this.deleteBt.BackColor = System.Drawing.Color.Gray;
            this.deleteBt.Location = new System.Drawing.Point(725, 50);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(105, 40);
            this.deleteBt.TabIndex = 72;
            this.deleteBt.Text = "Delete";
            this.deleteBt.UseVisualStyleBackColor = false;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // updateBt
            // 
            this.updateBt.BackColor = System.Drawing.Color.Gray;
            this.updateBt.Location = new System.Drawing.Point(591, 50);
            this.updateBt.Name = "updateBt";
            this.updateBt.Size = new System.Drawing.Size(105, 40);
            this.updateBt.TabIndex = 71;
            this.updateBt.Text = "Update";
            this.updateBt.UseVisualStyleBackColor = false;
            this.updateBt.Click += new System.EventHandler(this.updateBt_Click);
            // 
            // createBt
            // 
            this.createBt.BackColor = System.Drawing.Color.Gray;
            this.createBt.Location = new System.Drawing.Point(394, 50);
            this.createBt.Name = "createBt";
            this.createBt.Size = new System.Drawing.Size(166, 40);
            this.createBt.TabIndex = 70;
            this.createBt.Text = "Create New";
            this.createBt.UseVisualStyleBackColor = false;
            this.createBt.Click += new System.EventHandler(this.createBt_Click);
            // 
            // backBt
            // 
            this.backBt.BackColor = System.Drawing.Color.Gray;
            this.backBt.Location = new System.Drawing.Point(709, 456);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(105, 40);
            this.backBt.TabIndex = 69;
            this.backBt.Text = "Back";
            this.backBt.UseVisualStyleBackColor = false;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // viewBt
            // 
            this.viewBt.BackColor = System.Drawing.Color.Gray;
            this.viewBt.Location = new System.Drawing.Point(709, 402);
            this.viewBt.Name = "viewBt";
            this.viewBt.Size = new System.Drawing.Size(105, 40);
            this.viewBt.TabIndex = 68;
            this.viewBt.Text = "View";
            this.viewBt.UseVisualStyleBackColor = false;
            this.viewBt.Click += new System.EventHandler(this.viewBt_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(765, 203);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.Gray;
            this.quit.Location = new System.Drawing.Point(709, 511);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(105, 40);
            this.quit.TabIndex = 66;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.quit_Click_1);
            // 
            // totalroomtb
            // 
            this.totalroomtb.BackColor = System.Drawing.Color.Gray;
            this.totalroomtb.Location = new System.Drawing.Point(201, 486);
            this.totalroomtb.Name = "totalroomtb";
            this.totalroomtb.Size = new System.Drawing.Size(100, 34);
            this.totalroomtb.TabIndex = 4;
            // 
            // totalroom
            // 
            this.totalroom.AutoSize = true;
            this.totalroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalroom.Location = new System.Drawing.Point(55, 498);
            this.totalroom.Name = "totalroom";
            this.totalroom.Size = new System.Drawing.Size(134, 20);
            this.totalroom.TabIndex = 4;
            this.totalroom.Text = "TOTAL_ROOM";
            // 
            // addresstb
            // 
            this.addresstb.BackColor = System.Drawing.Color.Gray;
            this.addresstb.Location = new System.Drawing.Point(201, 438);
            this.addresstb.Name = "addresstb";
            this.addresstb.Size = new System.Drawing.Size(100, 34);
            this.addresstb.TabIndex = 2;
            // 
            // staffcounttb
            // 
            this.staffcounttb.BackColor = System.Drawing.Color.Gray;
            this.staffcounttb.Location = new System.Drawing.Point(518, 438);
            this.staffcounttb.Name = "staffcounttb";
            this.staffcounttb.Size = new System.Drawing.Size(91, 34);
            this.staffcounttb.TabIndex = 3;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(97, 445);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(98, 20);
            this.address.TabIndex = 2;
            this.address.Text = "ADDRESS";
            // 
            // staffcount
            // 
            this.staffcount.AutoSize = true;
            this.staffcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffcount.Location = new System.Drawing.Point(348, 445);
            this.staffcount.Name = "staffcount";
            this.staffcount.Size = new System.Drawing.Size(140, 20);
            this.staffcount.TabIndex = 3;
            this.staffcount.Text = "STAFF_COUNT";
            // 
            // capacitytb
            // 
            this.capacitytb.BackColor = System.Drawing.Color.Gray;
            this.capacitytb.Location = new System.Drawing.Point(514, 390);
            this.capacitytb.Name = "capacitytb";
            this.capacitytb.Size = new System.Drawing.Size(100, 34);
            this.capacitytb.TabIndex = 1;
            // 
            // capacity
            // 
            this.capacity.AutoSize = true;
            this.capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity.Location = new System.Drawing.Point(390, 396);
            this.capacity.Name = "capacity";
            this.capacity.Size = new System.Drawing.Size(98, 20);
            this.capacity.TabIndex = 1;
            this.capacity.Text = "CAPACITY";
            // 
            // idtb
            // 
            this.idtb.BackColor = System.Drawing.Color.Gray;
            this.idtb.Location = new System.Drawing.Point(201, 394);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(100, 34);
            this.idtb.TabIndex = 0;
            // 
            // pid
            // 
            this.pid.AutoSize = true;
            this.pid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pid.Location = new System.Drawing.Point(161, 398);
            this.pid.Name = "pid";
            this.pid.Size = new System.Drawing.Size(28, 20);
            this.pid.TabIndex = 0;
            this.pid.Text = "ID";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(949, 690);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.Button updateBt;
        private System.Windows.Forms.Button createBt;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Button viewBt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.TextBox totalroomtb;
        private System.Windows.Forms.Label totalroom;
        private System.Windows.Forms.TextBox addresstb;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox capacitytb;
        private System.Windows.Forms.Label capacity;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.Label pid;
        private System.Windows.Forms.TextBox staffcounttb;
        private System.Windows.Forms.Label staffcount;
        private System.Windows.Forms.TextBox recovertb;
        private System.Windows.Forms.Label recoverpatient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox Searchtb;
    }
}