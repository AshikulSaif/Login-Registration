using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace CRUD_Task
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();
		}
		private string Connection_string = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\G:\\University Notes\\6th Semester\\OBJECT ORIENTED PROGRAMMING 2\\HomeTask\\CRUD_Task\\Database\\System2.mdf\;Integrated Security=True;Connect Timeout=30";
		private void label3_Click(object sender, EventArgs e)
		{

		}
		private void password_TextChanged(object sender, EventArgs e)
		{

		}
		private void btn_Signup_Click(object sender, EventArgs e)
		{
			String email = emailtb.Text.ToString();
			String password = passwordtb.Text.ToString();
			if (String.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
			{
				DialogResult dialogResult = MessageBox.Show("No empty fields allowed", "You cannot continue", MessageBoxButtons.OK);
			}
			else
			{
				SqlConnection connection = new SqlConnection();
				connection.ConnectionString = Connection_string;
				connection.Open();
				SqlCommand cmd = new SqlCommand();
				cmd.Connection = connection;
				cmd.CommandText = "select * from Registrationtbl where email='" + email + "' and " +
					"password='" + password + "'";
				SqlDataReader reader = cmd.ExecuteReader();

				if (reader.HasRows)
				{
					while (reader.Read())
					{
						MessageBox.Show("User found for id:" + reader.GetInt32(0).ToString());
						MessageBox.Show("Welcome to your profile!");
					}
				}
				else
				{
					MessageBox.Show("Invalid username or password", "Error!");
				}
				connection.Close();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 form1 = new Form1();
			this.Hide();
			form1.Show();
		}
	}
}
