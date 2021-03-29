namespace WSkills.Runer
{
    partial class RunnerEdit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunnerEdit));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.emailUserLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.countryLabel = new System.Windows.Forms.Label();
            this.birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.birthLabel = new System.Windows.Forms.Label();
            this.photoButton = new System.Windows.Forms.Button();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.photoLabel = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.sexLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passwordAgainTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.paswordLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.paswordAgainLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(16, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 36);
            this.button1.TabIndex = 22;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 36);
            this.label1.TabIndex = 21;
            this.label1.Text = "MARATHON SKILLS 2021";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(13, 49);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(63, 16);
            this.labelTime.TabIndex = 58;
            this.labelTime.Text = "labelTime";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-4, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 81);
            this.panel1.TabIndex = 59;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Location = new System.Drawing.Point(-4, 570);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 77);
            this.panel2.TabIndex = 60;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.Gray;
            this.descriptionLabel.Location = new System.Drawing.Point(475, 331);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(367, 46);
            this.descriptionLabel.TabIndex = 124;
            this.descriptionLabel.Text = "Оставьте эти поля, незаполненными,\r\nесли вы не хотите изменять пароль";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // emailUserLabel
            // 
            this.emailUserLabel.AutoSize = true;
            this.emailUserLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailUserLabel.ForeColor = System.Drawing.Color.Gray;
            this.emailUserLabel.Location = new System.Drawing.Point(193, 173);
            this.emailUserLabel.Name = "emailUserLabel";
            this.emailUserLabel.Size = new System.Drawing.Size(224, 23);
            this.emailUserLabel.TabIndex = 122;
            this.emailUserLabel.Text = "the.email@address.com";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Arial", 17.75F);
            this.changeLabel.ForeColor = System.Drawing.Color.Black;
            this.changeLabel.Location = new System.Drawing.Point(578, 300);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(171, 27);
            this.changeLabel.TabIndex = 123;
            this.changeLabel.Text = "Смена пароля";
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(469, 517);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(122, 30);
            this.cancelButton.TabIndex = 121;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.ForeColor = System.Drawing.Color.Black;
            this.registerButton.Location = new System.Drawing.Point(316, 517);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(132, 30);
            this.registerButton.TabIndex = 120;
            this.registerButton.Text = "Сохранить";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.ForeColor = System.Drawing.Color.Black;
            this.countryLabel.Location = new System.Drawing.Point(109, 395);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(78, 22);
            this.countryLabel.TabIndex = 119;
            this.countryLabel.Text = "Страна:";
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.CustomFormat = "dd.MM.yyyy";
            this.birthDateTimePicker.Font = new System.Drawing.Font("Arial", 14.25F);
            this.birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateTimePicker.Location = new System.Drawing.Point(193, 348);
            this.birthDateTimePicker.MaxDate = new System.DateTime(2011, 2, 4, 0, 0, 0, 0);
            this.birthDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(170, 29);
            this.birthDateTimePicker.TabIndex = 118;
            this.birthDateTimePicker.Value = new System.DateTime(1978, 7, 16, 0, 0, 0, 0);
            // 
            // countryComboBox
            // 
            this.countryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countryComboBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.countryComboBox.ForeColor = System.Drawing.Color.Black;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(193, 392);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(170, 30);
            this.countryComboBox.TabIndex = 117;
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthLabel.ForeColor = System.Drawing.Color.Black;
            this.birthLabel.Location = new System.Drawing.Point(40, 350);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(149, 22);
            this.birthLabel.TabIndex = 116;
            this.birthLabel.Text = "Дата рождения:";
            // 
            // photoButton
            // 
            this.photoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.photoButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoButton.ForeColor = System.Drawing.Color.Black;
            this.photoButton.Location = new System.Drawing.Point(697, 255);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(122, 30);
            this.photoButton.TabIndex = 115;
            this.photoButton.Text = "Просмотр...";
            this.photoButton.UseVisualStyleBackColor = true;
            this.photoButton.Click += new System.EventHandler(this.photoButton_Click);
            // 
            // photoTextBox
            // 
            this.photoTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.photoTextBox.ForeColor = System.Drawing.Color.Black;
            this.photoTextBox.Location = new System.Drawing.Point(500, 256);
            this.photoTextBox.Multiline = true;
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.Size = new System.Drawing.Size(191, 30);
            this.photoTextBox.TabIndex = 114;
            // 
            // photoLabel
            // 
            this.photoLabel.AutoSize = true;
            this.photoLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoLabel.ForeColor = System.Drawing.Color.Black;
            this.photoLabel.Location = new System.Drawing.Point(511, 231);
            this.photoLabel.Name = "photoLabel";
            this.photoLabel.Size = new System.Drawing.Size(110, 22);
            this.photoLabel.TabIndex = 113;
            this.photoLabel.Text = "Фото файл:";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.photoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("photoPictureBox.BackgroundImage")));
            this.photoPictureBox.Location = new System.Drawing.Point(697, 98);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(121, 151);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 112;
            this.photoPictureBox.TabStop = false;
            this.photoPictureBox.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // genderComboBox
            // 
            this.genderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderComboBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.genderComboBox.ForeColor = System.Drawing.Color.Black;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(192, 302);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(170, 30);
            this.genderComboBox.TabIndex = 111;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.ForeColor = System.Drawing.Color.Black;
            this.sexLabel.Location = new System.Drawing.Point(134, 305);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(49, 22);
            this.sexLabel.TabIndex = 110;
            this.sexLabel.Text = "Пол:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.lastNameTextBox.Location = new System.Drawing.Point(192, 257);
            this.lastNameTextBox.Multiline = true;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(194, 30);
            this.lastNameTextBox.TabIndex = 109;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.Black;
            this.lastNameLabel.Location = new System.Drawing.Point(94, 260);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(92, 22);
            this.lastNameLabel.TabIndex = 108;
            this.lastNameLabel.Text = "Фамилия:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.Location = new System.Drawing.Point(192, 211);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(194, 30);
            this.nameTextBox.TabIndex = 107;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(134, 214);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 22);
            this.nameLabel.TabIndex = 106;
            this.nameLabel.Text = "Имя:";
            // 
            // passwordAgainTextBox
            // 
            this.passwordAgainTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.passwordAgainTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordAgainTextBox.Location = new System.Drawing.Point(625, 441);
            this.passwordAgainTextBox.Multiline = true;
            this.passwordAgainTextBox.Name = "passwordAgainTextBox";
            this.passwordAgainTextBox.Size = new System.Drawing.Size(194, 30);
            this.passwordAgainTextBox.TabIndex = 105;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.Location = new System.Drawing.Point(625, 394);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(194, 30);
            this.passwordTextBox.TabIndex = 103;
            // 
            // paswordLabel
            // 
            this.paswordLabel.AutoSize = true;
            this.paswordLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paswordLabel.ForeColor = System.Drawing.Color.Black;
            this.paswordLabel.Location = new System.Drawing.Point(538, 397);
            this.paswordLabel.Name = "paswordLabel";
            this.paswordLabel.Size = new System.Drawing.Size(81, 22);
            this.paswordLabel.TabIndex = 102;
            this.paswordLabel.Text = "Пароль:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(125, 173);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(62, 22);
            this.emailLabel.TabIndex = 101;
            this.emailLabel.Text = "Email:";
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Arial", 18.75F);
            this.registerLabel.ForeColor = System.Drawing.Color.Black;
            this.registerLabel.Location = new System.Drawing.Point(252, 98);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(400, 28);
            this.registerLabel.TabIndex = 100;
            this.registerLabel.Text = "Редактирование профиля бегуна";
            // 
            // paswordAgainLabel
            // 
            this.paswordAgainLabel.AutoSize = true;
            this.paswordAgainLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paswordAgainLabel.ForeColor = System.Drawing.Color.Black;
            this.paswordAgainLabel.Location = new System.Drawing.Point(444, 444);
            this.paswordAgainLabel.Name = "paswordAgainLabel";
            this.paswordAgainLabel.Size = new System.Drawing.Size(175, 22);
            this.paswordAgainLabel.TabIndex = 104;
            this.paswordAgainLabel.Text = "Повторите пароль:";
            // 
            // RunnerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 645);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.emailUserLabel);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.birthDateTimePicker);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.photoButton);
            this.Controls.Add(this.photoTextBox);
            this.Controls.Add(this.photoLabel);
            this.Controls.Add(this.photoPictureBox);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.sexLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.passwordAgainTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.paswordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.paswordAgainLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RunnerEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunnerEdit";
            this.Load += new System.EventHandler(this.RunnerEdit_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label descriptionLabel;
        public System.Windows.Forms.Label emailUserLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.DateTimePicker birthDateTimePicker;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Button photoButton;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.Label photoLabel;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox passwordAgainTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label paswordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label paswordAgainLabel;
    }
}