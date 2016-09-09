namespace PokemonGo_Map_Launcher
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.btnStartDownload = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonPython = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.buttonPythonCPP = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.buttonNPM = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 19);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(139, 23);
            this.progressBar.TabIndex = 0;
            // 
            // btnStartDownload
            // 
            this.btnStartDownload.Location = new System.Drawing.Point(18, 48);
            this.btnStartDownload.Name = "btnStartDownload";
            this.btnStartDownload.Size = new System.Drawing.Size(115, 23);
            this.btnStartDownload.TabIndex = 1;
            this.btnStartDownload.Text = "Start Download";
            this.btnStartDownload.UseVisualStyleBackColor = true;
            this.btnStartDownload.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.btnStartDownload);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Download Git";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.buttonPython);
            this.groupBox2.Location = new System.Drawing.Point(169, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Download Python";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(139, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // buttonPython
            // 
            this.buttonPython.Location = new System.Drawing.Point(18, 48);
            this.buttonPython.Name = "buttonPython";
            this.buttonPython.Size = new System.Drawing.Size(115, 23);
            this.buttonPython.TabIndex = 1;
            this.buttonPython.Text = "Start Download";
            this.buttonPython.UseVisualStyleBackColor = true;
            this.buttonPython.Click += new System.EventHandler(this.buttonPython_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.progressBar2);
            this.groupBox3.Controls.Add(this.buttonPythonCPP);
            this.groupBox3.Location = new System.Drawing.Point(12, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 81);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Download Python C++";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(6, 19);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(139, 23);
            this.progressBar2.TabIndex = 0;
            // 
            // buttonPythonCPP
            // 
            this.buttonPythonCPP.Location = new System.Drawing.Point(18, 48);
            this.buttonPythonCPP.Name = "buttonPythonCPP";
            this.buttonPythonCPP.Size = new System.Drawing.Size(115, 23);
            this.buttonPythonCPP.TabIndex = 1;
            this.buttonPythonCPP.Text = "Start Download";
            this.buttonPythonCPP.UseVisualStyleBackColor = true;
            this.buttonPythonCPP.Click += new System.EventHandler(this.buttonPythonCPP_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.progressBar3);
            this.groupBox4.Controls.Add(this.buttonNPM);
            this.groupBox4.Location = new System.Drawing.Point(169, 99);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(151, 81);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Download NPM";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(6, 19);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(139, 23);
            this.progressBar3.TabIndex = 0;
            // 
            // buttonNPM
            // 
            this.buttonNPM.Location = new System.Drawing.Point(18, 48);
            this.buttonNPM.Name = "buttonNPM";
            this.buttonNPM.Size = new System.Drawing.Size(115, 23);
            this.buttonNPM.TabIndex = 1;
            this.buttonNPM.Text = "Start Download";
            this.buttonNPM.UseVisualStyleBackColor = true;
            this.buttonNPM.Click += new System.EventHandler(this.buttonNPM_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 191);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "Download PreReqs";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnStartDownload;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonPython;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button buttonPythonCPP;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Button buttonNPM;
    }
}