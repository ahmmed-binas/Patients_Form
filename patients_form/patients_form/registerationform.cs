using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace patients_form
{
    public partial class registerationform : Form
    {
        public registerationform()
        {
            InitializeComponent();
        }






        private void registerationform_Load(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void rusername_textbox_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void registration_label_Click(object sender, EventArgs e)
        {

        }

        private void firstname_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string firstname = firstname_textbox.Text;
            string lastname = lastname_textbox.Text;
            DateTime dateofbirth = dob_datetimepicker.Value;
            string dob = dateofbirth.ToString("yyyy-MM-dd");
            string selectedGender = gender_combox.Text;
            string username = rusername_textbox.Text;
            string password = rpassword_textbox.Text;
            string re_password = repassword_textbox.Text;

            if (password != re_password)
            {
                MessageBox.Show("The passwords do not match.");
                return;
            }

            if (string.IsNullOrWhiteSpace(firstname) ||
                string.IsNullOrWhiteSpace(lastname) ||
                string.IsNullOrWhiteSpace(dob) ||
                string.IsNullOrWhiteSpace(selectedGender) ||
                string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(re_password))
            {
                MessageBox.Show("Please do not leave any fields empty.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection("Server=kaizenstars.dyndns.org;Port=3307;Database=loginform;Uid=kaizen;Pwd=Admin@231527;"))
            {
                try
                {
                    conn.Open();

                    string checkUserQuery = "SELECT COUNT(*) FROM login_details WHERE username = @username";
                    MySqlCommand checkUserCmd = new MySqlCommand(checkUserQuery, conn);
                    checkUserCmd.Parameters.AddWithValue("@username", username);

                    int userCount = Convert.ToInt32(checkUserCmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("The username already exists. Please choose a different username.");
                        return;
                    }

                    string insertQuery = "INSERT INTO login_details (firstname, lastname, dateofbirth, gender, username, password) " +
                                         "VALUES (@firstname, @lastname, @dob, @gender, @username, @password)";
                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@firstname", firstname);
                    insertCmd.Parameters.AddWithValue("@lastname", lastname);
                    insertCmd.Parameters.AddWithValue("@dob", dob);
                    insertCmd.Parameters.AddWithValue("@gender", selectedGender);
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password", password);

                    insertCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successful!");

                   
                    loginform lf = new loginform();
                    lf.SetUsername(username); 
                    lf.SetPassword(password); 

                   
                    this.Hide(); 

                    

                     
                    lf.Show();
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
    }
}
        

       

