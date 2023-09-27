namespace Covid_19_Helping_management_System
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Covid = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Symptoms = new System.Windows.Forms.Button();
            this.IsolationWards = new System.Windows.Forms.Button();
            this.QuarantineWards = new System.Windows.Forms.Button();
            this.PatientRecord = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.Covid);
            this.groupBox1.Controls.Add(this.Exit);
            this.groupBox1.Controls.Add(this.Symptoms);
            this.groupBox1.Controls.Add(this.IsolationWards);
            this.groupBox1.Controls.Add(this.QuarantineWards);
            this.groupBox1.Controls.Add(this.PatientRecord);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 620);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Covid-19_Home";
            // 
            // Covid
            // 
            this.Covid.BackColor = System.Drawing.Color.DimGray;
            this.Covid.Font = new System.Drawing.Font("Segoe UI", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Covid.ForeColor = System.Drawing.Color.White;
            this.Covid.Location = new System.Drawing.Point(144, 68);
            this.Covid.Name = "Covid";
            this.Covid.Size = new System.Drawing.Size(525, 88);
            this.Covid.TabIndex = 15;
            this.Covid.Text = "Covid-19";
            this.Covid.UseVisualStyleBackColor = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DimGray;
            this.Exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(314, 494);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(214, 59);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // Symptoms
            // 
            this.Symptoms.BackColor = System.Drawing.Color.DimGray;
            this.Symptoms.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Symptoms.ForeColor = System.Drawing.Color.White;
            this.Symptoms.Location = new System.Drawing.Point(314, 418);
            this.Symptoms.Name = "Symptoms";
            this.Symptoms.Size = new System.Drawing.Size(214, 59);
            this.Symptoms.TabIndex = 13;
            this.Symptoms.Text = "Symptoms";
            this.Symptoms.UseVisualStyleBackColor = false;
            this.Symptoms.Click += new System.EventHandler(this.Symptoms_Click);
            // 
            // IsolationWards
            // 
            this.IsolationWards.BackColor = System.Drawing.Color.DimGray;
            this.IsolationWards.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsolationWards.ForeColor = System.Drawing.Color.White;
            this.IsolationWards.Location = new System.Drawing.Point(314, 338);
            this.IsolationWards.Name = "IsolationWards";
            this.IsolationWards.Size = new System.Drawing.Size(214, 59);
            this.IsolationWards.TabIndex = 12;
            this.IsolationWards.Text = "Isolation Wards";
            this.IsolationWards.UseVisualStyleBackColor = false;
            this.IsolationWards.Click += new System.EventHandler(this.IsolationWards_Click);
            // 
            // QuarantineWards
            // 
            this.QuarantineWards.BackColor = System.Drawing.Color.DimGray;
            this.QuarantineWards.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuarantineWards.ForeColor = System.Drawing.Color.White;
            this.QuarantineWards.Location = new System.Drawing.Point(314, 257);
            this.QuarantineWards.Name = "QuarantineWards";
            this.QuarantineWards.Size = new System.Drawing.Size(214, 59);
            this.QuarantineWards.TabIndex = 11;
            this.QuarantineWards.Text = "Quarantine Wards";
            this.QuarantineWards.UseVisualStyleBackColor = false;
            this.QuarantineWards.Click += new System.EventHandler(this.QuarantineWards_Click_1);
            // 
            // PatientRecord
            // 
            this.PatientRecord.BackColor = System.Drawing.Color.DimGray;
            this.PatientRecord.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientRecord.ForeColor = System.Drawing.Color.White;
            this.PatientRecord.Location = new System.Drawing.Point(314, 174);
            this.PatientRecord.Name = "PatientRecord";
            this.PatientRecord.Size = new System.Drawing.Size(214, 61);
            this.PatientRecord.TabIndex = 10;
            this.PatientRecord.Text = "Patient Record";
            this.PatientRecord.UseVisualStyleBackColor = false;
            this.PatientRecord.Click += new System.EventHandler(this.PatientRecord_Click_1);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(887, 644);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Gray;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Covid-19";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Covid;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Symptoms;
        private System.Windows.Forms.Button IsolationWards;
        private System.Windows.Forms.Button QuarantineWards;
        private System.Windows.Forms.Button PatientRecord;
    }
}

