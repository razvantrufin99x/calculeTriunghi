namespace calculeTriunghi
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dotControl3 = new calculeTriunghi.dotControl();
            this.dotControl2 = new calculeTriunghi.dotControl();
            this.dotControl1 = new calculeTriunghi.dotControl();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(586, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // dotControl3
            // 
            this.dotControl3.BackColor = System.Drawing.Color.Black;
            this.dotControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dotControl3.Location = new System.Drawing.Point(390, 323);
            this.dotControl3.Name = "dotControl3";
            this.dotControl3.Size = new System.Drawing.Size(13, 13);
            this.dotControl3.TabIndex = 2;
            // 
            // dotControl2
            // 
            this.dotControl2.BackColor = System.Drawing.Color.Black;
            this.dotControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dotControl2.Location = new System.Drawing.Point(127, 323);
            this.dotControl2.Name = "dotControl2";
            this.dotControl2.Size = new System.Drawing.Size(13, 13);
            this.dotControl2.TabIndex = 1;
            // 
            // dotControl1
            // 
            this.dotControl1.BackColor = System.Drawing.Color.Black;
            this.dotControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dotControl1.Location = new System.Drawing.Point(268, 60);
            this.dotControl1.Name = "dotControl1";
            this.dotControl1.Size = new System.Drawing.Size(13, 13);
            this.dotControl1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dotControl3);
            this.Controls.Add(this.dotControl2);
            this.Controls.Add(this.dotControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dotControl dotControl1;
        private dotControl dotControl2;
        private dotControl dotControl3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

