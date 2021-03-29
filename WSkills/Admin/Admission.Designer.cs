namespace WSkills.Admin
{
    partial class Admission
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveButton = new System.Windows.Forms.Button();
            this.souvenirTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tshirtTextBox = new System.Windows.Forms.MaskedTextBox();
            this.waterTextBox = new System.Windows.Forms.MaskedTextBox();
            this.baseballTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rfidTextBox = new System.Windows.Forms.MaskedTextBox();
            this.idTextBox = new System.Windows.Forms.MaskedTextBox();
            this.admissionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.souvenirLabel = new System.Windows.Forms.Label();
            this.tshirtLabel = new System.Windows.Forms.Label();
            this.waterLabel = new System.Windows.Forms.Label();
            this.baseballCapLabel = new System.Windows.Forms.Label();
            this.rfidLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.inventoryLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(-3, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(818, 84);
            this.panel2.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 36);
            this.label1.TabIndex = 13;
            this.label1.Text = "MARATHON SKILLS 2021";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(15, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 36);
            this.button1.TabIndex = 14;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Location = new System.Drawing.Point(-3, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 88);
            this.panel1.TabIndex = 32;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(15, 55);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(63, 16);
            this.labelTime.TabIndex = 29;
            this.labelTime.Text = "labelTime";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // saveButton
            // 
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.Color.Black;
            this.saveButton.Location = new System.Drawing.Point(224, 381);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(138, 30);
            this.saveButton.TabIndex = 91;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // souvenirTextBox
            // 
            this.souvenirTextBox.Font = new System.Drawing.Font("Arial", 14.5F);
            this.souvenirTextBox.Location = new System.Drawing.Point(300, 332);
            this.souvenirTextBox.Name = "souvenirTextBox";
            this.souvenirTextBox.Size = new System.Drawing.Size(183, 30);
            this.souvenirTextBox.TabIndex = 90;
            // 
            // tshirtTextBox
            // 
            this.tshirtTextBox.Font = new System.Drawing.Font("Arial", 14.5F);
            this.tshirtTextBox.Location = new System.Drawing.Point(300, 302);
            this.tshirtTextBox.Name = "tshirtTextBox";
            this.tshirtTextBox.Size = new System.Drawing.Size(183, 30);
            this.tshirtTextBox.TabIndex = 89;
            // 
            // waterTextBox
            // 
            this.waterTextBox.Font = new System.Drawing.Font("Arial", 14.5F);
            this.waterTextBox.Location = new System.Drawing.Point(300, 272);
            this.waterTextBox.Name = "waterTextBox";
            this.waterTextBox.Size = new System.Drawing.Size(183, 30);
            this.waterTextBox.TabIndex = 88;
            // 
            // baseballTextBox
            // 
            this.baseballTextBox.Font = new System.Drawing.Font("Arial", 14.5F);
            this.baseballTextBox.Location = new System.Drawing.Point(300, 242);
            this.baseballTextBox.Name = "baseballTextBox";
            this.baseballTextBox.Size = new System.Drawing.Size(183, 30);
            this.baseballTextBox.TabIndex = 87;
            // 
            // rfidTextBox
            // 
            this.rfidTextBox.Font = new System.Drawing.Font("Arial", 14.5F);
            this.rfidTextBox.Location = new System.Drawing.Point(300, 212);
            this.rfidTextBox.Name = "rfidTextBox";
            this.rfidTextBox.Size = new System.Drawing.Size(183, 30);
            this.rfidTextBox.TabIndex = 86;
            // 
            // idTextBox
            // 
            this.idTextBox.Font = new System.Drawing.Font("Arial", 14.5F);
            this.idTextBox.Location = new System.Drawing.Point(300, 182);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(183, 30);
            this.idTextBox.TabIndex = 85;
            // 
            // admissionLabel
            // 
            this.admissionLabel.BackColor = System.Drawing.Color.DarkGray;
            this.admissionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.admissionLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.admissionLabel.ForeColor = System.Drawing.Color.Black;
            this.admissionLabel.Location = new System.Drawing.Point(300, 152);
            this.admissionLabel.Name = "admissionLabel";
            this.admissionLabel.Size = new System.Drawing.Size(183, 30);
            this.admissionLabel.TabIndex = 84;
            this.admissionLabel.Text = "Поступление";
            this.admissionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.DarkGray;
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(117, 152);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(183, 30);
            this.nameLabel.TabIndex = 83;
            this.nameLabel.Text = "Наименование";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // souvenirLabel
            // 
            this.souvenirLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.souvenirLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.souvenirLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.souvenirLabel.ForeColor = System.Drawing.Color.Black;
            this.souvenirLabel.Location = new System.Drawing.Point(117, 332);
            this.souvenirLabel.Name = "souvenirLabel";
            this.souvenirLabel.Size = new System.Drawing.Size(183, 30);
            this.souvenirLabel.TabIndex = 82;
            this.souvenirLabel.Text = "Сувенирный буклет";
            this.souvenirLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tshirtLabel
            // 
            this.tshirtLabel.BackColor = System.Drawing.Color.LightGray;
            this.tshirtLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tshirtLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.tshirtLabel.ForeColor = System.Drawing.Color.Black;
            this.tshirtLabel.Location = new System.Drawing.Point(117, 302);
            this.tshirtLabel.Name = "tshirtLabel";
            this.tshirtLabel.Size = new System.Drawing.Size(183, 30);
            this.tshirtLabel.TabIndex = 81;
            this.tshirtLabel.Text = "Футболка";
            this.tshirtLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // waterLabel
            // 
            this.waterLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.waterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waterLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.waterLabel.ForeColor = System.Drawing.Color.Black;
            this.waterLabel.Location = new System.Drawing.Point(117, 272);
            this.waterLabel.Name = "waterLabel";
            this.waterLabel.Size = new System.Drawing.Size(183, 30);
            this.waterLabel.TabIndex = 80;
            this.waterLabel.Text = "Бутылка воды";
            this.waterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // baseballCapLabel
            // 
            this.baseballCapLabel.BackColor = System.Drawing.Color.LightGray;
            this.baseballCapLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseballCapLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.baseballCapLabel.ForeColor = System.Drawing.Color.Black;
            this.baseballCapLabel.Location = new System.Drawing.Point(117, 242);
            this.baseballCapLabel.Name = "baseballCapLabel";
            this.baseballCapLabel.Size = new System.Drawing.Size(183, 30);
            this.baseballCapLabel.TabIndex = 79;
            this.baseballCapLabel.Text = "Бейсболка";
            this.baseballCapLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rfidLabel
            // 
            this.rfidLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.rfidLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rfidLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.rfidLabel.ForeColor = System.Drawing.Color.Black;
            this.rfidLabel.Location = new System.Drawing.Point(117, 212);
            this.rfidLabel.Name = "rfidLabel";
            this.rfidLabel.Size = new System.Drawing.Size(183, 30);
            this.rfidLabel.TabIndex = 78;
            this.rfidLabel.Text = "RFID браслет";
            this.rfidLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idLabel
            // 
            this.idLabel.BackColor = System.Drawing.Color.LightGray;
            this.idLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idLabel.Font = new System.Drawing.Font("Arial", 14.25F);
            this.idLabel.ForeColor = System.Drawing.Color.Black;
            this.idLabel.Location = new System.Drawing.Point(117, 182);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(183, 30);
            this.idLabel.TabIndex = 77;
            this.idLabel.Text = "Номер бегуна";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inventoryLabel
            // 
            this.inventoryLabel.AutoSize = true;
            this.inventoryLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inventoryLabel.ForeColor = System.Drawing.Color.Black;
            this.inventoryLabel.Location = new System.Drawing.Point(256, 96);
            this.inventoryLabel.Name = "inventoryLabel";
            this.inventoryLabel.Size = new System.Drawing.Size(318, 32);
            this.inventoryLabel.TabIndex = 76;
            this.inventoryLabel.Text = "Поступление инвентаря";
            // 
            // Admission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 516);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.souvenirTextBox);
            this.Controls.Add(this.tshirtTextBox);
            this.Controls.Add(this.waterTextBox);
            this.Controls.Add(this.baseballTextBox);
            this.Controls.Add(this.rfidTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.admissionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.souvenirLabel);
            this.Controls.Add(this.tshirtLabel);
            this.Controls.Add(this.waterLabel);
            this.Controls.Add(this.baseballCapLabel);
            this.Controls.Add(this.rfidLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.inventoryLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Admission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admission";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.MaskedTextBox souvenirTextBox;
        private System.Windows.Forms.MaskedTextBox tshirtTextBox;
        private System.Windows.Forms.MaskedTextBox waterTextBox;
        private System.Windows.Forms.MaskedTextBox baseballTextBox;
        private System.Windows.Forms.MaskedTextBox rfidTextBox;
        private System.Windows.Forms.MaskedTextBox idTextBox;
        private System.Windows.Forms.Label admissionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label souvenirLabel;
        private System.Windows.Forms.Label tshirtLabel;
        private System.Windows.Forms.Label waterLabel;
        private System.Windows.Forms.Label baseballCapLabel;
        private System.Windows.Forms.Label rfidLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label inventoryLabel;
    }
}