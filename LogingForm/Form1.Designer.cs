namespace LogingForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Registrebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.confirmtxt = new System.Windows.Forms.TextBox();
            this.LastNametxt = new System.Windows.Forms.TextBox();
            this.UserNametxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNametxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.confirmbtn2 = new System.Windows.Forms.Button();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.passwordtxt2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.White;
            this.Loginbtn.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Loginbtn.Location = new System.Drawing.Point(53, 40);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(181, 65);
            this.Loginbtn.TabIndex = 0;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Registrebtn
            // 
            this.Registrebtn.BackColor = System.Drawing.Color.White;
            this.Registrebtn.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Registrebtn.Location = new System.Drawing.Point(309, 40);
            this.Registrebtn.Name = "Registrebtn";
            this.Registrebtn.Size = new System.Drawing.Size(181, 65);
            this.Registrebtn.TabIndex = 1;
            this.Registrebtn.Text = "Registre";
            this.Registrebtn.UseVisualStyleBackColor = false;
            this.Registrebtn.Click += new System.EventHandler(this.Registrebtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confirmbtn);
            this.panel1.Controls.Add(this.confirmtxt);
            this.panel1.Controls.Add(this.LastNametxt);
            this.panel1.Controls.Add(this.UserNametxt);
            this.panel1.Controls.Add(this.Passwordtxt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.FirstNametxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 557);
            this.panel1.TabIndex = 2;
            // 
            // confirmbtn
            // 
            this.confirmbtn.BackColor = System.Drawing.Color.Black;
            this.confirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmbtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmbtn.Location = new System.Drawing.Point(82, 466);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(357, 58);
            this.confirmbtn.TabIndex = 10;
            this.confirmbtn.Text = "Registre";
            this.confirmbtn.UseVisualStyleBackColor = false;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // confirmtxt
            // 
            this.confirmtxt.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmtxt.Location = new System.Drawing.Point(287, 399);
            this.confirmtxt.Multiline = true;
            this.confirmtxt.Name = "confirmtxt";
            this.confirmtxt.Size = new System.Drawing.Size(207, 38);
            this.confirmtxt.TabIndex = 9;
            this.confirmtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LastNametxt
            // 
            this.LastNametxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNametxt.Location = new System.Drawing.Point(287, 156);
            this.LastNametxt.Multiline = true;
            this.LastNametxt.Name = "LastNametxt";
            this.LastNametxt.Size = new System.Drawing.Size(207, 38);
            this.LastNametxt.TabIndex = 8;
            this.LastNametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserNametxt
            // 
            this.UserNametxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNametxt.Location = new System.Drawing.Point(287, 237);
            this.UserNametxt.Multiline = true;
            this.UserNametxt.Name = "UserNametxt";
            this.UserNametxt.Size = new System.Drawing.Size(207, 38);
            this.UserNametxt.TabIndex = 7;
            this.UserNametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Passwordtxt.Location = new System.Drawing.Point(287, 318);
            this.Passwordtxt.Multiline = true;
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(207, 38);
            this.Passwordtxt.TabIndex = 6;
            this.Passwordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "   Last Name :    ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(15, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "    UserName :   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "    Password  :   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Confirm Password:";
            // 
            // FirstNametxt
            // 
            this.FirstNametxt.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNametxt.Location = new System.Drawing.Point(287, 75);
            this.FirstNametxt.Multiline = true;
            this.FirstNametxt.Name = "FirstNametxt";
            this.FirstNametxt.Size = new System.Drawing.Size(207, 38);
            this.FirstNametxt.TabIndex = 1;
            this.FirstNametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "    First Name :   ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.confirmbtn2);
            this.panel2.Controls.Add(this.usertxt);
            this.panel2.Controls.Add(this.passwordtxt2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 557);
            this.panel2.TabIndex = 11;
            // 
            // confirmbtn2
            // 
            this.confirmbtn2.BackColor = System.Drawing.Color.Black;
            this.confirmbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmbtn2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmbtn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmbtn2.Location = new System.Drawing.Point(82, 336);
            this.confirmbtn2.Name = "confirmbtn2";
            this.confirmbtn2.Size = new System.Drawing.Size(357, 58);
            this.confirmbtn2.TabIndex = 10;
            this.confirmbtn2.Text = "Login";
            this.confirmbtn2.UseVisualStyleBackColor = false;
            this.confirmbtn2.Click += new System.EventHandler(this.confirmbtn2_Click);
            // 
            // usertxt
            // 
            this.usertxt.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usertxt.Location = new System.Drawing.Point(287, 155);
            this.usertxt.Multiline = true;
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(207, 38);
            this.usertxt.TabIndex = 7;
            this.usertxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordtxt2
            // 
            this.passwordtxt2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordtxt2.Location = new System.Drawing.Point(287, 229);
            this.passwordtxt2.Multiline = true;
            this.passwordtxt2.Name = "passwordtxt2";
            this.passwordtxt2.Size = new System.Drawing.Size(207, 38);
            this.passwordtxt2.TabIndex = 6;
            this.passwordtxt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(15, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 38);
            this.label7.TabIndex = 4;
            this.label7.Text = "    UserName :   ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(21, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 38);
            this.label8.TabIndex = 3;
            this.label8.Text = "    Password  :   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(556, 692);
            this.Controls.Add(this.Registrebtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Loginbtn;
        private Button Registrebtn;
        private Panel panel1;
        private Button confirmbtn;
        private TextBox confirmtxt;
        private TextBox LastNametxt;
        private TextBox UserNametxt;
        private TextBox Passwordtxt;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox FirstNametxt;
        private Label label1;
        private Panel panel2;
        private Button confirmbtn2;
        private TextBox usertxt;
        private TextBox passwordtxt2;
        private Label label7;
        private Label label8;
    }
}