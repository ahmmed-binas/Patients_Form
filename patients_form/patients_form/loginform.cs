using System;
using System.Windows.Forms;

using MySql.Data.MySqlClient;
using Mysqlx.Cursor;

namespace patients_form
{
    public partial class loginform : Form
    {

        
        public loginform()
        {
            InitializeComponent();
        }

        public void SetPassword(string password)
        {
           password_textbox.Text = password;
        }

        public void SetUsername(string username)
        {
            username_textbox.Text = username;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public MySqlConnection GetConnection()
        {
            string connectionString = "Server=kaizenstars.dyndns.org;Port=3307;Database=loginform;Uid=kaizen;Pwd=Admin@231527;";
            return new MySqlConnection(connectionString);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void username_textlabel_Click(object sender, EventArgs e)
        {

        }

        private void register_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
       
            registerationform rf = new registerationform();
             
            rf.Show();

            this.Hide();
            
           

        }
     

        private void login_textlabel_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void register_linklabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void login_textlabel_Click_1(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = username_textbox.Text;
            string password = password_textbox.Text;

            //handling the cases if the user did not enter anything!
            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("please dont leave useranme or password fields empty.");

                return;
            }

            using (MySqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT password FROM login_details WHERE username = @username";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string storedPassword = result.ToString();

                        if (storedPassword == password)
                        {
                            MessageBox.Show("Login was successful!");


                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The Entered Details Are Not Correct..");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
