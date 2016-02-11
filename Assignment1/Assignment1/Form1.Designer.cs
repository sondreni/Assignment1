namespace Assignment1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnSampling = new System.Windows.Forms.Button();
            this.btnLogging = new System.Windows.Forms.Button();
            this.txtNextSamplingTime = new System.Windows.Forms.TextBox();
            this.txtNextLoggingTime = new System.Windows.Forms.TextBox();
            this.txtSensorData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumberOfWrites = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSampling
            // 
            this.btnSampling.Location = new System.Drawing.Point(8, 47);
            this.btnSampling.Name = "btnSampling";
            this.btnSampling.Size = new System.Drawing.Size(95, 23);
            this.btnSampling.TabIndex = 0;
            this.btnSampling.Text = "Toggle Sampling";
            this.btnSampling.UseVisualStyleBackColor = true;
            this.btnSampling.Click += new System.EventHandler(this.btnSampling_Click);
            // 
            // btnLogging
            // 
            this.btnLogging.Enabled = false;
            this.btnLogging.Location = new System.Drawing.Point(8, 101);
            this.btnLogging.Name = "btnLogging";
            this.btnLogging.Size = new System.Drawing.Size(95, 23);
            this.btnLogging.TabIndex = 1;
            this.btnLogging.Text = "Toggle Logging";
            this.btnLogging.UseVisualStyleBackColor = true;
            this.btnLogging.Click += new System.EventHandler(this.btnLogging_Click_1);
            // 
            // txtNextSamplingTime
            // 
            this.txtNextSamplingTime.Enabled = false;
            this.txtNextSamplingTime.Location = new System.Drawing.Point(109, 50);
            this.txtNextSamplingTime.Name = "txtNextSamplingTime";
            this.txtNextSamplingTime.ReadOnly = true;
            this.txtNextSamplingTime.Size = new System.Drawing.Size(100, 20);
            this.txtNextSamplingTime.TabIndex = 2;
            // 
            // txtNextLoggingTime
            // 
            this.txtNextLoggingTime.Enabled = false;
            this.txtNextLoggingTime.Location = new System.Drawing.Point(109, 103);
            this.txtNextLoggingTime.Name = "txtNextLoggingTime";
            this.txtNextLoggingTime.ReadOnly = true;
            this.txtNextLoggingTime.Size = new System.Drawing.Size(100, 20);
            this.txtNextLoggingTime.TabIndex = 3;
            // 
            // txtSensorData
            // 
            this.txtSensorData.Enabled = false;
            this.txtSensorData.Location = new System.Drawing.Point(220, 47);
            this.txtSensorData.Multiline = true;
            this.txtSensorData.Name = "txtSensorData";
            this.txtSensorData.ReadOnly = true;
            this.txtSensorData.Size = new System.Drawing.Size(222, 97);
            this.txtSensorData.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Time to next sample";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time to next log entry";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sensor Values";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of writes";
            // 
            // lblNumberOfWrites
            // 
            this.lblNumberOfWrites.AutoSize = true;
            this.lblNumberOfWrites.Location = new System.Drawing.Point(106, 131);
            this.lblNumberOfWrites.Name = "lblNumberOfWrites";
            this.lblNumberOfWrites.Size = new System.Drawing.Size(13, 13);
            this.lblNumberOfWrites.TabIndex = 10;
            this.lblNumberOfWrites.Text = "0";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(13, 150);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 13);
            this.lblFileName.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 172);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblNumberOfWrites);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSensorData);
            this.Controls.Add(this.txtNextLoggingTime);
            this.Controls.Add(this.txtNextSamplingTime);
            this.Controls.Add(this.btnLogging);
            this.Controls.Add(this.btnSampling);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSampling;
        private System.Windows.Forms.Button btnLogging;
        private System.Windows.Forms.TextBox txtNextSamplingTime;
        private System.Windows.Forms.TextBox txtNextLoggingTime;
        private System.Windows.Forms.TextBox txtSensorData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumberOfWrites;
        private System.Windows.Forms.Label lblFileName;
    }
}

