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
using System.Net;
using System.Xml.Linq;

namespace CRUD_Task
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		
		SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"G:\\University Notes\\6th Semester\\OBJECT ORIENTED PROGRAMMING 2\\HomeTask\\CRUD_Task\\Database\\System2.mdf\";Integrated Security=True;Connect Timeout=30");
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			try
			{
				if(uname.Text!= "" && date.Text != "" && gender.Text != "" && email.Text != "" && pass.Text != "" && c_pass.Text != "")
				{
					if (pass.Text == c_pass.Text)
					{
						int v = check(email.Text);
						if (v != 1)
						{
							connection.Open();
							SqlCommand command = new SqlCommand("INSERT INTO Registrationtbl (u_name, b_date, gender, email, password) values (@u_name, @b_date, @gender, @email, @password)", connection);


							command.Parameters.AddWithValue("u_name", uname.Text);
							command.Parameters.AddWithValue("@b_date", Convert.ToDateTime(date.Text));
							command.Parameters.AddWithValue("@gender", gender.Text);
							command.Parameters.AddWithValue("@email", email.Text);
							command.Parameters.AddWithValue("@password", pass.Text);
							command.ExecuteNonQuery();
							connection.Close();
							MessageBox.Show("Registered Successfully!");
							uname.Text = "";
							gender.Text = "";
							email.Text = "";
							pass.Text = "";
						}
						else
						{
							MessageBox.Show("You are already registered.");
						}
					}
					else
					{
						MessageBox.Show("Password does not match.");
					}
				}
				else
				{
					MessageBox.Show("Enter all the required informations.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		int check(string email)
		{
			connection.Open();
			string query = "select count(*) from Registrationtbl where email='" + email + "'";
			SqlCommand command = new SqlCommand(query, connection);
			int v = (int)command.ExecuteScalar();
			connection.Close();
			return v;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login login = new Login();	
			login.Show();	
		}
	}
}
