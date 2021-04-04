using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Apartment_App
{
    public partial class AdminChangeAndDeletePage : Form
    {
        // This string contains user details database path.
        string userDetailsTxtPath = @"..\..\userDetails.txt";
        // This string contains user information database path.
        string userNameAndPasswordTxtPath = @"..\..\userNameAndPassword.txt";
        // This string array contains Users details.
        public string[] userDetails = File.ReadAllLines(@"..\..\userDetails.txt");
        // This string array contains a user details.
        public string[] users;

        public AdminChangeAndDeletePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method is checks user information entered.
        /// </summary>
        /// <returns></returns>
        public bool CheckData()
        {

            if (host_RadioButton.Checked == false && tenant_RadioButton.Checked == false)
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
        /// Add new member to database.
        /// </summary>
        public void AddDataBase()
        {
            File.AppendAllText(userDetailsTxtPath, memberName_Label.Text + "#", Encoding.UTF8);
            File.AppendAllText(userDetailsTxtPath, registration_DateTimePicker.Text + "#", Encoding.UTF8);
            File.AppendAllText(userDetailsTxtPath, dues_NumericUpDown.Value.ToString() + "#", Encoding.UTF8);
            File.AppendAllText(userDetailsTxtPath, isDuesPaid_Label.Text + "#", Encoding.UTF8);
            File.AppendAllText(userDetailsTxtPath, debt_NumericUpDown.Value.ToString() + "#", Encoding.UTF8);

            if (host_RadioButton.Checked == true)
            {
                File.AppendAllText(userDetailsTxtPath, host_RadioButton.Text + "#", Encoding.UTF8);
                rent_NumericUpDown.Value = 0;
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
        /// Admin Change and Delete Page Loaded method. Load all users names to memberNames_Combobox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminChangeAndDeletePage_Load(object sender, EventArgs e)
        {
            memberNames_ComboBox.Items.Clear();

            userDetails = File.ReadAllLines(@"..\..\userDetails.txt");

            for (int i = 0; i < userDetails.Length; i++)
            {
                users = userDetails[i].Split('#');
                memberNames_ComboBox.Items.Add(users[0]);
            }

            memberName_Label.Text = "";
            dues_NumericUpDown.Value = 0;
            isDuesPaid_Label.Text = "";
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
        /// Selected user write to scrreen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void memberNames_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // looking all users in selected user. 
            for (int i = 0; i < userDetails.Length; i++)
            {
                users = userDetails[i].Split('#');

                // selected user write to screen.
                if (users[0] == memberNames_ComboBox.SelectedItem.ToString())
                {
                    memberName_Label.Text = users[0];
                    registration_DateTimePicker.Text = users[1];
                    dues_NumericUpDown.Value = Convert.ToInt32(users[2]);
                    isDuesPaid_Label.Text = users[3];
                    debt_NumericUpDown.Value = Convert.ToInt32(users[4]);
                    if (users[5] == "Ev Sahibi")
                    {
                        host_RadioButton.Checked = true;
                    }
                    if (users[5] == "Kiracı")
                    {
                        tenant_RadioButton.Checked = true;
                        rent_Label.Visible = true;
                        rent_NumericUpDown.Visible = true;
                    }

                    rent_NumericUpDown.Value = Convert.ToInt32(users[6]);
                    userLoginName_TextBox.Text = users[7];
                    userLoginPassword_TextBox.Text = users[8];
                }

            }
        }

        /// <summary>
        /// Host radio button checked method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void host_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            rent_NumericUpDown.Visible = false;
            rent_Label.Visible = false;
        }

        /// <summary>
        /// Tenant radio button checked method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tenant_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            rent_Label.Visible = true;
            rent_NumericUpDown.Visible = true;
        }

        /// <summary>
        /// Delete button method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_Button_Click(object sender, EventArgs e)
        {

            if (memberName_Label.Text == "")
            {
                MessageBox.Show("Lütfen bir kullanıcı seçiniz.");
            }
            else
            {

                AdminNewMemberPage adminNewMemberPage = new AdminNewMemberPage();
                adminNewMemberPage.CheckAndDeleteDataBase(memberName_Label.Text);

                AdminChangeAndDeletePage_Load(sender, e);

                MessageBox.Show("Silindi.");
            }

        }

        /// <summary>
        /// Save button method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void save_Button_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                AdminNewMemberPage adminNewMemberPage = new AdminNewMemberPage();
                adminNewMemberPage.CheckAndDeleteDataBase(memberName_Label.Text);
                AddDataBase();
                AdminChangeAndDeletePage_Load(sender, e);
                MessageBox.Show("Kaydedildi.");
            }

        }

        /// <summary>
        /// Back button method. Go to Operations Page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void back_Button_Click(object sender, EventArgs e)
        {
            AdminOperationsPage adminOperationsPage = new AdminOperationsPage();
            adminOperationsPage.Show();
            this.Hide(); // dispose
        }

    }
}
