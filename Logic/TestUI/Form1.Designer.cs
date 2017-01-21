namespace TestUI
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.cbxSetup = new System.Windows.Forms.CheckBox();
            this.btnBFS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBFSSolution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(129, 60);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(23, 23);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "0";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(129, 179);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(23, 23);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "4";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(162, 86);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(23, 23);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "1";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(195, 116);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(23, 23);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "2";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(90, 149);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(23, 23);
            this.btn6.TabIndex = 4;
            this.btn6.Text = "5";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.button_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(162, 149);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(23, 23);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "3";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(61, 116);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(23, 23);
            this.btn7.TabIndex = 6;
            this.btn7.Text = "6";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(90, 86);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(23, 23);
            this.btn8.TabIndex = 7;
            this.btn8.Text = "7";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button_Click);
            // 
            // cbxSetup
            // 
            this.cbxSetup.AutoSize = true;
            this.cbxSetup.Location = new System.Drawing.Point(111, 24);
            this.cbxSetup.Name = "cbxSetup";
            this.cbxSetup.Size = new System.Drawing.Size(54, 17);
            this.cbxSetup.TabIndex = 8;
            this.cbxSetup.Text = "Setup";
            this.cbxSetup.UseVisualStyleBackColor = true;
            // 
            // btnBFS
            // 
            this.btnBFS.Location = new System.Drawing.Point(110, 226);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(75, 23);
            this.btnBFS.TabIndex = 9;
            this.btnBFS.Text = "Solve BFS";
            this.btnBFS.UseVisualStyleBackColor = true;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "BFS Solution is: ";
            // 
            // lblBFSSolution
            // 
            this.lblBFSSolution.AutoSize = true;
            this.lblBFSSolution.Location = new System.Drawing.Point(141, 269);
            this.lblBFSSolution.Name = "lblBFSSolution";
            this.lblBFSSolution.Size = new System.Drawing.Size(35, 13);
            this.lblBFSSolution.TabIndex = 11;
            this.lblBFSSolution.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 294);
            this.Controls.Add(this.lblBFSSolution);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBFS);
            this.Controls.Add(this.cbxSetup);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.CheckBox cbxSetup;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBFSSolution;
    }
}

