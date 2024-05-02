namespace CRUD_Task
{
	partial class Login
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
			this.emailtb = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.passwordtb = new System.Windows.Forms.TextBox();
			this.btn_Signup = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(396, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 84);
			this.label1.TabIndex = 1;
			this.label1.Text = "LOG IN";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// emailtb
			// 
			this.emailtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.emailtb.Location = new System.Drawing.Point(333, 212);
			this.emailtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.emailtb.Name = "emailtb";
			this.emailtb.Size = new System.Drawing.Size(353, 27);
			this.emailtb.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(328, 185);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Email ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label3.Location = new System.Drawing.Point(328, 293);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 25);
			this.label3.TabIndex = 6;
			this.label3.Text = "Password";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// passwordtb
			// 
			this.passwordtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordtb.Location = new System.Drawing.Point(333, 320);
			this.passwordtb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.passwordtb.Name = "passwordtb";
			this.passwordtb.Size = new System.Drawing.Size(353, 27);
			this.passwordtb.TabIndex = 7;
			this.passwordtb.UseSystemPasswordChar = true;
			this.passwordtb.TextChanged += new System.EventHandler(this.password_TextChanged);
			// 
			// btn_Signup
			// 
			this.btn_Signup.BackColor = System.Drawing.Color.Blue;
			this.btn_Signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Signup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_Signup.Location = new System.Drawing.Point(507, 402);
			this.btn_Signup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btn_Signup.Name = "btn_Signup";
			this.btn_Signup.Size = new System.Drawing.Size(117, 47);
			this.btn_Signup.TabIndex = 8;
			this.btn_Signup.Text = "Log In";
			this.btn_Signup.UseVisualStyleBackColor = false;
			this.btn_Signup.Click += new System.EventHandler(this.btn_Signup_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.button1.Location = new System.Drawing.Point(316, 409);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 36);
			this.button1.TabIndex = 17;
			this.button1.Text = "Sign Up";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(1037, 554);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btn_Signup);
			this.Controls.Add(this.passwordtb);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.emailtb);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Login";
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox emailtb;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox passwordtb;
		private System.Windows.Forms.Button btn_Signup;
		private System.Windows.Forms.Button button1;
	}
}