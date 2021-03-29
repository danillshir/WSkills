namespace WSkills.Runer
{
    partial class RunnerRegistratsia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunnerRegistratsia));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.paswordAgainLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.paswordLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(19, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(263, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "MARATHON SKILLS 2021";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(16, 52);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(75, 18);
            this.labelTime.TabIndex = 35;
            this.labelTime.Text = "labelTime";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(-4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(875, 88);
            this.panel2.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Location = new System.Drawing.Point(-4, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 80);
            this.panel1.TabIndex = 42;
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(705, 481);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(122, 30);
            this.cancelButton.TabIndex = 66;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.ForeColor = System.Drawing.Color.Black;
            this.registerButton.Location = new System.Drawing.Point(567, 481);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(132, 30);
            this.registerButton.TabIndex = 65;
            this.registerButton.Text = "Регистрация";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryLabel.ForeColor = System.Drawing.Color.Black;
            this.countryLabel.Location = new System.Drawing.Point(572, 448);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(78, 22);
            this.countryLabel.TabIndex = 64;
            this.countryLabel.Text = "Страна:";
            // 
            // birthDateTimePicker
            // 
            this.birthDateTimePicker.Font = new System.Drawing.Font("Arial", 14.25F);
            this.birthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthDateTimePicker.Location = new System.Drawing.Point(656, 401);
            this.birthDateTimePicker.MaxDate = new System.DateTime(2011, 10, 21, 0, 0, 0, 0);
            this.birthDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.birthDateTimePicker.Name = "birthDateTimePicker";
            this.birthDateTimePicker.Size = new System.Drawing.Size(170, 29);
            this.birthDateTimePicker.TabIndex = 63;
            this.birthDateTimePicker.Value = new System.DateTime(1978, 7, 16, 0, 0, 0, 0);
            this.birthDateTimePicker.ValueChanged += new System.EventHandler(this.birthDateTimePicker_ValueChanged);
            // 
            // countryComboBox
            // 
            this.countryComboBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.countryComboBox.ForeColor = System.Drawing.Color.Black;
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(656, 445);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(170, 30);
            this.countryComboBox.TabIndex = 62;
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.birthLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthLabel.ForeColor = System.Drawing.Color.Black;
            this.birthLabel.Location = new System.Drawing.Point(503, 403);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(149, 22);
            this.birthLabel.TabIndex = 61;
            this.birthLabel.Text = "Дата рождения:";
            // 
            // photoButton
            // 
            this.photoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.photoButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoButton.ForeColor = System.Drawing.Color.Black;
            this.photoButton.Location = new System.Drawing.Point(704, 356);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(122, 30);
            this.photoButton.TabIndex = 60;
            this.photoButton.Text = "Просмотр...";
            this.photoButton.UseVisualStyleBackColor = true;
            this.photoButton.Click += new System.EventHandler(this.photoButton_Click);
            // 
            // photoTextBox
            // 
            this.photoTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.photoTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.photoTextBox.Location = new System.Drawing.Point(507, 357);
            this.photoTextBox.Multiline = true;
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.ReadOnly = true;
            this.photoTextBox.Size = new System.Drawing.Size(191, 30);
            this.photoTextBox.TabIndex = 59;
            // 
            // photoLabel
            // 
            this.photoLabel.AutoSize = true;
            this.photoLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoLabel.ForeColor = System.Drawing.Color.Black;
            this.photoLabel.Location = new System.Drawing.Point(518, 332);
            this.photoLabel.Name = "photoLabel";
            this.photoLabel.Size = new System.Drawing.Size(110, 22);
            this.photoLabel.TabIndex = 58;
            this.photoLabel.Text = "Фото файл:";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.photoPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("photoPictureBox.BackgroundImage")));
            this.photoPictureBox.Location = new System.Drawing.Point(705, 179);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(121, 151);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 57;
            this.photoPictureBox.TabStop = false;
            this.photoPictureBox.Click += new System.EventHandler(this.photoPictureBox_Click);
            // 
            // genderComboBox
            // 
            this.genderComboBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.genderComboBox.ForeColor = System.Drawing.Color.Black;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(218, 445);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(170, 30);
            this.genderComboBox.TabIndex = 56;
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexLabel.ForeColor = System.Drawing.Color.Black;
            this.sexLabel.Location = new System.Drawing.Point(160, 448);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(49, 22);
            this.sexLabel.TabIndex = 55;
            this.sexLabel.Text = "Пол:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.lastNameTextBox.Location = new System.Drawing.Point(218, 400);
            this.lastNameTextBox.Multiline = true;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(194, 30);
            this.lastNameTextBox.TabIndex = 54;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.Black;
            this.lastNameLabel.Location = new System.Drawing.Point(120, 403);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(92, 22);
            this.lastNameLabel.TabIndex = 53;
            this.lastNameLabel.Text = "Фамилия:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.Location = new System.Drawing.Point(218, 354);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(194, 30);
            this.nameTextBox.TabIndex = 52;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(160, 357);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(52, 22);
            this.nameLabel.TabIndex = 51;
            this.nameLabel.Text = "Имя:";
            // 
            // passwordAgainTextBox
            // 
            this.passwordAgainTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.passwordAgainTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordAgainTextBox.Location = new System.Drawing.Point(218, 305);
            this.passwordAgainTextBox.Multiline = true;
            this.passwordAgainTextBox.Name = "passwordAgainTextBox";
            this.passwordAgainTextBox.Size = new System.Drawing.Size(194, 30);
            this.passwordAgainTextBox.TabIndex = 50;
            // 
            // paswordAgainLabel
            // 
            this.paswordAgainLabel.AutoSize = true;
            this.paswordAgainLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paswordAgainLabel.ForeColor = System.Drawing.Color.Black;
            this.paswordAgainLabel.Location = new System.Drawing.Point(37, 308);
            this.paswordAgainLabel.Name = "paswordAgainLabel";
            this.paswordAgainLabel.Size = new System.Drawing.Size(175, 22);
            this.paswordAgainLabel.TabIndex = 49;
            this.paswordAgainLabel.Text = "Повторите пароль:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.Location = new System.Drawing.Point(218, 258);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(194, 30);
            this.passwordTextBox.TabIndex = 48;
            // 
            // paswordLabel
            // 
            this.paswordLabel.AutoSize = true;
            this.paswordLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.paswordLabel.ForeColor = System.Drawing.Color.Black;
            this.paswordLabel.Location = new System.Drawing.Point(131, 261);
            this.paswordLabel.Name = "paswordLabel";
            this.paswordLabel.Size = new System.Drawing.Size(81, 22);
            this.paswordLabel.TabIndex = 47;
            this.paswordLabel.Text = "Пароль:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Arial", 14.25F);
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.Location = new System.Drawing.Point(218, 209);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(224, 30);
            this.emailTextBox.TabIndex = 46;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(152, 212);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(62, 22);
            this.emailLabel.TabIndex = 45;
            this.emailLabel.Text = "Email:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.Black;
            this.descriptionLabel.Location = new System.Drawing.Point(108, 146);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(718, 44);
            this.descriptionLabel.TabIndex = 44;
            this.descriptionLabel.Text = "Пожалуйста заполните всю информацию, чтобы зарегистрироваться в качестве \r\nбегуна" +
    "";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.ForeColor = System.Drawing.Color.Black;
            this.registerLabel.Location = new System.Drawing.Point(293, 91);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(357, 42);
            this.registerLabel.TabIndex = 43;
            this.registerLabel.Text = "Регистрация бегуна";
            // 
            // RunnerRegistratsia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 617);
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
            this.Controls.Add(this.paswordAgainLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.paswordLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RunnerRegistratsia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2021 - Register as a runner";
            this.Load += new System.EventHandler(this.RunnerRegistratsia_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Label paswordAgainLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label paswordLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label registerLabel;
    }
}