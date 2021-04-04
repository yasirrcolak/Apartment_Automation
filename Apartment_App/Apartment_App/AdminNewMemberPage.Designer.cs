
namespace Apartment_App
{
    partial class AdminNewMemberPage
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
            this.isDuesPaid_GroupBox = new System.Windows.Forms.GroupBox();
            this.isDuesPaidNo_RadioButton = new System.Windows.Forms.RadioButton();
            this.isDuesPaidYes_RadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.host_RadioButton = new System.Windows.Forms.RadioButton();
            this.tenant_RadioButton = new System.Windows.Forms.RadioButton();
            this.userName_TextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.userLoginName_TextBox = new System.Windows.Forms.TextBox();
            this.registration_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.userLoginPassword_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rent_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.save_Button = new System.Windows.Forms.Button();
            this.debt_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dues_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rent_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.isDuesPaid_GroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debt_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dues_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // back_Button
            // 
            this.back_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.back_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.back_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.back_Button.Location = new System.Drawing.Point(243, 449);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(163, 57);
            this.back_Button.TabIndex = 13;
            this.back_Button.Text = "Geri";
            this.back_Button.UseVisualStyleBackColor = false;
            this.back_Button.Click += new System.EventHandler(this.back_Button_Click);
            // 
            // isDuesPaid_GroupBox
            // 
            this.isDuesPaid_GroupBox.Controls.Add(this.isDuesPaidNo_RadioButton);
            this.isDuesPaid_GroupBox.Controls.Add(this.isDuesPaidYes_RadioButton);
            this.isDuesPaid_GroupBox.Location = new System.Drawing.Point(243, 164);
            this.isDuesPaid_GroupBox.Name = "isDuesPaid_GroupBox";
            this.isDuesPaid_GroupBox.Size = new System.Drawing.Size(338, 45);
            this.isDuesPaid_GroupBox.TabIndex = 97;
            this.isDuesPaid_GroupBox.TabStop = false;
            // 
            // isDuesPaidNo_RadioButton
            // 
            this.isDuesPaidNo_RadioButton.AutoSize = true;
            this.isDuesPaidNo_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isDuesPaidNo_RadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.isDuesPaidNo_RadioButton.Location = new System.Drawing.Point(190, 7);
            this.isDuesPaidNo_RadioButton.Name = "isDuesPaidNo_RadioButton";
            this.isDuesPaidNo_RadioButton.Size = new System.Drawing.Size(96, 35);
            this.isDuesPaidNo_RadioButton.TabIndex = 5;
            this.isDuesPaidNo_RadioButton.TabStop = true;
            this.isDuesPaidNo_RadioButton.Text = "Hayır";
            this.isDuesPaidNo_RadioButton.UseVisualStyleBackColor = true;
            // 
            // isDuesPaidYes_RadioButton
            // 
            this.isDuesPaidYes_RadioButton.AutoSize = true;
            this.isDuesPaidYes_RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.isDuesPaidYes_RadioButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.isDuesPaidYes_RadioButton.Location = new System.Drawing.Point(17, 7);
            this.isDuesPaidYes_RadioButton.Name = "isDuesPaidYes_RadioButton";
            this.isDuesPaidYes_RadioButton.Size = new System.Drawing.Size(87, 35);
            this.isDuesPaidYes_RadioButton.TabIndex = 4;
            this.isDuesPaidYes_RadioButton.TabStop = true;
            this.isDuesPaidYes_RadioButton.Text = "Evet";
            this.isDuesPaidYes_RadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.host_RadioButton);
            this.groupBox1.Controls.Add(this.tenant_RadioButton);
            this.groupBox1.Location = new System.Drawing.Point(419, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 98);
            this.groupBox1.TabIndex = 96;
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
            this.host_RadioButton.TabIndex = 9;
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
            this.tenant_RadioButton.TabIndex = 8;
            this.tenant_RadioButton.TabStop = true;
            this.tenant_RadioButton.Text = "Kiracı";
            this.tenant_RadioButton.UseVisualStyleBackColor = true;
            this.tenant_RadioButton.CheckedChanged += new System.EventHandler(this.tenant_RadioButton_CheckedChanged);
            // 
            // userName_TextBox
            // 
            this.userName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userName_TextBox.Location = new System.Drawing.Point(244, 38);
            this.userName_TextBox.Name = "userName_TextBox";
            this.userName_TextBox.Size = new System.Drawing.Size(337, 38);
            this.userName_TextBox.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(45, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 32);
            this.label9.TabIndex = 94;
            this.label9.Text = "Kullanıcı Adı:";
            // 
            // userLoginName_TextBox
            // 
            this.userLoginName_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userLoginName_TextBox.Location = new System.Drawing.Point(244, 361);
            this.userLoginName_TextBox.Name = "userLoginName_TextBox";
            this.userLoginName_TextBox.Size = new System.Drawing.Size(337, 38);
            this.userLoginName_TextBox.TabIndex = 10;
            // 
            // registration_DateTimePicker
            // 
            this.registration_DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registration_DateTimePicker.Location = new System.Drawing.Point(244, 82);
            this.registration_DateTimePicker.Name = "registration_DateTimePicker";
            this.registration_DateTimePicker.Size = new System.Drawing.Size(336, 38);
            this.registration_DateTimePicker.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(58, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 32);
            this.label7.TabIndex = 91;
            this.label7.Text = "Giriş Şifresi:";
            // 
            // userLoginPassword_TextBox
            // 
            this.userLoginPassword_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userLoginPassword_TextBox.Location = new System.Drawing.Point(244, 405);
            this.userLoginPassword_TextBox.Name = "userLoginPassword_TextBox";
            this.userLoginPassword_TextBox.Size = new System.Drawing.Size(337, 38);
            this.userLoginPassword_TextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(47, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 32);
            this.label6.TabIndex = 89;
            this.label6.Text = "Biriken Borç:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(0, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(238, 32);
            this.label5.TabIndex = 88;
            this.label5.Text = "Aidat Ödendi mi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(50, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 32);
            this.label4.TabIndex = 87;
            this.label4.Text = "Aidat Miktarı:";
            // 
            // rent_Label
            // 
            this.rent_Label.AutoSize = true;
            this.rent_Label.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rent_Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rent_Label.Location = new System.Drawing.Point(68, 321);
            this.rent_Label.Name = "rent_Label";
            this.rent_Label.Size = new System.Drawing.Size(170, 32);
            this.rent_Label.TabIndex = 86;
            this.rent_Label.Text = "Kira Bedeli:";
            this.rent_Label.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(63, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 82;
            this.label2.Text = "Kayıt Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(169, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 81;
            this.label1.Text = "Adı:";
            // 
            // save_Button
            // 
            this.save_Button.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.save_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.save_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_Button.Location = new System.Drawing.Point(418, 449);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(163, 57);
            this.save_Button.TabIndex = 12;
            this.save_Button.Text = "Kaydet";
            this.save_Button.UseVisualStyleBackColor = false;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // debt_NumericUpDown
            // 
            this.debt_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.debt_NumericUpDown.Location = new System.Drawing.Point(243, 216);
            this.debt_NumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.debt_NumericUpDown.Name = "debt_NumericUpDown";
            this.debt_NumericUpDown.Size = new System.Drawing.Size(338, 38);
            this.debt_NumericUpDown.TabIndex = 6;
            // 
            // dues_NumericUpDown
            // 
            this.dues_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dues_NumericUpDown.Location = new System.Drawing.Point(243, 127);
            this.dues_NumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.dues_NumericUpDown.Name = "dues_NumericUpDown";
            this.dues_NumericUpDown.Size = new System.Drawing.Size(338, 38);
            this.dues_NumericUpDown.TabIndex = 3;
            // 
            // rent_NumericUpDown
            // 
            this.rent_NumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rent_NumericUpDown.Location = new System.Drawing.Point(244, 318);
            this.rent_NumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.rent_NumericUpDown.Name = "rent_NumericUpDown";
            this.rent_NumericUpDown.Size = new System.Drawing.Size(170, 38);
            this.rent_NumericUpDown.TabIndex = 7;
            this.rent_NumericUpDown.Visible = false;
            // 
            // AdminNewMemberPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(672, 591);
            this.Controls.Add(this.rent_NumericUpDown);
            this.Controls.Add(this.dues_NumericUpDown);
            this.Controls.Add(this.debt_NumericUpDown);
            this.Controls.Add(this.isDuesPaid_GroupBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userName_TextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.userLoginName_TextBox);
            this.Controls.Add(this.registration_DateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.userLoginPassword_TextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rent_Label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.back_Button);
            this.MaximizeBox = false;
            this.Name = "AdminNewMemberPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni üye oluşturma sayfası";
            this.isDuesPaid_GroupBox.ResumeLayout(false);
            this.isDuesPaid_GroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debt_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dues_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rent_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_Button;
        private System.Windows.Forms.GroupBox isDuesPaid_GroupBox;
        private System.Windows.Forms.RadioButton isDuesPaidNo_RadioButton;
        private System.Windows.Forms.RadioButton isDuesPaidYes_RadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton host_RadioButton;
        private System.Windows.Forms.RadioButton tenant_RadioButton;
        private System.Windows.Forms.TextBox userName_TextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox userLoginName_TextBox;
        private System.Windows.Forms.DateTimePicker registration_DateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox userLoginPassword_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rent_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.NumericUpDown debt_NumericUpDown;
        private System.Windows.Forms.NumericUpDown dues_NumericUpDown;
        private System.Windows.Forms.NumericUpDown rent_NumericUpDown;
    }
}