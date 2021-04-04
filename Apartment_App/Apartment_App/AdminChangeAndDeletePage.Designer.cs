
namespace Apartment_App
{
    partial class AdminChangeAndDeletePage
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
            this.back_Button = new System.Windows.Forms.Button();
            this.delete_Button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.host_RadioButton = new System.Windows.Forms.RadioButton();
            this.tenant_RadioButton = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.userLoginName_TextBox = new System.Windows.Forms.TextBox();
            this.registration_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.userLoginPassword_TextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.rent_Label = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.save_Button = new System.Windows.Forms.Button();
            this.isDuesPaid_Label = new System.Windows.Forms.Label();
            this.memberName_Label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.memberNames_ComboBox = new System.Windows.Forms.ComboBox();
            this.dues_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.debt_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rent_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dues_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debt_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // back_Button
            // 
            this.back_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.back_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_Button.Location = new System.Drawing.Point(435, 602);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(163, 57);
            this.back_Button.TabIndex = 113;
            this.back_Button.Text = "Geri";
            this.back_Button.UseVisualStyleBackColor = false;
            this.back_Button.Click += new System.EventHandler(this.back_Button_Click);
            // 
            // delete_Button
            // 
            this.delete_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.delete_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_Button.Location = new System.Drawing.Point(259, 539);
            this.delete_Button.Name = "delete_Button";
            this.delete_Button.Size = new System.Drawing.Size(163, 57);
            this.delete_Button.TabIndex = 112;
            this.delete_Button.Text = "Sil";
            this.delete_Button.UseVisualStyleBackColor = false;
            this.delete_Button.Click += new System.EventHandler(this.delete_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.host_RadioButton);
            this.groupBox1.Controls.Add(this.tenant_RadioButton);
            this.groupBox1.Location = new System.Drawing.Point(435, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 98);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            // 
            // host_RadioButton
            // 
            this.host_RadioButton.AutoSize = true;
            this.host_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.host_RadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.host_RadioButton.Location = new System.Drawing.Point(14, 19);
            this.host_RadioButton.Name = "host_RadioButton";
            this.host_RadioButton.Size = new System.Drawing.Size(146, 35);
            this.host_RadioButton.TabIndex = 106;
            this.host_RadioButton.TabStop = true;
            this.host_RadioButton.Text = "Ev Sahibi";
            this.host_RadioButton.UseVisualStyleBackColor = true;
            this.host_RadioButton.CheckedChanged += new System.EventHandler(this.host_RadioButton_CheckedChanged);
            // 
            // tenant_RadioButton
            // 
            this.tenant_RadioButton.AutoSize = true;
            this.tenant_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tenant_RadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tenant_RadioButton.Location = new System.Drawing.Point(14, 53);
            this.tenant_RadioButton.Name = "tenant_RadioButton";
            this.tenant_RadioButton.Size = new System.Drawing.Size(100, 35);
            this.tenant_RadioButton.TabIndex = 107;
            this.tenant_RadioButton.TabStop = true;
            this.tenant_RadioButton.Text = "Kiracı";
            this.tenant_RadioButton.UseVisualStyleBackColor = true;
            this.tenant_RadioButton.CheckedChanged += new System.EventHandler(this.tenant_RadioButton_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(61, 455);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 32);
            this.label11.TabIndex = 117;
            this.label11.Text = "Kullanıcı Adı:";
            // 
            // userLoginName_TextBox
            // 
            this.userLoginName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userLoginName_TextBox.Location = new System.Drawing.Point(260, 451);
            this.userLoginName_TextBox.Name = "userLoginName_TextBox";
            this.userLoginName_TextBox.Size = new System.Drawing.Size(337, 38);
            this.userLoginName_TextBox.TabIndex = 109;
            // 
            // registration_DateTimePicker
            // 
            this.registration_DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registration_DateTimePicker.Location = new System.Drawing.Point(260, 172);
            this.registration_DateTimePicker.Name = "registration_DateTimePicker";
            this.registration_DateTimePicker.Size = new System.Drawing.Size(336, 38);
            this.registration_DateTimePicker.TabIndex = 102;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(74, 501);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 32);
            this.label12.TabIndex = 114;
            this.label12.Text = "Giriş Şifresi:";
            // 
            // userLoginPassword_TextBox
            // 
            this.userLoginPassword_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userLoginPassword_TextBox.Location = new System.Drawing.Point(260, 495);
            this.userLoginPassword_TextBox.Name = "userLoginPassword_TextBox";
            this.userLoginPassword_TextBox.Size = new System.Drawing.Size(337, 38);
            this.userLoginPassword_TextBox.TabIndex = 110;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(63, 309);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 32);
            this.label13.TabIndex = 112;
            this.label13.Text = "Biriken Borç:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(16, 260);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(238, 32);
            this.label14.TabIndex = 111;
            this.label14.Text = "Aidat Ödendi mi:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(66, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(188, 32);
            this.label15.TabIndex = 110;
            this.label15.Text = "Aidat Miktarı:";
            // 
            // rent_Label
            // 
            this.rent_Label.AutoSize = true;
            this.rent_Label.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rent_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rent_Label.Location = new System.Drawing.Point(84, 411);
            this.rent_Label.Name = "rent_Label";
            this.rent_Label.Size = new System.Drawing.Size(170, 32);
            this.rent_Label.TabIndex = 109;
            this.rent_Label.Text = "Kira Bedeli:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(79, 179);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(175, 32);
            this.label17.TabIndex = 105;
            this.label17.Text = "Kayıt Tarihi:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(185, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 32);
            this.label18.TabIndex = 104;
            this.label18.Text = "Adı:";
            // 
            // save_Button
            // 
            this.save_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.save_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.save_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_Button.Location = new System.Drawing.Point(435, 539);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(163, 57);
            this.save_Button.TabIndex = 111;
            this.save_Button.Text = "Kaydet";
            this.save_Button.UseVisualStyleBackColor = false;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // isDuesPaid_Label
            // 
            this.isDuesPaid_Label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.isDuesPaid_Label.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isDuesPaid_Label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.isDuesPaid_Label.Location = new System.Drawing.Point(260, 260);
            this.isDuesPaid_Label.Name = "isDuesPaid_Label";
            this.isDuesPaid_Label.Size = new System.Drawing.Size(337, 38);
            this.isDuesPaid_Label.TabIndex = 104;
            // 
            // memberName_Label
            // 
            this.memberName_Label.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memberName_Label.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.memberName_Label.ForeColor = System.Drawing.SystemColors.WindowText;
            this.memberName_Label.Location = new System.Drawing.Point(260, 128);
            this.memberName_Label.Name = "memberName_Label";
            this.memberName_Label.Size = new System.Drawing.Size(337, 38);
            this.memberName_Label.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(76, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 32);
            this.label8.TabIndex = 100;
            this.label8.Text = "Üye Seçiniz:";
            // 
            // memberNames_ComboBox
            // 
            this.memberNames_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memberNames_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.memberNames_ComboBox.FormattingEnabled = true;
            this.memberNames_ComboBox.Location = new System.Drawing.Point(260, 33);
            this.memberNames_ComboBox.Name = "memberNames_ComboBox";
            this.memberNames_ComboBox.Size = new System.Drawing.Size(336, 39);
            this.memberNames_ComboBox.TabIndex = 99;
            this.memberNames_ComboBox.SelectedIndexChanged += new System.EventHandler(this.memberNames_ComboBox_SelectedIndexChanged);
            // 
            // dues_NumericUpDown
            // 
            this.dues_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dues_NumericUpDown.Location = new System.Drawing.Point(260, 216);
            this.dues_NumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.dues_NumericUpDown.Name = "dues_NumericUpDown";
            this.dues_NumericUpDown.Size = new System.Drawing.Size(338, 38);
            this.dues_NumericUpDown.TabIndex = 119;
            // 
            // debt_NumericUpDown
            // 
            this.debt_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.debt_NumericUpDown.Location = new System.Drawing.Point(259, 306);
            this.debt_NumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.debt_NumericUpDown.Name = "debt_NumericUpDown";
            this.debt_NumericUpDown.Size = new System.Drawing.Size(338, 38);
            this.debt_NumericUpDown.TabIndex = 120;
            // 
            // rent_NumericUpDown
            // 
            this.rent_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rent_NumericUpDown.Location = new System.Drawing.Point(259, 408);
            this.rent_NumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.rent_NumericUpDown.Name = "rent_NumericUpDown";
            this.rent_NumericUpDown.Size = new System.Drawing.Size(170, 38);
            this.rent_NumericUpDown.TabIndex = 121;
            this.rent_NumericUpDown.Visible = false;
            // 
            // AdminChangeAndDeletePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(672, 681);
            this.Controls.Add(this.rent_NumericUpDown);
            this.Controls.Add(this.debt_NumericUpDown);
            this.Controls.Add(this.dues_NumericUpDown);
            this.Controls.Add(this.delete_Button);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.userLoginName_TextBox);
            this.Controls.Add(this.registration_DateTimePicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.userLoginPassword_TextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rent_Label);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.isDuesPaid_Label);
            this.Controls.Add(this.memberName_Label);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.memberNames_ComboBox);
            this.Controls.Add(this.back_Button);
            this.MaximizeBox = false;
            this.Name = "AdminChangeAndDeletePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye düzenleme ve silme sayfası";
            this.Load += new System.EventHandler(this.AdminChangeAndDeletePage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dues_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debt_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_Button;
        private System.Windows.Forms.Button delete_Button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton host_RadioButton;
        private System.Windows.Forms.RadioButton tenant_RadioButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox userLoginName_TextBox;
        private System.Windows.Forms.DateTimePicker registration_DateTimePicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox userLoginPassword_TextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label rent_Label;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Label isDuesPaid_Label;
        private System.Windows.Forms.Label memberName_Label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox memberNames_ComboBox;
        private System.Windows.Forms.NumericUpDown dues_NumericUpDown;
        private System.Windows.Forms.NumericUpDown debt_NumericUpDown;
        private System.Windows.Forms.NumericUpDown rent_NumericUpDown;
    }
}