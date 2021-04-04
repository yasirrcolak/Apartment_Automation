using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Apartment_App
{
    public partial class AdminNewMemberPage : Form
    {
        // This string contains user details database path.
        string userDetailsTxtPath = @"..\..\userDetails.txt";
        // This string contains user information database path.
        string userNameAndPasswordTxtPath = @"..\..\userNameAndPassword.txt";
        // This string array contains Users details.
        public string[] userDetails = File.ReadAllLines(@"..\..\userDetails.txt");
        // This string array contains Users login information.        
        private string[] userNameAndPassword = File.ReadAllLines(@"..\..\userNameAndPassword.txt");
        // This string array contains a user details.
        public string[] users;

        public AdminNewMemberPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is checks user information entered.
        /// </summary>
        /// <returns></returns>
        public bool CheckDatas()
        {
            if (string.IsNullOrEmpty(userName_TextBox.Text) || string.IsNullOrWhiteSpace(userName_TextBox.Text))
            {
                MessageBox.Show("Lütfen bir kullanıcı adı giriniz.");
                return false;
            }
            else if (isDuesPaidNo_RadioButton.Checked == false && isDuesPaidYes_RadioButton.Checked == false)
            {
                MessageBox.Show("Lütfen aidat ödendi mi bilgisini işaretleyin.");
                return false;
            }
            else if (host_RadioButton.Checked == false && tenant_RadioButton.Checked == false)
            {
                MessageBox.Show("Lütfen Ev Sahibi / Kiracı bilgisini işaretleyin.");
                return false;
            }
            else if (string.IsNullOrEmpty(userLoginName_TextBox.Text) || string.IsNullOrWhiteSpace(userLoginName_TextBox.Text))
            {
                MessageBox.Show("Lütfen bir kullanıcı adı belirleyin.");
                return false;
            }
            else if (string.IsNullOrEmpty(userLoginPassword_TextBox.Text) || string.IsNullOrWhiteSpace(userLoginPassword_TextBox.Text))
            {
                MessageBox.Show("Lütfen bir giriş şifresi belirleyin.");
                return false;
            }
            else
            {
                return true;
            }

        }

        /// <summary>
        /// Check the database and delete if any.
        /// </summary>
        public void CheckAndDeleteDataBase(string user)
        {
            // user details string array is reset.
            userDetails = File.ReadAllLines(userDetailsTxtPath);
            // user login information string array is reset.
            userNameAndPassword = File.ReadAllLines(userNameAndPasswordTxtPath);

            // user details database reset
            File.Delete(userDetailsTxtPath);
            FileStream filecreate = new FileStream(userDetailsTxtPath, FileMode.OpenOrCreate, FileAccess.Write);
            filecreate.Close();

            // user login information database reset.
            File.Delete(userNameAndPasswordTxtPath);
            FileStream filecreate2 = new FileStream(userNameAndPasswordTxtPath, FileMode.OpenOrCreate, FileAccess.Write);
            filecreate2.Close();

            // skip writing if this user exists in database.
            // write others.
            for (int i = 0; i < userDetails.Length; i++)
            {
                users = userDetails[i].Split('#');

                if (users[0] == user)
                {
                    i++;
                }

                if (i < userDetails.Length)
                {
                    File.AppendAllText(userDetailsTxtPath, userDetails[i] + "\n", Encoding.UTF8);
                    File.AppendAllText(userNameAndPasswordTxtPath, userNameAndPassword[i] + "\n", Encoding.UTF8);
                }

            }

        }

        /// <summary>
        /// Add new member to database.
        /// </summary>
        public void AddDataBase()
        {

            File.AppendAllText(userDetailsTxtPath, userName_TextBox.Text + "#", Encoding.UTF8);
            File.AppendAllText(userDetailsTxtPath, registration_DateTimePicker.Text + "#", Encoding.UTF8);
            File.AppendAllText(userDetailsTxtPath, dues_NumericUpDown.Value.ToString() + "#", Encoding.UTF8);

            if (isDuesPaidYes_RadioButton.Checked == true)
            {
                File.AppendAllText(userDetailsTxtPath, isDuesPaidYes_RadioButton.Text + "#", Encoding.UTF8);
            }

            if (isDuesPaidNo_RadioButton.Checked == true)
            {
                File.AppendAllText(userDetailsTxtPath, isDuesPaidNo_RadioButton.Text + "#", Encoding.UTF8);
            }

            File.AppendAllText(userDetailsTxtPath, debt_NumericUpDown.Value.ToString() + "#", Encoding.UTF8);

            if (host_RadioButton.Checked == true)
            {
                File.AppendAllText(userDetailsTxtPath, host_RadioButton.Text + "#", Encoding.UTF8);
            }

            if (tenant_RadioButton.Checked == true)
            {
                File.AppendAllText(userDetailsTxtPath, tenant_RadioButton.Text + "#", Encoding.UTF8);
            }

            File.AppendAllText(userDetailsTxtPath, rent_NumericUpDown.Value.ToString() + "#", Encoding.UTF8);
            File.AppendAllText(userDetailsTxtPath, userLoginName_TextBox.Text + "#", Encoding.UTF8);
            File.AppendAllText(userDetailsTxtPath, userLoginPassword_TextBox.Text, Encoding.UTF8);

            File.AppendAllText(userNameAndPasswordTxtPath, userLoginName_TextBox.Text + "#", Encoding.UTF8);
            File.AppendAllText(userNameAndPasswordTxtPath, userLoginPassword_TextBox.Text, Encoding.UTF8);

        }

        /// <summary>
        /// This method is clear all text box.
        /// </summary>
        public void ClearAllTextBox()
        {
            userName_TextBox.Clear();
            dues_NumericUpDown.Value = 0;

            if (isDuesPaidYes_RadioButton.Checked == true)
            {
                isDuesPaidYes_RadioButton.Checked = false;
            }

            if (isDuesPaidNo_RadioButton.Checked == true)
            {
                isDuesPaidNo_RadioButton.Checked = false;
            }

            debt_NumericUpDown.Value = 0;

            if (host_RadioButton.Checked == true)
            {
                host_RadioButton.Checked = false;
            }

            if (tenant_RadioButton.Checked == true)
            {
                tenant_RadioButton.Checked = false;
            }

            rent_NumericUpDown.Value = 0;
            userLoginName_TextBox.Clear();
            userLoginPassword_TextBox.Clear();
        }

        /// <summary>
        /// Save button method. Check and Add new member to database.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_Button_Click(object sender, EventArgs e)
        {
            if (CheckDatas() == true)
            {
                CheckAndDeleteDataBase(userName_TextBox.Text);
                AddDataBase();
                ClearAllTextBox();

                MessageBox.Show("Kaydedildi");
            }
        }

        /// <summary>
        /// Back button method. Go to Admin Operations Page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_Button_Click(object sender, EventArgs e)
        {
            AdminOperationsPage adminOperationsPage = new AdminOperationsPage();
            adminOperationsPage.Show();
            this.Hide(); // dispose

        }

        /// <summary>
        /// Tenant radio button checked method.  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tenant_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            rent_NumericUpDown.Visible = true;
            rent_Label.Visible = true;
        }

        /// <summary>
        /// Host radio button checked method. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void host_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            rent_NumericUpDown.Value = 0;
            rent_NumericUpDown.Visible = false;
            rent_Label.Visible = false;
        }
    }
}
