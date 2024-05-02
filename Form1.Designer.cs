namespace CRUD_Task
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.uname = new System.Windows.Forms.TextBox();
			this.btn_Signup = new System.Windows.Forms.Button();
			this.date = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.gender = new System.Windows.Forms.ComboBox();
			this.c_pass = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pass = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.email = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
			this.label1.Location = new System.Drawing.Point(341, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 66);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sign Up\r\n";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(76, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "User Name";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(76, 209);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 25);
			this.label3.TabIndex = 2;
			this.label3.Text = "Date Of Birth";
			// 
			// uname
			// 
			this.uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uname.Location = new System.Drawing.Point(79, 133);
			this.uname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.uname.Name = "uname";
			this.uname.Size = new System.Drawing.Size(232, 27);
			this.uname.TabIndex = 3;
			this.uname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// btn_Signup
			// 
			this.btn_Signup.BackColor = System.Drawing.Color.Blue;
			this.btn_Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Signup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_Signup.Location = new System.Drawing.Point(389, 452);
			this.btn_Signup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Signup.Name = "btn_Signup";
			this.btn_Signup.Size = new System.Drawing.Size(117, 47);
			this.btn_Signup.TabIndex = 5;
			this.btn_Signup.Text = "Sign Up";
			this.btn_Signup.UseVisualStyleBackColor = false;
			this.btn_Signup.Click += new System.EventHandler(this.btn_login_Click);
			// 
			// date
			// 
			this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.date.Location = new System.Drawing.Point(79, 250);
			this.date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.date.Name = "date";
			this.date.Size = new System.Drawing.Size(232, 27);
			this.date.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(76, 322);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 25);
			this.label4.TabIndex = 7;
			this.label4.Text = "Gender";
			// 
			// gender
			// 
			this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gender.FormattingEnabled = true;
			this.gender.Items.AddRange(new object[] {
            "Male ",
            "Female"});
			this.gender.Location = new System.Drawing.Point(81, 368);
			this.gender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.gender.Name = "gender";
			this.gender.Size = new System.Drawing.Size(231, 28);
			this.gender.TabIndex = 9;
			// 
			// c_pass
			// 
			this.c_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.c_pass.Location = new System.Drawing.Point(523, 368);
			this.c_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.c_pass.Name = "c_pass";
			this.c_pass.Size = new System.Drawing.Size(232, 27);
			this.c_pass.TabIndex = 11;
			this.c_pass.UseSystemPasswordChar = true;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label5.Location = new System.Drawing.Point(517, 322);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(171, 25);
			this.label5.TabIndex = 10;
			this.label5.Text = "Confirm Password";
			// 
			// pass
			// 
			this.pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pass.Location = new System.Drawing.Point(523, 252);
			this.pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pass.Name = "pass";
			this.pass.Size = new System.Drawing.Size(232, 27);
			this.pass.TabIndex = 13;
			this.pass.UseSystemPasswordChar = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label6.Location = new System.Drawing.Point(517, 209);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(98, 25);
			this.label6.TabIndex = 12;
			this.label6.Text = "Password";
			// 
			// email
			// 
			this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.email.Location = new System.Drawing.Point(520, 133);
			this.email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(232, 27);
			this.email.TabIndex = 15;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(517, 98);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 25);
			this.label7.TabIndex = 14;
			this.label7.Text = "Email";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(197, 459);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 36);
			this.button1.TabIndex = 16;
			this.button1.Text = "Log In";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(861, 549);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.email);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.pass);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.c_pass);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.gender);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.date);
			this.Controls.Add(this.btn_Signup);
			this.Controls.Add(this.uname);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "Registration Page";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox uname;
		private System.Windows.Forms.Button btn_Signup;
		private System.Windows.Forms.DateTimePicker date;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox gender;
		private System.Windows.Forms.TextBox c_pass;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox pass;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox email;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button1;
	}
}

